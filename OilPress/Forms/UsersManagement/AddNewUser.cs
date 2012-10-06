using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilPress
{
    public partial class AddNewUser : Form
    {
        #region Variables

        private bool newUserAdded = false;

        #endregion

        public AddNewUser()
        {
            InitializeComponent();
        }

        private void buttonNewUserCancel_Click(object sender, EventArgs e)
        {
            newUserAdded = false;
            Close();
        }

        private void buttonNewUserOk_Click(object sender, EventArgs e)
        {
            int check;

            if (textBoxNewUsername.Text == "")
            {
                textBoxNewUserPassword.Clear();
                textBoxNewUsername.Text = "Please type User Name";
                textBoxNewUsername.Select();
            }
            else if (textBoxNewUserPassword.Text == "")
            {
                textBoxNewUsername.Text = "Password cannot be blank";
                textBoxNewUserConferm.Clear();
                textBoxNewUserPassword.Clear();
                textBoxNewUsername.Select();
            }
            else if (textBoxNewUserPassword.Text != textBoxNewUserConferm.Text)
            {
                textBoxNewUsername.Text = "Password do not match";
                textBoxNewUserConferm.Clear();
                textBoxNewUserPassword.Clear();
                textBoxNewUsername.Select();
            }
            else
            {
                FileHandler filehanlder = new FileHandler("users.bin");
                check = filehanlder.InsertUser(textBoxNewUsername.Text, textBoxNewUserPassword.Text);

                if (check == 1)
                {
                    textBoxNewUserPassword.Clear();
                    textBoxNewUserConferm.Clear();
                    MessageBox.Show("-- Internal Error -- \nPlease try diferrent Username or Password", "Internal Error");
                    textBoxNewUsername.Select();
                }
                else if (check == 0)
                {
                    newUserAdded = true;
                    Close();
                }
            } 
        }


        public bool GetClosingStatus
        {
            get { return newUserAdded; }
        }

    }
}
