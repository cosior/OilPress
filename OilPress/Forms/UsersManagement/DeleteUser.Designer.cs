namespace OilPress
{
    partial class DeleteUser
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
            this.groupBoxEditUser = new System.Windows.Forms.GroupBox();
            this.buttonDleteUserOk = new System.Windows.Forms.Button();
            this.buttonDeleteUserCancel = new System.Windows.Forms.Button();
            this.textBoxDeleteUserPassword = new System.Windows.Forms.TextBox();
            this.textBoxDeleteUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxEditUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEditUser
            // 
            this.groupBoxEditUser.Controls.Add(this.buttonDleteUserOk);
            this.groupBoxEditUser.Controls.Add(this.buttonDeleteUserCancel);
            this.groupBoxEditUser.Controls.Add(this.textBoxDeleteUserPassword);
            this.groupBoxEditUser.Controls.Add(this.textBoxDeleteUsername);
            this.groupBoxEditUser.Controls.Add(this.label2);
            this.groupBoxEditUser.Controls.Add(this.label1);
            this.groupBoxEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEditUser.Location = new System.Drawing.Point(15, 14);
            this.groupBoxEditUser.Name = "groupBoxEditUser";
            this.groupBoxEditUser.Size = new System.Drawing.Size(335, 128);
            this.groupBoxEditUser.TabIndex = 11;
            this.groupBoxEditUser.TabStop = false;
            this.groupBoxEditUser.Text = "Διαγραφή Χρήστη";
            // 
            // buttonDleteUserOk
            // 
            this.buttonDleteUserOk.Location = new System.Drawing.Point(203, 88);
            this.buttonDleteUserOk.Name = "buttonDleteUserOk";
            this.buttonDleteUserOk.Size = new System.Drawing.Size(75, 23);
            this.buttonDleteUserOk.TabIndex = 5;
            this.buttonDleteUserOk.Text = "ΟΚ";
            this.buttonDleteUserOk.UseVisualStyleBackColor = true;
            this.buttonDleteUserOk.Click += new System.EventHandler(this.buttonDleteUserOk_Click);
            // 
            // buttonDeleteUserCancel
            // 
            this.buttonDeleteUserCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonDeleteUserCancel.Location = new System.Drawing.Point(97, 88);
            this.buttonDeleteUserCancel.Name = "buttonDeleteUserCancel";
            this.buttonDeleteUserCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteUserCancel.TabIndex = 4;
            this.buttonDeleteUserCancel.Text = "Άκυρο";
            this.buttonDeleteUserCancel.UseVisualStyleBackColor = true;
            this.buttonDeleteUserCancel.Click += new System.EventHandler(this.buttonDeleteUserCancel_Click);
            // 
            // textBoxDeleteUserPassword
            // 
            this.textBoxDeleteUserPassword.Location = new System.Drawing.Point(97, 60);
            this.textBoxDeleteUserPassword.Name = "textBoxDeleteUserPassword";
            this.textBoxDeleteUserPassword.Size = new System.Drawing.Size(212, 22);
            this.textBoxDeleteUserPassword.TabIndex = 3;
            this.textBoxDeleteUserPassword.UseSystemPasswordChar = true;
            this.textBoxDeleteUserPassword.TextChanged += new System.EventHandler(this.textBoxDeleteUserPassword_TextChanged);
            // 
            // textBoxDeleteUsername
            // 
            this.textBoxDeleteUsername.Location = new System.Drawing.Point(97, 30);
            this.textBoxDeleteUsername.Name = "textBoxDeleteUsername";
            this.textBoxDeleteUsername.Size = new System.Drawing.Size(212, 22);
            this.textBoxDeleteUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // DeleteUser
            // 
            this.AcceptButton = this.buttonDleteUserOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonDeleteUserCancel;
            this.ClientSize = new System.Drawing.Size(364, 157);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxEditUser);
            this.Name = "DeleteUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Διαγραφή Χρήστη";
            this.groupBoxEditUser.ResumeLayout(false);
            this.groupBoxEditUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEditUser;
        private System.Windows.Forms.Button buttonDleteUserOk;
        private System.Windows.Forms.Button buttonDeleteUserCancel;
        private System.Windows.Forms.TextBox textBoxDeleteUserPassword;
        private System.Windows.Forms.TextBox textBoxDeleteUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}