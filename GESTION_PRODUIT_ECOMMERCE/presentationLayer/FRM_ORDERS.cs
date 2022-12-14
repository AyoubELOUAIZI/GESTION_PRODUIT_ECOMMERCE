using GESTION_PRODUIT_ECOMMERCE.bisnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_PRODUIT_ECOMMERCE.presentationLayer
{
    public partial class FRM_ORDERS : Form
    {
        CLS_ORDERS order=new CLS_ORDERS();
        DataTable Dt=new DataTable();
        public FRM_ORDERS()
        {
            InitializeComponent();
            creatDataTable();
           
        }

        void creatDataTable()
        {
            Dt.Columns.Add("Product");
            Dt.Columns.Add("Price");
            Dt.Columns.Add("Quantite");
            Dt.Columns.Add("Amount");
            Dt.Columns.Add("Descount");
            Dt.Columns.Add("Total Amount");
            dataGridV.DataSource = Dt;
        }

        void ResizedataGridV()
        {
            this.dataGridV.RowHeadersWidth = 87;
            this.dataGridV.Columns[0].Width = 150;
            this.dataGridV.Columns[1].Width = 124;
            this.dataGridV.Columns[2].Width = 132;
            this.dataGridV.Columns[3].Width = 162;
            this.dataGridV.Columns[4].Width = 158;
            this.dataGridV.Columns[5].Width = 152;
        }

        private void FRM_ORDERS_Load(object sender, EventArgs e)
        {
            ResizedataGridV();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            boxOrderNum.Text= order.GET_LAST_ORDER_ID().Rows[0][0].ToString();
            



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void browsCus_Click(object sender, EventArgs e)
        {
            FRM_All_CUSTOMERS FAC = new FRM_All_CUSTOMERS();
            FAC.ShowDialog();
            textBoxFirstName.Text= FAC.dtgvCustomers.CurrentRow.Cells[1].Value.ToString();
            textBoxlastName.Text= FAC.dtgvCustomers.CurrentRow.Cells[2].Value.ToString();
            textBoxPhone.Text= FAC.dtgvCustomers.CurrentRow.Cells[3].Value.ToString();
            textBoxEmail.Text= FAC.dtgvCustomers.CurrentRow.Cells[4].Value.ToString();
            textBoxCity.Text = FAC.dtgvCustomers.CurrentRow.Cells[5].Value.ToString();            
            byte[] picture = (byte[])FAC.dtgvCustomers.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(picture);
            pictureBox1.Image = Image.FromStream(ms);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
