using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SocketServer1
{
    public partial class SocketServerForm : Form
    {
        public SocketServerForm()
        {
            InitializeComponent();
        }
        private delegate void showMsgDelegate(string str);//定义一个委托
        private void showMsg(string str)
        {
            if (this.listBox_receiveMsg.InvokeRequired)
            {
                showMsgDelegate msgDelegate = new showMsgDelegate(showMsg);
                this.listBox_receiveMsg.Invoke(msgDelegate, str);
            }
            else
            {
                this.listBox_receiveMsg.Items.Add(str + "\r\n");
            }
        }
        //点击进行监听
        private void listenClient_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //点击开始监听时 在服务端创建一个负责监听IP和端口号的Socket
                Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Any;
                //创建对象端口
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(textBox_port.Text.Trim()));

                socketWatch.Bind(point);//绑定端口号
                showMsg("监听成功!");
                socketWatch.Listen(10);//设置监听

                //创建监听客户端的线程
                Thread thread = new Thread(Listen);
                thread.IsBackground = true;
                thread.Start(socketWatch);
            } catch {
                
            }
        }
        //显示提示信息
        public void ShowMsg(string msg)
        {
            listBox_receiveMsg.Items.Add(msg + "\r\n");//显示一行信息
        }
        public void Listen(object o)
        {
            try
            {
                Socket socketWatch = o as Socket;
                while (true)
                {
                    Socket socketSend1 = socketWatch.Accept();//等待接收客户端连接
                    socketSend = socketSend1;
                    showMsg(socketSend.RemoteEndPoint.ToString() + ":" + "连接成功!");
                    //开启一个新线程，执行接收消息方法
                    Thread receiveClient_thread = new Thread(Received);
                    receiveClient_thread.IsBackground = true;
                    receiveClient_thread.Start(socketSend);
                }
            } catch (SocketException e){
                Console.WriteLine(e.ToString());
            }
        }
        /// <summary>
        /// 服务器端不停的接收客户端发来的消息
        /// </summary>
        /// <param name="o"></param>
        void Received(object o)
        {
            try
            {
                Socket socketSend = o as Socket;
                while (true)
                {
                    //客户端连接服务器成功后，服务器接收客户端发送的消息
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    //实际接收到的有效字节数
                    int len = socketSend.Receive(buffer);
                    Console.WriteLine(len);
                    if (len == 0)
                    {
                        break;
                    }
                    string str = Encoding.UTF8.GetString(buffer, 0, len);
                    Console.WriteLine(str);
                    showMsg(socketSend.RemoteEndPoint + ":" + str);
                }
            }
            catch { }
        }
        Socket socketSend;
        void Send(string str)
        {
            byte[] msgBytes = Encoding.UTF8.GetBytes(str);
            socketSend.Send(msgBytes);
        }
        private void sendMsg_btn_Click(object sender, EventArgs e)
        {
            Send(textBox_sendMsg.Text.Trim());
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label_IP_Click(object sender, EventArgs e)
        {

        }

        private void textBox_port_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_sendMsg_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_IP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
