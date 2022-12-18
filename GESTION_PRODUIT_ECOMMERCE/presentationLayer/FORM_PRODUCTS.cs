using GESTION_PRODUIT_ECOMMERCE.bisnessLayer;
using GESTION_PRODUIT_ECOMMERCE.dataAccessLayer;
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
    public partial class FORM_PRODUCTS : Form
    {
        CLS_PRODUCTS PRD=new CLS_PRODUCTS();
        public FORM_PRODUCTS()
        {
            InitializeComponent();
            dataGridView1.DataSource = PRD.GET_ALL_PRODUCTS();

        }

        private void FORM_PRODUCTS_Load(object sender, EventArgs e)
        {
            CLS_PRODUCTS PRD = new CLS_PRODUCTS();

            byte[] img1 = (byte[])PRD.GET_PRODUCT_IMAGE1(int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms = new MemoryStream(img1);
            this.pictureBox1.Image = Image.FromStream(ms);
            byte[] img2 = (byte[])PRD.GET_PRODUCT_IMAGE2(int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms2 = new MemoryStream(img2);
            this.pictureBox2.Image = Image.FromStream(ms2);

            byte[] img3 = (byte[])PRD.GET_PRODUCT_IMAGE3(int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms3 = new MemoryStream(img3);
            this.pictureBox3.Image = Image.FromStream(ms3);

        }
       

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CLS_PRODUCTS PRD= new CLS_PRODUCTS();
            DataTable dt=new DataTable();
            dt=PRD.Search(searchbox.Text);
            dataGridView1.DataSource= dt;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CLS_PRODUCTS PRD = new CLS_PRODUCTS();
            FRM_ADD_PRODUCT FDP=new FRM_ADD_PRODUCT();
            FDP.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete this product", "Delete product", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                CLS_PRODUCTS PRD = new CLS_PRODUCTS();
                PRD.DeleteProduct(int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("deleted seccessfully");
                dataGridView1.DataSource = PRD.GET_ALL_PRODUCTS();
            }
            else
            {
                MessageBox.Show("deleting has been canceled", "Cancel Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT FUP = new FRM_ADD_PRODUCT();
            FUP.idproduct= int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            FUP.status = "update";
            FUP.textname.Text= this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            FUP.textdescription.Text= this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            FUP.textQantete.Text= this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            FUP.textPrice.Text=this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            FUP.cmbCategories.Text= this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            FUP.Text = "UPDATE PRODUCT : " + FUP.textname.Text;
            FUP.btnOK.Text = "Update";
            FUP.BackColor= Color.White;
            CLS_PRODUCTS PRD= new CLS_PRODUCTS();

            byte[] img1 = (byte[])PRD.GET_PRODUCT_IMAGE1(int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms= new MemoryStream(img1);
            FUP.pictureBox1.Image=Image.FromStream(ms);

            byte[] img2 = (byte[])PRD.GET_PRODUCT_IMAGE2(int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms2= new MemoryStream(img2);
            FUP.pictureBox2.Image=Image.FromStream(ms2);

            byte[] img3 = (byte[])PRD.GET_PRODUCT_IMAGE3(int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms3= new MemoryStream(img3);
            FUP.pictureBox3.Image=Image.FromStream(ms3);
            FUP.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            /////////
            Close();
        }

        private void btnPrintProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintList_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveExel_Click(object sender, EventArgs e)
        {

        }

        private void btnRefrech_Click(object sender, EventArgs e)
        {
            CLS_PRODUCTS PRD = new CLS_PRODUCTS();
            dataGridView1.DataSource = PRD.GET_ALL_PRODUCTS();

            byte[] img1 = (byte[])PRD.GET_PRODUCT_IMAGE1(int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms = new MemoryStream(img1);
            this.pictureBox1.Image = Image.FromStream(ms);
            byte[] img2 = (byte[])PRD.GET_PRODUCT_IMAGE2(int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms2 = new MemoryStream(img2);
            this.pictureBox2.Image = Image.FromStream(ms2);

            byte[] img3 = (byte[])PRD.GET_PRODUCT_IMAGE3(int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms3 = new MemoryStream(img3);
            this.pictureBox3.Image = Image.FromStream(ms3);

        }

        private void FORM_PRODUCTS_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CLS_PRODUCTS PRD = new CLS_PRODUCTS();

            byte[] img1 = (byte[])PRD.GET_PRODUCT_IMAGE1(int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms = new MemoryStream(img1);
            this.pictureBox1.Image = Image.FromStream(ms);
            byte[] img2 = (byte[])PRD.GET_PRODUCT_IMAGE2(int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms2 = new MemoryStream(img2);
            this.pictureBox2.Image = Image.FromStream(ms2);

            byte[] img3 = (byte[])PRD.GET_PRODUCT_IMAGE3(int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms3 = new MemoryStream(img3);
            this.pictureBox3.Image = Image.FromStream(ms3);
        }
    }
}
