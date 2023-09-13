
using System.ComponentModel;
using System.Drawing.Text;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //------------------------------
        //백그라운드 메세지 수신 스레드 참조변수
        //------------------------------
        private BackgroundWorker recvLedWorker;
        private BackgroundWorker recvTmpWorker;
        private BackgroundWorker recvLightWorker;
        private BackgroundWorker recvDistanceWorker;
        private void conn_btn_Click(object sender, EventArgs e)
        {
            String port = this.comboBox1.Items[this.comboBox1.SelectedIndex].ToString();
            Console.WriteLine("PORT : " + port);

            HttpWebRequest request = null;
            HttpWebResponse response = null;

            try
            {
                request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8080/arduino/connection/" + port);
                request.Method = "GET";
                request.ContentType = "application/json";
                //request.Timeout = 30 * 1000;

                response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Console.WriteLine("RESPONSE CODE : " + response.StatusCode);
                    //--------------------------------------
                    //수신 스레드 객체 생성 & 스레드 등록
                    //--------------------------------------
                    //LED
                    recvLedWorker = new BackgroundWorker();
                    recvLedWorker.DoWork += recvLedInfo;
                    //TMP
                    recvTmpWorker = new BackgroundWorker();
                    recvTmpWorker.DoWork += recvTmpInfo;
                    //LIGHT
                    recvLightWorker = new BackgroundWorker();
                    recvLightWorker.DoWork += recvLightInfo;
                    //DISTNACE
                    recvDistanceWorker = new BackgroundWorker();
                    recvDistanceWorker.DoWork += recvDistanceInfo;
                    //--------------------------------------
                    //수신 스레드 실행
                    //--------------------------------------
                    recvLedWorker.RunWorkerAsync();
                    recvTmpWorker.RunWorkerAsync();
                    recvLightWorker.RunWorkerAsync();
                    recvDistanceWorker.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ex : " + ex.Message + "" + ex.Data);
            }
        }

        private void recvLedInfo(object sender, DoWorkEventArgs e)
        {
            while (!recvLedWorker.CancellationPending)
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8080/arduino/message/led");
                request.Method = "GET";
                request.ContentType = "application/json";
                //request.Timeout = 30 * 1000;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                //Invoke(new Action(()=>{}))
                Invoke(new Action(() =>
                {
                    this.led_txt.Text = reader.ReadToEnd();
                }));



                Thread.Sleep(800);
            }
        }
        private void recvTmpInfo(object sender, DoWorkEventArgs e)
        {
            while (!recvTmpWorker.CancellationPending)
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8080/arduino/message/tmp");
                request.Method = "GET";
                request.ContentType = "application/json";
                //request.Timeout = 30 * 1000;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                //Invoke(new Action(()=>{}))
                Invoke(new Action(() =>
                {
                    this.tmp_txt.Text = reader.ReadToEnd();
                }));



                Thread.Sleep(800);
            }
        }
        private void recvLightInfo(object sender, DoWorkEventArgs e)
        {
            while (!recvLightWorker.CancellationPending)
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8080/arduino/message/light");
                request.Method = "GET";
                request.ContentType = "application/json";
                //request.Timeout = 30 * 1000;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                //Invoke(new Action(()=>{}))
                Invoke(new Action(() =>
                {
                    this.light_txt.Text = reader.ReadToEnd();
                }));



                Thread.Sleep(800);
            }
        }
        private void recvDistanceInfo(object sender, DoWorkEventArgs e)
        {
            while (!recvDistanceWorker.CancellationPending)
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8080/arduino/message/distance");
                request.Method = "GET";
                request.ContentType = "application/json";
                //request.Timeout = 30 * 1000;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                //Invoke(new Action(()=>{}))
                Invoke(new Action(() =>
                {
                    this.dis_txt.Text = reader.ReadToEnd();
                }));



                Thread.Sleep(800);
            }
        }
        private void led_on_btn_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8080/arduino/led/1");
            request.Method = "GET";
            request.ContentType = "application/json";
            //request.Timeout = 30 * 1000;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        }

        private void led_off_btn_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8080/arduino/led/0");
            request.Method = "GET";
            request.ContentType = "application/json";
            //request.Timeout = 30 * 1000;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        }
    }
}
