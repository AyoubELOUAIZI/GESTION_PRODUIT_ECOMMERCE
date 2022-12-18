namespace GESTION_PRODUIT_ECOMMERCE.presentationLayer
{
    partial class FRM_ORDERS_LIST
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
            this.boxSearchOrder = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVORDERS = new System.Windows.Forms.DataGridView();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVORDERS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(480, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Oreder in list";
            // 
            // boxSearchOrder
            // 
            this.boxSearchOrder.Location = new System.Drawing.Point(729, 12);
            this.boxSearchOrder.Name = "boxSearchOrder";
            this.boxSearchOrder.Size = new System.Drawing.Size(243, 29);
            this.boxSearchOrder.TabIndex = 1;
            this.boxSearchOrder.TextChanged += new System.EventHandler(this.boxSearchOrder_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVORDERS);
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 564);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orders info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(81, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "ALL ORDERS";
            // 
            // DGVORDERS
            // 
            this.DGVORDERS.AllowUserToAddRows = false;
            this.DGVORDERS.AllowUserToDeleteRows = false;
            this.DGVORDERS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVORDERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVORDERS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVORDERS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVORDERS.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVORDERS.Location = new System.Drawing.Point(3, 25);
            this.DGVORDERS.MultiSelect = false;
            this.DGVORDERS.Name = "DGVORDERS";
            this.DGVORDERS.ReadOnly = true;
            this.DGVORDERS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVORDERS.Size = new System.Drawing.Size(954, 536);
            this.DGVORDERS.TabIndex = 0;
            this.DGVORDERS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVORDERS_CellClick);
            this.DGVORDERS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDetails.Location = new System.Drawing.Point(828, 56);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(144, 34);
            this.btnDetails.TabIndex = 4;
            this.btnDetails.Text = "Detaills";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(694, 56);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(136, 34);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FRM_ORDERS_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 650);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.boxSearchOrder);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FRM_ORDERS_LIST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_ORDERS_LIST";
            this.Load += new System.EventHandler(this.FRM_ORDERS_LIST_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVORDERS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxSearchOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGVORDERS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnClose;
    }
}