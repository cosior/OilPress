using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilPress
{
    public partial class EditUserData : Form
    {
        public String newusername, newpassword, currentUser;
        public int currentPosition;
        public bool dataOk = false;

        FileHandler filehandler;

        public EditUserData(String username, int position)
        {
            currentUser = username;
            currentPosition = position;

            InitializeComponent();
        }

        private void EditNewUser_Load(object sender, EventArgs e)
        {
            textBoxCurrentUser.Text = currentUser;
        }

        private void buttonEditNewUserCancel_Click(object sender, EventArgs e)
        {
            dataOk = false;
            Close();
        }

        private void buttonEditNewUserOk_Click(object sender, EventArgs e)
        {
            if (textBoxEditNewUsername.Text == "")
            {
                textBoxEditNewUsername.Text = "Please type User Name";
                textBoxEditNewUserPassword.Clear();
                textBoxConfermNewPassword.Clear();
                textBoxEditNewUsername.Select();
            }
            else if (textBoxEditNewUserPassword.Text == "")
            {
                textBoxEditNewUsername.Text = "Password cannot be blank";
                textBoxConfermNewPassword.Clear();
                textBoxEditNewUserPassword.Clear();
                textBoxEditNewUsername.Select();
            }
            else if (textBoxEditNewUserPassword.Text != textBoxConfermNewPassword.Text)
            {
                textBoxEditNewUsername.Text = "Password do not match";
                textBoxConfermNewPassword.Clear();
                textBoxEditNewUserPassword.Clear();
                textBoxEditNewUsername.Select();
            }
            else
            {
                int userExist;

                filehandler = new FileHandler("users.bin");

                userExist = filehandler.FindUser(textBoxEditNewUsername.Text, textBoxEditNewUserPassword.Text);

                if (userExist >=0)
                {
                    MessageBox.Show("-- Internal Error -- \nPlease try diferrent Username or Password", "Internal Error");
                    textBoxEditNewUsername.Select();
                    textBoxConfermNewPassword.Clear();
                    textBoxEditNewUserPassword.Clear();    
                }
                else
                {
                    filehandler.EditUser(textBoxEditNewUsername.Text, textBoxEditNewUserPassword.Text, currentPosition);
                    dataOk = true;
                    Close();
                } 
            }
        }
    }
}
