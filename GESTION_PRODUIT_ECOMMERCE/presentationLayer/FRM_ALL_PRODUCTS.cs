using GESTION_PRODUIT_ECOMMERCE.bisnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_PRODUIT_ECOMMERCE.presentationLayer
{
    public partial class FRM_ALL_PRODUCTS : Form
    {
        public FRM_ALL_PRODUCTS()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FRM_ALL_PRODUCTS_Load(object sender, EventArgs e)
        {
            CLS_PRODUCTS PRD= new CLS_PRODUCTS();
            dgvproducts.DataSource= PRD.GET_ALL_PRODUCTS();
            //  dgvproducts.Columns[0].Visible = false;
            this.dgvproducts.Columns[0].Width = 30;

            byte[] img1 = (byte[])PRD.GET_PRODUCT_IMAGE1(int.Parse(this.dgvproducts.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms = new MemoryStream(img1);
            this.pictureBox1.Image = Image.FromStream(ms);
            byte[] img2 = (byte[])PRD.GET_PRODUCT_IMAGE2(int.Parse(this.dgvproducts.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms2 = new MemoryStream(img2);
            this.pictureBox2.Image = Image.FromStream(ms2);
        }

        private void dgvproducts_SelectionChanged(object sender, EventArgs e) { 
            CLS_PRODUCTS PRD = new CLS_PRODUCTS();
            byte[] img1 = (byte[])PRD.GET_PRODUCT_IMAGE1(int.Parse(this.dgvproducts.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms = new MemoryStream(img1);
            this.pictureBox1.Image = Image.FromStream(ms);
            byte[] img2 = (byte[])PRD.GET_PRODUCT_IMAGE2(int.Parse(this.dgvproducts.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms2 = new MemoryStream(img2);
            this.pictureBox2.Image = Image.FromStream(ms2);
        }

        private void dgvproducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }

        private void dgvproducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
