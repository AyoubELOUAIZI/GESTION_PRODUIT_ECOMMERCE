namespace GESTION_PRODUIT_ECOMMERCE.presentationLayer
{
    partial class FRM_CATEGORIES
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
            System.Windows.Forms.Button btnNext;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CATEGORIES));
            this.textCategorie = new System.Windows.Forms.GroupBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.priviostbtn = new System.Windows.Forms.Button();
            this.nextbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGListCategories = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            btnNext = new System.Windows.Forms.Button();
            this.textCategorie.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGListCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnNext.Location = new System.Drawing.Point(283, 208);
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(88, 55);
            btnNext.TabIndex = 15;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // textCategorie
            // 
            this.textCategorie.BackColor = System.Drawing.Color.Blue;
            this.textCategorie.Controls.Add(this.textId);
            this.textCategorie.Controls.Add(this.priviostbtn);
            this.textCategorie.Controls.Add(this.nextbtn);
            this.textCategorie.Controls.Add(this.label1);
            this.textCategorie.Controls.Add(this.position);
            this.textCategorie.Controls.Add(btnNext);
            this.textCategorie.Controls.Add(this.button1);
            this.textCategorie.Controls.Add(this.textBoxDescription);
            this.textCategorie.Controls.Add(this.textBoxName);
            this.textCategorie.Controls.Add(this.label3);
            this.textCategorie.Controls.Add(this.label2);
            this.textCategorie.Location = new System.Drawing.Point(12, 12);
            this.textCategorie.Name = "textCategorie";
            this.textCategorie.Size = new System.Drawing.Size(573, 276);
            this.textCategorie.TabIndex = 4;
            this.textCategorie.TabStop = false;
            this.textCategorie.Text = "categories info";
            // 
            // textId
            // 
            this.textId.BackColor = System.Drawing.Color.Blue;
            this.textId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textId.ForeColor = System.Drawing.Color.Blue;
            this.textId.Location = new System.Drawing.Point(103, 136);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(10, 22);
            this.textId.TabIndex = 19;
            // 
            // priviostbtn
            // 
            this.priviostbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("priviostbtn.BackgroundImage")));
            this.priviostbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.priviostbtn.Location = new System.Drawing.Point(193, 208);
            this.priviostbtn.Name = "priviostbtn";
            this.priviostbtn.Size = new System.Drawing.Size(84, 55);
            this.priviostbtn.TabIndex = 18;
            this.priviostbtn.UseVisualStyleBackColor = true;
            this.priviostbtn.Click += new System.EventHandler(this.priviostbtn_Click);
            // 
            // nextbtn
            // 
            this.nextbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextbtn.BackgroundImage")));
            this.nextbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextbtn.Location = new System.Drawing.Point(103, 208);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(84, 55);
            this.nextbtn.TabIndex = 18;
            this.nextbtn.UseVisualStyleBackColor = true;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(377, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Position";
            this.label1.Click += new System.EventHandler(this.label4_Click);
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.position.Location = new System.Drawing.Point(487, 212);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(48, 29);
            this.position.TabIndex = 17;
            this.position.Text = "0/0";
            this.position.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(6, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 55);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(259, 85);
            this.textBoxDescription.MaximumSize = new System.Drawing.Size(276, 104);
            this.textBoxDescription.MinimumSize = new System.Drawing.Size(276, 104);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(276, 104);
            this.textBoxDescription.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(321, 33);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(214, 29);
            this.textBoxName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "categorie description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "categorie name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGListCategories);
            this.groupBox2.Location = new System.Drawing.Point(602, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 381);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List categories";
            // 
            // DGListCategories
            // 
            this.DGListCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGListCategories.BackgroundColor = System.Drawing.Color.Silver;
            this.DGListCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGListCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGListCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGListCategories.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGListCategories.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.DGListCategories.Location = new System.Drawing.Point(3, 25);
            this.DGListCategories.Name = "DGListCategories";
            this.DGListCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGListCategories.Size = new System.Drawing.Size(443, 353);
            this.DGListCategories.TabIndex = 133;
            this.DGListCategories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGListCategories_CellContentClick);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Green;
            this.btnNew.Location = new System.Drawing.Point(12, 321);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(143, 60);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "Add New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(161, 321);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 60);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(269, 321);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 60);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(380, 321);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 60);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FRM_CATEGORIES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1063, 396);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textCategorie);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1079, 435);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1079, 435);
            this.Name = "FRM_CATEGORIES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CATEGORIES";
            this.textCategorie.ResumeLayout(false);
            this.textCategorie.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGListCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox textCategorie;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGListCategories;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button priviostbtn;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.TextBox textId;
    }
}