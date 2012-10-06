namespace OilPress
{
    partial class AddNewUser
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
            this.groupBoxNewUser = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxNewUserConferm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonNewUserOk = new System.Windows.Forms.Button();
            this.buttonNewUserCancel = new System.Windows.Forms.Button();
            this.textBoxNewUserPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxNewUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNewUser
            // 
            this.groupBoxNewUser.Controls.Add(this.comboBox1);
            this.groupBoxNewUser.Controls.Add(this.checkBox1);
            this.groupBoxNewUser.Controls.Add(this.textBoxNewUserConferm);
            this.groupBoxNewUser.Controls.Add(this.label5);
            this.groupBoxNewUser.Controls.Add(this.label4);
            this.groupBoxNewUser.Controls.Add(this.label3);
            this.groupBoxNewUser.Controls.Add(this.buttonNewUserOk);
            this.groupBoxNewUser.Controls.Add(this.buttonNewUserCancel);
            this.groupBoxNewUser.Controls.Add(this.textBoxNewUserPassword);
            this.groupBoxNewUser.Controls.Add(this.textBoxNewUsername);
            this.groupBoxNewUser.Controls.Add(this.label2);
            this.groupBoxNewUser.Controls.Add(this.label1);
            this.groupBoxNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNewUser.Location = new System.Drawing.Point(12, 12);
            this.groupBoxNewUser.Name = "groupBoxNewUser";
            this.groupBoxNewUser.Size = new System.Drawing.Size(335, 216);
            this.groupBoxNewUser.TabIndex = 9;
            this.groupBoxNewUser.TabStop = false;
            this.groupBoxNewUser.Text = "Προσθήκη Νέου Χρήστη";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Standard User",
            "Stock Control User",
            "Privilaged User",
            "Advanced User"});
            this.comboBox1.Location = new System.Drawing.Point(113, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(113, 115);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxNewUserConferm
            // 
            this.textBoxNewUserConferm.Location = new System.Drawing.Point(113, 82);
            this.textBoxNewUserConferm.Name = "textBoxNewUserConferm";
            this.textBoxNewUserConferm.Size = new System.Drawing.Size(201, 22);
            this.textBoxNewUserConferm.TabIndex = 3;
            this.textBoxNewUserConferm.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Είδος Χρήστη";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Extra Bit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Επιβαιβέωση";
            // 
            // buttonNewUserOk
            // 
            this.buttonNewUserOk.Location = new System.Drawing.Point(172, 186);
            this.buttonNewUserOk.Name = "buttonNewUserOk";
            this.buttonNewUserOk.Size = new System.Drawing.Size(75, 23);
            this.buttonNewUserOk.TabIndex = 5;
            this.buttonNewUserOk.Text = "OΚ";
            this.buttonNewUserOk.UseVisualStyleBackColor = true;
            this.buttonNewUserOk.Click += new System.EventHandler(this.buttonNewUserOk_Click);
            // 
            // buttonNewUserCancel
            // 
            this.buttonNewUserCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonNewUserCancel.Location = new System.Drawing.Point(80, 186);
            this.buttonNewUserCancel.Name = "buttonNewUserCancel";
            this.buttonNewUserCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonNewUserCancel.TabIndex = 4;
            this.buttonNewUserCancel.Text = "Άκυρο";
            this.buttonNewUserCancel.UseVisualStyleBackColor = true;
            this.buttonNewUserCancel.Click += new System.EventHandler(this.buttonNewUserCancel_Click);
            // 
            // textBoxNewUserPassword
            // 
            this.textBoxNewUserPassword.Location = new System.Drawing.Point(113, 56);
            this.textBoxNewUserPassword.Name = "textBoxNewUserPassword";
            this.textBoxNewUserPassword.Size = new System.Drawing.Size(201, 22);
            this.textBoxNewUserPassword.TabIndex = 2;
            this.textBoxNewUserPassword.UseSystemPasswordChar = true;
            // 
            // textBoxNewUsername
            // 
            this.textBoxNewUsername.Location = new System.Drawing.Point(113, 30);
            this.textBoxNewUsername.Name = "textBoxNewUsername";
            this.textBoxNewUsername.Size = new System.Drawing.Size(201, 22);
            this.textBoxNewUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // AddNewUser
            // 
            this.AcceptButton = this.buttonNewUserOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonNewUserCancel;
            this.ClientSize = new System.Drawing.Size(359, 240);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxNewUser);
            this.Name = "AddNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Προσθήκη Νέου Χρήστη";
            this.groupBoxNewUser.ResumeLayout(false);
            this.groupBoxNewUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNewUser;
        private System.Windows.Forms.Button buttonNewUserOk;
        private System.Windows.Forms.Button buttonNewUserCancel;
        private System.Windows.Forms.TextBox textBoxNewUserPassword;
        private System.Windows.Forms.TextBox textBoxNewUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNewUserConferm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}