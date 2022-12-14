namespace GESTION_PRODUIT_ECOMMERCE.presentationLayer
{
    partial class FRM_All_CUSTOMERS
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
            this.dtgvCustomers = new System.Windows.Forms.DataGridView();
            this.CustomerImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerImg)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvCustomers
            // 
            this.dtgvCustomers.AllowUserToAddRows = false;
            this.dtgvCustomers.AllowUserToDeleteRows = false;
            this.dtgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCustomers.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCustomers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvCustomers.Location = new System.Drawing.Point(5, 167);
            this.dtgvCustomers.Name = "dtgvCustomers";
            this.dtgvCustomers.ReadOnly = true;
            this.dtgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCustomers.Size = new System.Drawing.Size(608, 489);
            this.dtgvCustomers.TabIndex = 0;
            this.dtgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCustomers_CellClick);
            this.dtgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCustomers_CellContentClick);
            this.dtgvCustomers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCustomers_CellContentDoubleClick);
            this.dtgvCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCustomers_CellDoubleClick);
            this.dtgvCustomers.SelectionChanged += new System.EventHandler(this.dtgvCustomers_SelectionChanged);
            // 
            // CustomerImg
            // 
            this.CustomerImg.Image = global::GESTION_PRODUIT_ECOMMERCE.Properties.Resources.Avatar;
            this.CustomerImg.Location = new System.Drawing.Point(464, 12);
            this.CustomerImg.Name = "CustomerImg";
            this.CustomerImg.Size = new System.Drawing.Size(149, 149);
            this.CustomerImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CustomerImg.TabIndex = 1;
            this.CustomerImg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 30.25F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chose Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 30.25F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = " from the liste";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FRM_All_CUSTOMERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(619, 668);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerImg);
            this.Controls.Add(this.dtgvCustomers);
            this.Name = "FRM_All_CUSTOMERS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List All Customers";
            this.Load += new System.EventHandler(this.FRM_All_CUSTOMERS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtgvCustomers;
        private System.Windows.Forms.PictureBox CustomerImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}