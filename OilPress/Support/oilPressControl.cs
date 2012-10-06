using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OilPress
{
    /// <summary>
    /// Class to Manage Libary Forms
    /// </summary>
    class OilPressControl
    {
        String currentUser;
        Login loginForm = new Login();
        Start startForm = new Start();

        public void startLogin()
        {
            Application.EnableVisualStyles();
            Application.Run(loginForm);

            if (loginForm.LoginOk())
            {
                currentUser = loginForm.GetCurrentUser;
                Application.EnableVisualStyles();
                startForm.SetUser(currentUser);
                Application.Run(startForm);
            }
        }
    }
}
