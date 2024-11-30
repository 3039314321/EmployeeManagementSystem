using Mina.Core.Service;
using Mina.Core.Session;
using Mina.Filter.Codec.TextLine;
using Mina.Filter.Codec;
using Mina.Transport.Socket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using static System.Collections.Specialized.BitVector32;
using System.IO;

using Newtonsoft.Json;
using MySqlConnector;
using Google.Protobuf.WellKnownTypes;
using static Mysqlx.Expect.Open.Types.Condition.Types;
using Newtonsoft.Json.Linq;

namespace EmployeeServer
{
    public partial class Server : Form
    {
        private const string filePath = "clients.txt";

        public Server()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;//取消线程间的安全检查
            label4.Text = DateTime.Now.ToString();
            LoadClientsFromFile();
            open();
        }

        #region ======变量字段
        bool status = false;//服务开启状态
        private string linebreak = "\r\n";
        private string str;
        IoSession Session = null;
        IoAcceptor acceptor = null;
        private Dictionary<string, IoSession> Clientlist = new Dictionary<string, IoSession>();
        public static Dictionary<string, string> ShareDict = new Dictionary<string, string>();
        #endregion
        #region ======OpenServer

        int invokenum = 0;
        private void open()
        {
            if (status == false)
            {


                acceptor = new AsyncSocketAcceptor();
                //下面这个本质上就是一个循环函数，接受到新的就在这个进程中创建：
                acceptor.SessionCreated += (o, e) =>
                {
                    string port = e.Session.RemoteEndPoint.ToString().Split(':')[1];//获取端口
                    Session = e.Session;
                    Clientlist.Add(port, Session);//添加到控件
                    ChatList.Invoke(new Action(() => { ChatList.AppendText("客户端连接成功！" + port + " : " + GetNowTime() + linebreak); }));
                    invokenum += 1;
                    label7.Text = invokenum.ToString();
                    SaveClientToFile(port);
                };
                // acceptor.FilterChain.AddLast("codec", new ProtocolCodecFilter(new TextLineCodecFactory(Encoding.UTF8)));
                acceptor.FilterChain.AddLast("codec", new ProtocolCodecFilter(new TextLineCodecFactory(Encoding.GetEncoding("UTF-8"))));
                acceptor.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 60000));
                ChatList.AppendText("开始监听客户端消息---" + GetNowTime() + linebreak);
                status = true;
           
                acceptor.MessageReceived += (o, e) =>
                {
                    try
                    {
                        string port = e.Session.RemoteEndPoint.ToString().Split(':')[1];
                        ChatList.Invoke(new Action<string>(s => ChatList.AppendText(s)), "监听端端口：" + port + linebreak);

                        // ChatList.Invoke(new Action(() => { ChatList.AppendText("监听端端口：" + port + linebreak); }));//显示监听端口
                        //

                        str = "客户端：" + GetNowTime() + linebreak + e.Message + linebreak;//显示时间
                                                                                        // ClientList.Add(port, 1);
                        string info = e.Message.ToString();
                        Operator temp = new Operator();
                        temp = unpacked(info);


                        if (ShareDict.ContainsKey(port))
                        {
                           
                            ChatList.Invoke(new Action(() => { ChatList.AppendText(str); }));
                        }
                        else
                        {
                            input_info(port, info);
                            ChatList.Invoke(new Action(() => { ChatList.AppendText(str); }));

                        }
                        

                    }
                    catch (Exception ex)
                    {
                        ChatList.Invoke(new Action(() => { ChatList.AppendText(ex.Message + linebreak); }));
                        // comboBox1.Items.Remove(port);

                    }
                };
            }
            else if (status == true)
            {
                MessageBox.Show("打开服务");
                ChatList.Text = string.Empty;
                ShutdownSocket();

            }
        }
        #endregion
        #region ======ShutdownServer
        public void ShutdownSocket()
        {

            status = false;
            Session.Close(true);
            Session = null;
            acceptor.Unbind();
            acceptor = null;
        }
        #endregion
        public string GetNowTime()
        {
            string time = DateTime.Now.ToString();
            return time;
        }
        private void input_info(string key, string value)
        {
            add_Dictionary(key, value);//添加
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        #region ======增删改查
        public void add_Dictionary(string a, string b)//添加
        {
            string value;
            ShareDict.TryGetValue(a, out value);
            if (value == null)
            {
                ShareDict[a] = b;
                return;
            }
            ShareDict.Add(a, b);

        }
        public string Get_Dictionary(string a)//查询
        {
            string value = ShareDict[a];
            return value;
        }
        public void Delect_Dictionary(string a) //删除
        {
            ShareDict.Remove(a);
        }
        public void re_Dictionary(string a, string b) //修改
        {
            ShareDict[a] = b;
        }
        #endregion

        private Operator unpacked(string port)
        {
            string jsonPackage = ShareDict[port];
            var unpackedPackage = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonPackage);
            int Flage = 0;
            Operator newOperator = new Operator();
            foreach (var item in unpackedPackage)
            {
                Console.WriteLine($"字段: {item.Key}, 属性值: {item.Value}");
                int i = 1;
                string key = item.Key;
                string value = item.Value;

                if (i == 1)
                {
                    if ((key == "action" && value == null) || (key == null && value == null))
                    {
                        return null;
                    }
                    else
                    {
                        switch (value)
                        {
                            case "register":
                                Flage = 0;
                                //Register(key, value);
                                break;
                            case "login":
                                Flage = 1;
                                // Login(key, value);
                                break;
                            case "changePassword":
                                Flage = 2;
                                // ChangePassword(key, value);
                                break;
                            default:
                                break;

                        }
                    }
                }
                else {
                    if (Flage == 0)
                    {//注册
                        switch (key)
                        {
                            case "loginName":
                                newOperator.LoginName = value;
                                break;
                            case "password":
                                newOperator.Password = value;
                                break;
                            case "name":
                                newOperator.Name = value;
                                break;
                            case "contactNumber":
                                newOperator.ContactNumber = value;
                                break;
                            case "gender":
                                newOperator.Gender = value;
                                break;
                            default:
                                break;

                        }
                    }
                    else if (Flage == 1)
                    { //登录
                        switch (key)
                        {
                            case "loginName":
                                newOperator.LoginName = value;
                                break;
                            case "password":
                                newOperator.Password = value;
                                break;
                        }
                    }
                    else
                    {
                        switch (key)
                        {
                            case "loginName":
                                newOperator.LoginName = value;
                                break;
                            case "oldpassword":
                                break;
                            case "password":
                                newOperator.Password = value;
                                break;
                           
                            default:
                                break;

                        }
                    }
                }

                //unPackDict.Add(item.Key, item.Value);



            }
            if(Flage == 0)
            {
                Register(newOperator.LoginName, newOperator.Password);
            }
            else if(Flage == 1) 
            {
                Login(newOperator.LoginName, newOperator.Password);
            }
            else if(Flage == 2){
                ChangePassword(newOperator.LoginName, newOperator.Password);
            }
            return newOperator;
        }
        public static Dictionary<string, string> unPackDict = new Dictionary<string, string>();
        private void chuli(string key,string value)
        {
            if ((key == "action" && value == null) || (key == null && value == null))
            {
                return;
            }
            else
            {
                switch (value)
                {
                    case "register":
                        Register(key, value);
                        break;
                    case "login":
                        Login(key, value);
                        break;
                    case "changePassword":
                        ChangePassword(key, value);
                        break;
                    default:
                        break;

                }
            }
        }
        public class Operator
        {
            public string LoginName { get; set; }
            public string Password { get; set; }
            public string Name { get; set; }
            public string ContactNumber { get; set; }
            public string Gender { get; set; }
        }


        private List<Operator> operators = new List<Operator>();
        public void Register(string loginName, string password)
        {
            Operator newOperator = new Operator
            {
                LoginName = loginName,
                Password = password,
            };
            operators.Add(newOperator);
            //操作元登录
        }
        public bool Login(string loginName, string password)
        {
            foreach (var op in operators)
            {
                if (op.LoginName == loginName && op.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ChangePassword(string loginName,  string newPassword)
        {
            foreach (var op in operators)
            {
              
                    op.Password = newPassword;
                    return true;
               
            }
            return false;
        }
        private void SaveClientToFile(string port)
        {
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(port);
            }
        }
        private void LoadClientsFromFile()
        {
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!Clientlist.ContainsKey(line))
                        {
                            Clientlist.Add(line, null);
                        }
                    }
                }
            }
        }
    }
}
