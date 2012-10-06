namespace OilPress
{
    partial class EditUser
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
            this.buttonEditUserOk = new System.Windows.Forms.Button();
            this.buttonEditUserCancel = new System.Windows.Forms.Button();
            this.textBoxEditUserPassword = new System.Windows.Forms.TextBox();
            this.textBoxEditUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxEditUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEditUser
            // 
            this.groupBoxEditUser.Controls.Add(this.buttonEditUserOk);
            this.groupBoxEditUser.Controls.Add(this.buttonEditUserCancel);
            this.groupBoxEditUser.Controls.Add(this.textBoxEditUserPassword);
            this.groupBoxEditUser.Controls.Add(this.textBoxEditUsername);
            this.groupBoxEditUser.Controls.Add(this.label2);
            this.groupBoxEditUser.Controls.Add(this.label1);
            this.groupBoxEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEditUser.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEditUser.Name = "groupBoxEditUser";
            this.groupBoxEditUser.Size = new System.Drawing.Size(335, 128);
            this.groupBoxEditUser.TabIndex = 10;
            this.groupBoxEditUser.TabStop = false;
            this.groupBoxEditUser.Text = "Τροποποίηση Χρήστη";
            // 
            // buttonEditUserOk
            // 
            this.buttonEditUserOk.Location = new System.Drawing.Point(203, 88);
            this.buttonEditUserOk.Name = "buttonEditUserOk";
            this.buttonEditUserOk.Size = new System.Drawing.Size(75, 23);
            this.buttonEditUserOk.TabIndex = 5;
            this.buttonEditUserOk.Text = "ΟΚ";
            this.buttonEditUserOk.UseVisualStyleBackColor = true;
            this.buttonEditUserOk.Click += new System.EventHandler(this.buttonEditUserOk_Click);
            // 
            // buttonEditUserCancel
            // 
            this.buttonEditUserCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonEditUserCancel.Location = new System.Drawing.Point(97, 88);
            this.buttonEditUserCancel.Name = "buttonEditUserCancel";
            this.buttonEditUserCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonEditUserCancel.TabIndex = 4;
            this.buttonEditUserCancel.Text = "Άκυρο";
            this.buttonEditUserCancel.UseVisualStyleBackColor = true;
            this.buttonEditUserCancel.Click += new System.EventHandler(this.buttonEditUserCancel_Click);
            // 
            // textBoxEditUserPassword
            // 
            this.textBoxEditUserPassword.Location = new System.Drawing.Point(97, 60);
            this.textBoxEditUserPassword.Name = "textBoxEditUserPassword";
            this.textBoxEditUserPassword.Size = new System.Drawing.Size(212, 22);
            this.textBoxEditUserPassword.TabIndex = 3;
            this.textBoxEditUserPassword.UseSystemPasswordChar = true;
            // 
            // textBoxEditUsername
            // 
            this.textBoxEditUsername.Location = new System.Drawing.Point(97, 30);
            this.textBoxEditUsername.Name = "textBoxEditUsername";
            this.textBoxEditUsername.Size = new System.Drawing.Size(212, 22);
            this.textBoxEditUsername.TabIndex = 2;
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
            // EditUser
            // 
            this.AcceptButton = this.buttonEditUserOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonEditUserCancel;
            this.ClientSize = new System.Drawing.Size(364, 157);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxEditUser);
            this.Name = "EditUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Τροποποίηση Χρήστη";
            this.groupBoxEditUser.ResumeLayout(false);
            this.groupBoxEditUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEditUser;
        private System.Windows.Forms.Button buttonEditUserOk;
        private System.Windows.Forms.Button buttonEditUserCancel;
        private System.Windows.Forms.TextBox textBoxEditUserPassword;
        private System.Windows.Forms.TextBox textBoxEditUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}