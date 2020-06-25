using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Network_Proj_5
{
    public partial class WeatherAppForm : Form
    {
        public bool WBClick;
        net.webservicex.www.WeatherData WD;
        net.webservicex.www.WeatherForecast WF;
        net.webservicex.www.WeatherForecasts WFS;
        public WeatherAppForm()
        {
            InitializeComponent();
        }

        private void WeatherAppForm_Load(object sender, EventArgs e)
        {
            WBClick = false;
        }

        private void GWBN_Button_Click(object sender, EventArgs e)
        {
            if (!WBClick)
            {
                WBClick = true;
                GWBN_Button.Text = "Get Another Forecast";
                GWBZ_Button.Enabled = false;
                NameBox.Enabled = false;
                ZCBox.Enabled = false;
                WRBox.Enabled = true;
                WD = new Network_Proj_5.net.webservicex.www.WeatherData();
                WF = new Network_Proj_5.net.webservicex.www.WeatherForecast();
                WFS = new Network_Proj_5.net.webservicex.www.WeatherForecasts();

                WFS = WF.GetWeatherByPlaceName(NameBox.Text);
                for (int i = 0; i < 7; i++)
                {
                    WD = (Network_Proj_5.net.webservicex.www.WeatherData)WFS.Details.GetValue(i);
                    if (WD.Day != null)
                    {
                        String[] str_array = WD.Day.Split(' ', ',');
                        string daystring = str_array[0];
                        if (daystring == DateTime.Now.DayOfWeek.ToString())
                        {
                            string result = WD.Day.ToString() + "\n";
                            string location = WFS.PlaceName + ", " + WFS.StateCode + "\n";
                            string result2 = "Maximum Temperature = ";
                            result2 += (WD.MaxTemperatureF.ToString() + "F" + "\n");
                            string result3 = "Minimum Temperature = ";
                            result3 += (WD.MinTemperatureF.ToString() + "F" + "\n\n");
                            WRBox.AppendText(result);
                            WRBox.AppendText(location);
                            WRBox.AppendText(result2);
                            WRBox.AppendText(result3);
                        }
                    }
                }
            }
            else
            {
                WBClick = false;
                GWBN_Button.Text = "Get Weather By Name";
                GWBZ_Button.Enabled = true;
                NameBox.Enabled = true;
                ZCBox.Enabled = true;
                WRBox.Enabled = false;
                WRBox.AppendText("\n");
            }
        }

        private void GWBZ_Button_Click(object sender, EventArgs e)
        {
            if (!WBClick)
            {
                WBClick = true;
                GWBZ_Button.Text = "Get Another Forecast";
                GWBN_Button.Enabled = false;
                NameBox.Enabled = false;

                ZCBox.Enabled = false;
                WRBox.Enabled = true;

                WD = new Network_Proj_5.net.webservicex.www.WeatherData();
                WF = new Network_Proj_5.net.webservicex.www.WeatherForecast();
                WFS = new Network_Proj_5.net.webservicex.www.WeatherForecasts();

                WFS = WF.GetWeatherByZipCode(ZCBox.Text);
                for (int i = 0; i < 7; i++)
                {
                    WD = (Network_Proj_5.net.webservicex.www.WeatherData)WFS.Details.GetValue(i);
                    if (WD.Day != null)
                    {
                        String[] str_array = WD.Day.Split(' ', ',');
                        string daystring = str_array[0];
                        if (daystring == DateTime.Now.DayOfWeek.ToString())
                        {
                            string result = WD.Day.ToString() + "\n";
                            string location = WFS.PlaceName + ", " + WFS.StateCode + "\n";
                            string result2 = "Maximum Temperature = ";
                            result2 += (WD.MaxTemperatureF.ToString() + "F" + "\n");
                            string result3 = "Minimum Temperature = ";
                            result3 += (WD.MinTemperatureF.ToString() + "F" + "\n\n");
                            WRBox.AppendText(result);
                            WRBox.AppendText(location);
                            WRBox.AppendText(result2);
                            WRBox.AppendText(result3);
                        }
                    }
                }
            }
            else
            {
                WBClick = false;
                GWBZ_Button.Text = "Get Weather By Zip Code";
                GWBN_Button.Enabled = true;
                NameBox.Enabled = true;
                ZCBox.Enabled = true;
                WRBox.Enabled = false;
                WRBox.AppendText("\n");
            }
        }
    }
}
