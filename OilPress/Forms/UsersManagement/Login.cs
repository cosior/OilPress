using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilPress
{
    public partial class Login : Form
    {
        #region Variables
        private bool userfound = false;
        private String currentUser;
        #endregion

        public Login()
        {
            InitializeComponent();
        }

        public bool LoginOk()
        {
            return (userfound);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            FileHandler usersFile = new FileHandler("users.bin");
            if (!usersFile.FileExist())
            {
                MessageBox.Show("New Users Database Created. Username = \"admin\", Password = \"admin\".","Oil Press Information Window");
                usersFile.CreateFile();
            }
        }

        private void buttonLoginCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLoginOk_Click(object sender, EventArgs e)
        {
            int exist;

            if (textBoxLoginUsername.Text == "")
            {
                textBoxLoginUsername.Text = "Please type User Name";
                textBoxLoginPassword.Clear();
                textBoxLoginUsername.Select();
            }
            else if (textBoxLoginPassword.Text == "")
            {
                textBoxLoginUsername.Text = "Password cannot be blank";
                textBoxLoginUsername.Select(0, textBoxLoginUsername.MaxLength);
            }
            else
            {
                FileHandler filehandler = new FileHandler("users.bin");
                exist = filehandler.FindUser(textBoxLoginUsername.Text.ToString(), textBoxLoginPassword.Text.ToString());

                if (exist >= 0)
                {
                    currentUser = textBoxLoginUsername.Text;
                    userfound = true;
                    Close();
                }
                else if (exist < 0)
                {
                    textBoxLoginUsername.Text = "User Not Exist or Wrong Password.";
                    textBoxLoginPassword.Clear();
                    textBoxLoginUsername.Select();
                }
            } 
        }

        public String GetCurrentUser
        {
            get { return currentUser; }
        }
    }
}
