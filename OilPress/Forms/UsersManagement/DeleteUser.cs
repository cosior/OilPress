using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilPress
{
    public partial class DeleteUser : Form
    {
        #region Variables

        public bool deleteOk = false;
        public String userName;
        FileHandler filehandler;

        #endregion

        public DeleteUser()
        {
            InitializeComponent();
        }

        private void buttonDeleteUserCancel_Click(object sender, EventArgs e)
        {
            deleteOk = false;
            Close();
        }

        private void buttonDleteUserOk_Click(object sender, EventArgs e)
        {
            if (textBoxDeleteUsername.Text == "")
            {
                textBoxDeleteUsername.Text = "Please type User Name";
                textBoxDeleteUserPassword.Clear();
                textBoxDeleteUsername.Select();
            }
            else if (textBoxDeleteUserPassword.Text == "")
            {
                textBoxDeleteUsername.Text = "Password cannot be blank";
                textBoxDeleteUsername.Select();
            }
            else
            {
                int userExist;

                filehandler = new FileHandler("users.bin");

                userExist = filehandler.FindUser(textBoxDeleteUsername.Text, textBoxDeleteUserPassword.Text);

                if (userExist >= 0)
                {
                    deleteOk = filehandler.DeleteUser(userExist);
                    userName = textBoxDeleteUsername.Text;
                    Close();
                }
                else
                {
                    userName = "null";
                    deleteOk = false;
                    Close();
                }
            }
        }

        private void textBoxDeleteUserPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
