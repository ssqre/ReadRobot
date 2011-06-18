using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.IO.Ports;

namespace SimpleSpeechReco
{
    public partial class Form1 : Form
    {
        //新建一个语音识别引擎实例
        private SpeechRecognitionEngine SRE;

        //实例化串口对象（默认：COM1，9600，e，8，1）
        SerialPort SPort = new SerialPort();

        public Form1()
        {
            InitializeComponent();
        }

        //语音识别事件处理函数
        void G_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string text = e.Result.Text;
            byte[] bytesend = { 0 };
            switch (text)
            {
                case "向左翻":
                    BackColor = Color.Blue;
                    bytesend[0] = 0x8F;
                    WritePort(bytesend);
                    labelStateShow.Text = "执行" + text + "命令";
                    break;
                case "向右翻":
                    BackColor = Color.Green;
                    bytesend[0] = 0x0F;
                    WritePort(bytesend);
                    labelStateShow.Text = "执行" + text + "命令";
                    break;
                case "停止翻":
                    BackColor = Color.Gray;
                    bytesend[0] = 0;
                    WritePort(bytesend);
                    labelStateShow.Text = "执行" + text + "命令";
                    break;
                case "停止翻书":
                    BackColor = Color.Gray;
                    bytesend[0] = 0;
                    WritePort(bytesend);
                    labelStateShow.Text = "执行" + text + "命令";
                    break;
                /*case "おはようございます":
                    BackColor = Color.Gray;
                    bytesend[0] = 0x8F;
                    WritePort(bytesend);
                    labelStateShow.Text = "执行" + text + "命令";
                    break;
                case "こんにちは":
                    BackColor = Color.Gray;
                    bytesend[0] = 0x0F;
                    WritePort(bytesend);
                    labelStateShow.Text = "执行" + text + "命令";
                    break;
                default:
                    labelStateShow.Text = "您在说什么？";
                    break;*/
            }
        }

        //写端口函数，把bytesend写到串口
        private void WritePort(byte[] bytesend)
        {
            if (SPort.IsOpen == false)
            {
                SPort.Open();
            }
            SPort.Write(bytesend, 0, bytesend.Length);
            SPort.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化串口
            InitializeSerialPort();
            //初始化语音识别引擎
            InitializeSpeechEngine();
        }

        private void rdoVoiceControl_CheckedChanged(object sender, EventArgs e)
        {
            btnLeft.Enabled = false;
            btnRight.Enabled = false;
            btnStop.Enabled = false;
            btnVoiceControl.Enabled = true;
            btnVoiceControl.Text = "开启语音控制";
            //异步调用识别引擎，且允许多次调用
            //SRE.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void rdoHandControl_CheckedChanged(object sender, EventArgs e)
        {
            btnLeft.Enabled = true;
            btnRight.Enabled = true;
            btnStop.Enabled = true;
            btnVoiceControl.Enabled = false;
            btnVoiceControl.Text = "语音控制";
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            byte[] bytesend = { 0x8F };
            if (txtYeShu.Text == "")
            {
                bytesend[0] = 0x8F;
            }
            else
            {
                bytesend[0] = Convert.ToByte(txtYeShu.Text);
            }
            WritePort(bytesend);
            labelStateShow.Text = "执行向左翻命令";
            //MessageBox.Show("向左翻");
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            byte[] bytesend = { 0x0F };
            if (txtYeShu.Text == "")
            {
                bytesend[0] = 0x0F;
            }
            else
            {
                bytesend[0] = Convert.ToByte(Convert.ToInt32(txtYeShu.Text) + 128);
            }
            WritePort(bytesend);
            labelStateShow.Text = "执行向右翻命令";
            //MessageBox.Show("向右翻");
        }

        private void InitializeSerialPort()
        {
            //更改参数
            SPort.PortName = "COM3";
            SPort.BaudRate = 9600;
            SPort.Parity = Parity.None;
            SPort.DataBits = 8;
            SPort.StopBits = StopBits.One;
            SPort.ReadBufferSize = 4096;
        }

        private void InitializeSpeechEngine()
        {
            SRE = new SpeechRecognitionEngine();
            SRE.SetInputToDefaultAudioDevice();
            GrammarBuilder GB = new GrammarBuilder();
            //GB.Append("向");
            GB.Append(new Choices(new string[] { "向左翻", "向右翻", "停止翻", "停止翻书" }));
            Grammar G = new Grammar(GB);
            G.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(G_SpeechRecognized);
            SRE.LoadGrammar(G);
        }

        private void btnVoiceControl_Click(object sender, EventArgs e)
        {
            if (rdoVoiceControl.Enabled == true)
            {
                //异步调用识别引擎，且允许多次调用
                SRE.RecognizeAsync(RecognizeMode.Multiple);
                btnVoiceControl.Text = "关闭语音控制";
                rdoVoiceControl.Enabled = false;
                rdoHandControl.Enabled = false;
            }
            else
            {
                //停止语音识别
                SRE.RecognizeAsyncCancel();
                rdoVoiceControl.Enabled = true;
                rdoHandControl.Enabled = true;
                btnVoiceControl.Text = "开启语音控制";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            byte[] bytesend = { 0 };
            WritePort(bytesend);
            labelStateShow.Text = "执行停止翻书命令";
        }
    }
}
