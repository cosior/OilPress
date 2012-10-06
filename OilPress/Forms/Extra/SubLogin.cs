using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OilPress.Forms.UIForms;

namespace OilPress
{
    public partial class SubLogin : Form
    {
        #region Variables
        bool userfound = false;
        public String currentUser;
        #endregion

        public SubLogin()
        {
            InitializeComponent();
        }

        public bool LoginOk()
        {
            return (userfound);
        }

        private void buttonLoginCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void SubLogin_Load(object sender, EventArgs e)
        {
            FileHandler usersFile = new FileHandler("users.bin");
            if (!usersFile.FileExist())
            {
                MessageBox.Show("New Users Database Created. Username = \"admin\", Password = \"admin\".", "Oil Press Information Window");
                usersFile.CreateFile();
            }
        }

        private void buttonLoginCancel_Click_1(object sender, EventArgs e)
        {
            AccessDenied acd = new AccessDenied();
            acd.MdiParent = this.ParentForm;
            acd.Show();
            this.Close();
        }

        private void buttonLoginOk_Click_1(object sender, EventArgs e)
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
                    ExtraAreaIntro exint = new ExtraAreaIntro();
                    exint.MdiParent = this.ParentForm;
                    exint.Show();
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
    }
}
