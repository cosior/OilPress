﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OilPress
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            OilPressControl controller = new OilPressControl();
            controller.startLogin();
        }
    }
}
