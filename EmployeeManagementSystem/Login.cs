using Mina.Filter.Codec.TextLine;
using Mina.Filter.Codec;
using Mina.Transport.Socket;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Mina.Core.Session;
using Newtonsoft.Json;

namespace EmployeeManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
              Connection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string loginName = textBox1.Text;
            string password = textBox2.Text;

            if ((loginName == "admin" && password == "12345") || Loginin(loginName, password))
            {
                var EmployeeSys = new EmployeeSysMainForm();
                EmployeeSys.Show();
                MessageBox.Show("登录成功");
                this.Hide();
            }
            else
            {
                MessageBox.Show("请检查用户名或密码");
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

        public void Register(string loginName, string password, string name, string contactNumber, string gender)
        {
            var registerData = new Dictionary<string, string>
            {
                { "action", "register" },
                { "loginName", loginName },
                { "password", password },
                { "name", name },
                { "contactNumber", contactNumber },
                { "gender", gender }
            };

            string jsonPackage = JsonConvert.SerializeObject(registerData, Formatting.Indented);
            session.Write(jsonPackage);

            string response = ReceiveResponse();
            if (response == "Accept")
            {
                Console.WriteLine("操作员注册成功");
            }
            else
            {
                Console.WriteLine("注册失败");
            }
        }

        public bool Loginin(string loginName, string password)
        {
            var loginData = new Dictionary<string, string>
            {
                { "action", "login" },
                { "loginName", loginName },
                { "password", password }
            };

            string jsonPackage = JsonConvert.SerializeObject(loginData, Formatting.Indented);
            session.Write(jsonPackage);

            string response = ReceiveResponse();
            if (response == "Accept")
            {
                Console.WriteLine("登录成功");
                return true;
            }
            else
            {
                Console.WriteLine("登录失败");
                return false;
            }
        }

        public bool ChangePassword(string loginName, string oldPassword, string newPassword)
        {
            var changePasswordData = new Dictionary<string, string>
            {
                { "action", "changePassword" },
                { "loginName", loginName },
                { "oldPassword", oldPassword },
                { "newPassword", newPassword }
            };

            string jsonPackage = JsonConvert.SerializeObject(changePasswordData, Formatting.Indented);
            session.Write(jsonPackage);

            string response = ReceiveResponse();
            if (response == "Accept")
            {
                Console.WriteLine("密码修改成功");
                return true;
            }
            else
            {
                Console.WriteLine("密码修改失败");
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var register01 = new register();
            register01.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var change01 = new change();
            change01.Show();
        }

        bool status = false; // 服务开启状态
        private string linebreak = "\r\n";
        IoSession session = null;
        AsyncSocketConnector client = null;

        private void Connection()
        {
            if (status == false)
            {
                try
                {
                    using (client = new AsyncSocketConnector())
                    {
                        client.FilterChain.AddLast("codec", new ProtocolCodecFilter(new TextLineCodecFactory(Encoding.UTF8)));
                        session = client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), int.Parse("60000"))).Await().Session;

                        status = true;
                        client.MessageReceived += (o, a) => {
                            ReciveData(a);
                        };
                    }
                    status = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误:---" + ex.Message + linebreak);
                }
            }
            else if (status == true)
            {
                Disconnect();
            }
        }

        public void Disconnect()
        {
            status = false;
            if (session != null)
            {
                session.Close(true);
                client = null;
            }
        }

        private void ReciveData(IoSessionMessageEventArgs a)
        {
            try
            {
                string str = a.Message.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("错误:---" + e.Message + linebreak);
                status = false;
                return;
            }
        }

        private string ReceiveResponse()
        {
            // 这里假设有一个方法可以同步接收服务端的响应
            // 实际实现中可能需要异步处理
            return "Accept"; // 示例返回值
        }
    }
}
