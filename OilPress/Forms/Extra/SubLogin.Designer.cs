namespace OilPress
{
    partial class SubLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLoginOk = new System.Windows.Forms.Button();
            this.textBoxLoginUsername = new System.Windows.Forms.TextBox();
            this.label_Login_Password = new System.Windows.Forms.Label();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.label_Login_Username = new System.Windows.Forms.Label();
            this.buttonLoginCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLoginOk);
            this.groupBox1.Controls.Add(this.textBoxLoginUsername);
            this.groupBox1.Controls.Add(this.label_Login_Password);
            this.groupBox1.Controls.Add(this.textBoxLoginPassword);
            this.groupBox1.Controls.Add(this.label_Login_Username);
            this.groupBox1.Controls.Add(this.buttonLoginCancel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 123);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // buttonLoginOk
            // 
            this.buttonLoginOk.Location = new System.Drawing.Point(170, 88);
            this.buttonLoginOk.Name = "buttonLoginOk";
            this.buttonLoginOk.Size = new System.Drawing.Size(75, 23);
            this.buttonLoginOk.TabIndex = 3;
            this.buttonLoginOk.Text = "ΟΚ";
            this.buttonLoginOk.UseVisualStyleBackColor = true;
            this.buttonLoginOk.Click += new System.EventHandler(this.buttonLoginOk_Click_1);
            // 
            // textBoxLoginUsername
            // 
            this.textBoxLoginUsername.Location = new System.Drawing.Point(93, 29);
            this.textBoxLoginUsername.Name = "textBoxLoginUsername";
            this.textBoxLoginUsername.Size = new System.Drawing.Size(184, 22);
            this.textBoxLoginUsername.TabIndex = 0;
            // 
            // label_Login_Password
            // 
            this.label_Login_Password.AutoSize = true;
            this.label_Login_Password.Location = new System.Drawing.Point(16, 58);
            this.label_Login_Password.Name = "label_Login_Password";
            this.label_Login_Password.Size = new System.Drawing.Size(68, 16);
            this.label_Login_Password.TabIndex = 3;
            this.label_Login_Password.Text = "Password";
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.Location = new System.Drawing.Point(93, 55);
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.PasswordChar = '*';
            this.textBoxLoginPassword.Size = new System.Drawing.Size(184, 22);
            this.textBoxLoginPassword.TabIndex = 1;
            this.textBoxLoginPassword.UseSystemPasswordChar = true;
            // 
            // label_Login_Username
            // 
            this.label_Login_Username.AutoSize = true;
            this.label_Login_Username.Location = new System.Drawing.Point(16, 32);
            this.label_Login_Username.Name = "label_Login_Username";
            this.label_Login_Username.Size = new System.Drawing.Size(71, 16);
            this.label_Login_Username.TabIndex = 2;
            this.label_Login_Username.Text = "Username";
            // 
            // buttonLoginCancel
            // 
            this.buttonLoginCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonLoginCancel.Location = new System.Drawing.Point(71, 88);
            this.buttonLoginCancel.Name = "buttonLoginCancel";
            this.buttonLoginCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonLoginCancel.TabIndex = 2;
            this.buttonLoginCancel.Text = "Άκυρο";
            this.buttonLoginCancel.UseVisualStyleBackColor = true;
            this.buttonLoginCancel.Click += new System.EventHandler(this.buttonLoginCancel_Click_1);
            // 
            // SubLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 148);
            this.Controls.Add(this.groupBox1);
            this.Name = "SubLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Extra Login";
            this.Load += new System.EventHandler(this.SubLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLoginOk;
        private System.Windows.Forms.TextBox textBoxLoginUsername;
        private System.Windows.Forms.Label label_Login_Password;
        private System.Windows.Forms.TextBox textBoxLoginPassword;
        private System.Windows.Forms.Label label_Login_Username;
        private System.Windows.Forms.Button buttonLoginCancel;
    }
}