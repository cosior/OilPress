using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilPress
{
    public partial class EditUser : Form
    {
        #region Variables

        public bool userEditOk = false;
        public String userName;
        public int position;
        FileHandler filehandler;
        #endregion

        public EditUser()
        {
            InitializeComponent();
        }

        private void buttonEditUserCancel_Click(object sender, EventArgs e)
        {
            userEditOk = false;
            Close();
        }

        private void buttonEditUserOk_Click(object sender, EventArgs e)
        {
            if (textBoxEditUsername.Text == "")
            {
                textBoxEditUsername.Text = "Please type User Name";
                textBoxEditUserPassword.Clear();
                textBoxEditUsername.Select();
            }
            else if (textBoxEditUserPassword.Text == "")
            {
                textBoxEditUsername.Text = "Password cannot be blank";
                textBoxEditUsername.Select();
            }
            else
            {
                filehandler = new FileHandler("users.bin");

                position = filehandler.FindUser(textBoxEditUsername.Text, textBoxEditUserPassword.Text);

                if (position >= 0)
                {
                    userName = textBoxEditUsername.Text;
                    userEditOk = true;
                    Close();
                }
                else
                {
                    userName = "null";
                    userEditOk = false;
                    Close();
                } 
            } 
        }
    }
}
