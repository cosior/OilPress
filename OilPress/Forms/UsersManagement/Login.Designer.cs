namespace OilPress
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLoginOk = new System.Windows.Forms.Button();
            this.textBoxLoginUsername = new System.Windows.Forms.TextBox();
            this.label_Login_Password = new System.Windows.Forms.Label();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.label_Login_Username = new System.Windows.Forms.Label();
            this.buttonLoginCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 123);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // buttonLoginOk
            // 
            this.buttonLoginOk.Location = new System.Drawing.Point(182, 88);
            this.buttonLoginOk.Name = "buttonLoginOk";
            this.buttonLoginOk.Size = new System.Drawing.Size(75, 23);
            this.buttonLoginOk.TabIndex = 3;
            this.buttonLoginOk.Text = "ΟΚ";
            this.buttonLoginOk.UseVisualStyleBackColor = true;
            this.buttonLoginOk.Click += new System.EventHandler(this.buttonLoginOk_Click);
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
            this.buttonLoginCancel.Location = new System.Drawing.Point(77, 88);
            this.buttonLoginCancel.Name = "buttonLoginCancel";
            this.buttonLoginCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonLoginCancel.TabIndex = 2;
            this.buttonLoginCancel.Text = "Άκυρο";
            this.buttonLoginCancel.UseVisualStyleBackColor = true;
            this.buttonLoginCancel.Click += new System.EventHandler(this.buttonLoginCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 49);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Προσοχή";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Απαγορεύετε η χρήση από μη εξουσιοδοτημένα άτομα.";
            // 
            // Login
            // 
            this.AcceptButton = this.buttonLoginOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonLoginCancel;
            this.ClientSize = new System.Drawing.Size(333, 397);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login-Oil Press";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}