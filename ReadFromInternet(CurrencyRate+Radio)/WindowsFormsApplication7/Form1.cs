using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Dynamic;
using WMPLib;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        ExchangeRateBase ExchangeRateBase = new ExchangeRateBase();
        Radio Radio = new Radio();


        //-------------------------------------------------------------
        public Form1()
        {  InitializeComponent();  }

        //-------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadExchangeRateData();
            ReloadRadioData();
        }


        //-------------------------------------------------------------
        void ReloadExchangeRateData()
        {
            WebRequest Request = WebRequest.Create("https://www.cbr.ru/currency_base/daily.aspx?date_req=" + DateTime.Now.ToString("dd.MM.yyyy"));
            WebResponse Response = Request.GetResponse();
            Stream Stream = Response.GetResponseStream();
            StreamReader StreamReader = new StreamReader(Stream);
            string Body = StreamReader.ReadToEnd();
            StreamReader.Close();

            Regex ExchangeRateRegex = new Regex(@"<tr><td>(.*?)<\/td>\r\n<td>(.*?)<\/td>\r\n<td>(.*?)<\/td>\r\n<td>(.*?)<\/td>\r\n<td>(.*?)<\/td><\/tr>");

            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            ExchangeRateBase.ClearExchangeRate();
            comboBox1.Items.Add("RUB Российский рубль (643)");
            comboBox2.Items.Add("RUB Российский рубль (643)");

            foreach (Match match in ExchangeRateRegex.Matches(Body))
            {           
                comboBox1.Items.Add(match.Groups[2].Value + " " + match.Groups[4].Value + " (" +match.Groups[1].Value+")");
                comboBox2.Items.Add(match.Groups[2].Value + " " + match.Groups[4].Value + " (" + match.Groups[1].Value + ")");
                ExchangeRateBase.setExchangeRate(match.Groups[2].Value, Double.Parse(match.Groups[5].Value), Int32.Parse(match.Groups[3].Value));
            }
        }

        //-------------------------------------------------------------
        void ReloadRadioData()
        {
            WebRequest Request = WebRequest.Create("http://guzei.com/radio.html");
            WebResponse Response = Request.GetResponse();
            Stream Stream = Response.GetResponseStream();
            StreamReader StreamReader = new StreamReader(Stream);
            string Body = StreamReader.ReadToEnd();
            StreamReader.Close();

            Regex RadioRegex = new Regex("<li><a href=\"(.*?)\">(.*?)</a> - (.*?)\n");

            comboBox3.Items.Clear();
            Radio.ClearRadioBase();

            foreach (Match match in RadioRegex.Matches(Body))
            {
                comboBox3.Items.Add(match.Groups[2].Value + " | " + match.Groups[3].Value);
                Radio.setRadioBase(Regex.Replace(match.Groups[1].Value, "^(.*?)=(.*?)$", "$2"), match.Groups[2].Value + " | " + match.Groups[3].Value);            
            }
        }


        //-------------------------------------------------------------
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CalcExchangeRate();
        }

        //-------------------------------------------------------------
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcExchangeRate();
        }

        //-------------------------------------------------------------
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcExchangeRate();
        }

        //-------------------------------------------------------------
        void CalcExchangeRate()
        {
            double Amount;

            if (double.TryParse(textBox1.Text, out Amount) && comboBox1.Text != "Выберите валюту" && comboBox2.Text != "Выберите валюту")
            {
                if (comboBox1.Text != comboBox2.Text)
                {

                    if (comboBox2.Text.Substring(0, 3) == "RUB")
                    {
                        var ExchangeRate = ExchangeRateBase.getExchangeRate(comboBox1.Text.Substring(0, 3));
                        double AmountConvert = Math.Round(Amount / ExchangeRate.UnitCount * ExchangeRate.ExchangeRateValue, 4);
                        textBox2.Text = AmountConvert.ToString();
                    }
                    else if (comboBox1.Text.Substring(0, 3) == "RUB")
                    {
                        var ExchangeRate = ExchangeRateBase.getExchangeRate(comboBox2.Text.Substring(0, 3));
                        double AmountConvert = Math.Round(Amount / ExchangeRate.ExchangeRateValue * ExchangeRate.UnitCount, 4);
                        textBox2.Text = AmountConvert.ToString();
                    }
                    else
                    {
                        var ExchangeRateIn = ExchangeRateBase.getExchangeRate(comboBox1.Text.Substring(0, 3));
                        double AmountConvertIn = Math.Round(Amount / ExchangeRateIn.UnitCount * ExchangeRateIn.ExchangeRateValue, 4);

                        var ExchangeRateOut = ExchangeRateBase.getExchangeRate(comboBox2.Text.Substring(0, 3));
                        double AmountConvertOut = Math.Round(AmountConvertIn / ExchangeRateOut.ExchangeRateValue * ExchangeRateOut.UnitCount, 4);
                        textBox2.Text = AmountConvertOut.ToString();
                    }

                }
                else
                {
                    textBox2.Text = "1";
                }

            }
        }



        //-------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            string OutVal = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = OutVal;
            CalcExchangeRate();
        }

        //-------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text != "Выберите радио станцию")
            {
                if (button2.Text == "Играть")
                {
                    button2.Text = "Пауза";
                    Radio.Start();
                }
                else
                {
                    button2.Text = "Играть";
                    Radio.Pause();
                }
            }
        }

        //-------------------------------------------------------------
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            Radio.ChangeVolume(trackBar1.Value);
        }

        //-------------------------------------------------------------
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text != "Выберите радио станцию")
            {
                if (button2.Text != "Играть")
                {
                    Radio.Stop();
                }

               bool setStatus = Radio.setRadioStationByName(comboBox3.Text);
               if (!setStatus)
               {
                   MessageBox.Show("Радиостанция <" + comboBox3.Text + "> в данный момент не доступна!");
                   comboBox3.Text = "Выберите радио станцию";
               }
               else if(setStatus && button2.Text != "Играть")
               {
                   Radio.Start();
               }
            }
        }

    }


    //============================================================================
    class ExchangeRateBase
    {
        Dictionary<string, dynamic> ExchangeRate = new Dictionary<string, dynamic>();

        //-------------------------------------------------------------
        public void setExchangeRate(string Code, double ExchangeRateValue, int UnitCount)
        {
            ExchangeRate.Add(Code, new { ExchangeRateValue = ExchangeRateValue, UnitCount = UnitCount});
        }

        //-------------------------------------------------------------
        public dynamic getExchangeRate(string Code)
        {
            return ExchangeRate[Code];
        }

        //-------------------------------------------------------------
        public void ClearExchangeRate()
        {
            ExchangeRate.Clear();
        }
    }

    //============================================================================
    class Radio
    {
          WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
          Dictionary<string, string> RadioBase = new Dictionary<string, string>();

          //-------------------------------------------------------------
          public Radio()
          {
              
              WMP.settings.volume = 1;
          }

          //-------------------------------------------------------------
          public void setRadioBase(string Id, string Data)
          {

              RadioBase.Add(Id, Data);
          }

          //-------------------------------------------------------------
          public bool setRadioStationByName(string Data)
          {

              string IDRadioStation = RadioBase.FirstOrDefault(x => x.Value == Data).Key;
              string StreamUrl = getStreamUrlByID(IDRadioStation);
              if (StreamUrl != "DataLost")
              {
                  WMP.URL = StreamUrl;
                  WMP.controls.stop();
                  return true;
              }
              else
              {
                  return false;
              }
          }

          //-------------------------------------------------------------
          private string getStreamUrlByID(string Id)
          {
              HttpWebRequest Request = (HttpWebRequest)WebRequest.Create("http://guzei.com/radio.php?id=" + Id);
              Request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/54.0.2840.71 Safari/537.36";

              HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();
              StreamReader StreamReader = new StreamReader(Response.GetResponseStream());
              string Body = StreamReader.ReadToEnd();
              Response.Close();


              Regex RegexOnlineRadioId = new Regex("<dd>(<a target=\"guzei_online\" href=\"online_radio\\/listen\\.php\\?online_radio_id=(.*?)\">(.*?)<\\/a>|нет данных)<\\/dd>");
              Match MatchOnlineRadioId = RegexOnlineRadioId.Match(Body);

            if (MatchOnlineRadioId.Groups[1].Value != "нет данных")
              {
                  Request = (HttpWebRequest)WebRequest.Create("http://guzei.com/online_radio/listen.php?online_radio_id=" + MatchOnlineRadioId.Groups[2].Value);
                  Request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/54.0.2840.71 Safari/537.36";

                  Response = (HttpWebResponse)Request.GetResponse();
                  StreamReader = new StreamReader(Response.GetResponseStream());
                  Body = StreamReader.ReadToEnd();
                  Response.Close();

                  Regex RegexStreamUrl = new Regex("title: \"(.*?)\",\r\n(.*?): \"(.*?)\"");
                  Match MatchStreamUrl = RegexStreamUrl.Match(Body);

                return MatchStreamUrl.Groups[3].Value.Trim().Replace("flv", "mp3");
              }          

              return "DataLost";
          }

          //-------------------------------------------------------------
          public void ChangeVolume(int Volume)
          {
              WMP.settings.volume = Volume;
          }

          //-------------------------------------------------------------
          public void Pause()
          {
              WMP.controls.pause();
          }

          //-------------------------------------------------------------
          public void Stop()
          {
              WMP.controls.stop();
          }

          //-------------------------------------------------------------
          public void Start()
          {
              WMP.controls.play();
          }

          //-------------------------------------------------------------
          public void ClearRadioBase()
          {
              RadioBase.Clear();
          }
    }
}
