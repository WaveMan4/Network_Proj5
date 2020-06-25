using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Network_Proj_5
{
    static class WeatherApp
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new WeatherAppForm());
        }
        
    }
    
}