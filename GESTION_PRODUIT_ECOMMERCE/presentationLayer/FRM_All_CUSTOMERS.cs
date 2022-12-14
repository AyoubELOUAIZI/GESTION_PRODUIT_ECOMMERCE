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
    public partial class FRM_All_CUSTOMERS : Form
    {
        public FRM_All_CUSTOMERS()
        {
            InitializeComponent();
        }

        private void FRM_All_CUSTOMERS_Load(object sender, EventArgs e)
        {
            fillDatagridView();


        }

        void fillDatagridView()
        {
            CLS_CUSTOMERS customer = new CLS_CUSTOMERS();
            dtgvCustomers.DataSource = customer.GetAllCustomers();
            dtgvCustomers.Columns[0].Visible = false;
            dtgvCustomers.Columns[6].Visible = false;
        }

        private void dtgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // FRM_All_CUSTOMERS FAC = new FRM_All_CUSTOMERS();
           
        }

        private void dtgvCustomers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            byte[] picture = (byte[])dtgvCustomers.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(picture);
            CustomerImg.Image = Image.FromStream(ms);

        }

        private void dtgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }
    }
}
