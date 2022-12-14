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
        public FRM_ORDERS()
        {
            InitializeComponent();
        }

        private void FRM_ORDERS_Load(object sender, EventArgs e)
        {

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
    }
}
