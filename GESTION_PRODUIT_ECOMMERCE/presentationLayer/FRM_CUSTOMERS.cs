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
    public partial class FRM_CUSTOMERS : Form
    {
       // CLS_CUSTOMERS customer1 = new CLS_CUSTOMERS();
        int Myindex;
        public FRM_CUSTOMERS()
        {
            InitializeComponent();
            fillDatagridView();


        }

        void fillDatagridView()
        {
            CLS_CUSTOMERS customer = new CLS_CUSTOMERS();
            dataGridView1.DataSource = customer.GetAllCustomers();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "images folder | *.jpg; *.png; *.SVG; *.gif; *.bmp ";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void btnNew_Click(object sender, EventArgs e)
        {
            if(textBoxFirstName.Text.Length==0 && textBoxlastName.Text.Length == 0)
            {
                MessageBox.Show("You can not add new Customer with empty informations");
                return;
            }
            try
            {
                CLS_CUSTOMERS customer = new CLS_CUSTOMERS();
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] imgbyte = ms.ToArray();
                customer.ADD_CUSTOMER(textBoxFirstName.Text, textBoxlastName.Text, textBoxPhone.Text, textBoxEmail.Text, textBoxCity.Text, imgbyte);
                MessageBox.Show("Customer Added seccessfully", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillDatagridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void priviostbtn_Click(object sender, EventArgs e)
        {
            this.Myindex -= 1;
            if (Myindex >= 0)
            {
                Navigate(Myindex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Myindex = 0;
            Navigate(Myindex);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Clear();
            textBoxlastName.Clear();
            textBoxEmail.Clear();
            textBoxPhone.Clear();
            textBoxCity.Clear();
            pictureBox1.Image = Properties.Resources.Avatar;
            textBoxFirstName.Focus();
        }

        private void FRM_CUSTOMERS_Load(object sender, EventArgs e)
        {
            
            fillAlltextBoxesAndImg();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            fillAlltextBoxesAndImg();

        }


       
       


        void fillAlltextBoxesAndImg()
        {
            try
            {
                textBoxFirstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBoxlastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBoxPhone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBoxEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBoxCity.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                byte[] picture = (byte[])dataGridView1.CurrentRow.Cells[6].Value;
                MemoryStream ms = new MemoryStream(picture);
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CLS_CUSTOMERS customer = new CLS_CUSTOMERS();//////
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] imgbyte = ms.ToArray();
            customer.UPDATE_CUSTOMER(textBoxFirstName.Text, textBoxlastName.Text, textBoxPhone.Text, textBoxEmail.Text, textBoxCity.Text, imgbyte, Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            MessageBox.Show("Customer Updated seccessfully", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fillDatagridView();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Customer", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                CLS_CUSTOMERS customer = new CLS_CUSTOMERS();/////////
                customer.DELETE_CUSTOMER(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("Customer has been deleted seccessfully", "delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillDatagridView();
                fillAlltextBoxesAndImg();
            }
            else
            {
                MessageBox.Show("Cancel deleted Customer seccessfully", "Cancel delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLS_CUSTOMERS customer = new CLS_CUSTOMERS();//////////
            dataGridView1.DataSource = customer.SEARCH_CUSTOMER(boxSearch.Text);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;

        }

        private void boxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                button1_Click(sender, e);
            }
            
        }

        void Navigate(int index)
        {
            CLS_CUSTOMERS customer = new CLS_CUSTOMERS();
            DataTable DT= customer.GetAllCustomers();

            textBoxFirstName.Text = DT.Rows[index][1].ToString();
            textBoxlastName.Text = DT.Rows[index][2].ToString();
            textBoxPhone.Text = DT.Rows[index][3].ToString();
            textBoxEmail.Text = DT.Rows[index][4].ToString();
            textBoxCity.Text = DT.Rows[index][5].ToString();
            byte[] picture = (byte[])DT.Rows[index][6];
            MemoryStream ms = new MemoryStream(picture);
            pictureBox1.Image = Image.FromStream(ms);


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Myindex = dataGridView1.RowCount-1;
            Navigate(Myindex);

        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            this.Myindex += 1;
            if(Myindex<= dataGridView1.RowCount - 1)
            {
                Navigate(Myindex);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            fillAlltextBoxesAndImg();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxlastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void boxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
