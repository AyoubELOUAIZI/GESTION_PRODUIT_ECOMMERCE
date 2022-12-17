namespace GESTION_PRODUIT_ECOMMERCE.presentationLayer
{
    partial class FRM_ADD_USER
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
            this.label1 = new System.Windows.Forms.Label();
            this.boxUserName = new System.Windows.Forms.TextBox();
            this.boxSellername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboTypeUser = new System.Windows.Forms.ComboBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.boxConfirmPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.userImage = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // boxUserName
            // 
            this.boxUserName.Location = new System.Drawing.Point(202, 70);
            this.boxUserName.Name = "boxUserName";
            this.boxUserName.Size = new System.Drawing.Size(196, 29);
            this.boxUserName.TabIndex = 0;
            // 
            // boxSellername
            // 
            this.boxSellername.Location = new System.Drawing.Point(202, 117);
            this.boxSellername.Name = "boxSellername";
            this.boxSellername.Size = new System.Drawing.Size(196, 29);
            this.boxSellername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seller Name";
            // 
            // boxPassword
            // 
            this.boxPassword.Location = new System.Drawing.Point(202, 166);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.PasswordChar = '*';
            this.boxPassword.Size = new System.Drawing.Size(196, 29);
            this.boxPassword.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pass Word";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Type User";
            // 
            // comboTypeUser
            // 
            this.comboTypeUser.FormattingEnabled = true;
            this.comboTypeUser.Items.AddRange(new object[] {
            "administrator",
            "normal user"});
            this.comboTypeUser.Location = new System.Drawing.Point(202, 257);
            this.comboTypeUser.Name = "comboTypeUser";
            this.comboTypeUser.Size = new System.Drawing.Size(196, 32);
            this.comboTypeUser.TabIndex = 4;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.Location = new System.Drawing.Point(391, 315);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(160, 38);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(221, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // boxConfirmPass
            // 
            this.boxConfirmPass.Location = new System.Drawing.Point(202, 208);
            this.boxConfirmPass.Name = "boxConfirmPass";
            this.boxConfirmPass.PasswordChar = '*';
            this.boxConfirmPass.Size = new System.Drawing.Size(196, 29);
            this.boxConfirmPass.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Conferm PassWord";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(101, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(386, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "FILL FORM TO ADD NEW USER";
            // 
            // userImage
            // 
            this.userImage.BackColor = System.Drawing.Color.Teal;
            this.userImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userImage.Location = new System.Drawing.Point(418, 70);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(150, 164);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImage.TabIndex = 8;
            this.userImage.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(55, 315);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 38);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FRM_ADD_USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(591, 382);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boxConfirmPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.userImage);
            this.Controls.Add(this.comboTypeUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxSellername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxUserName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(607, 421);
            this.MinimumSize = new System.Drawing.Size(607, 421);
            this.Name = "FRM_ADD_USER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRM ADD USER";
            this.Load += new System.EventHandler(this.FRM_ADD_USER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.TextBox boxUserName;
        public System.Windows.Forms.TextBox boxSellername;
        public System.Windows.Forms.TextBox boxPassword;
        public System.Windows.Forms.ComboBox comboTypeUser;
        public System.Windows.Forms.PictureBox userImage;
        public System.Windows.Forms.TextBox boxConfirmPass;
        public System.Windows.Forms.Button btnAddUser;
    }
}