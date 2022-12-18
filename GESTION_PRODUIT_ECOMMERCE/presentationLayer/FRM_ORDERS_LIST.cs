using GESTION_PRODUIT_ECOMMERCE.bisnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_PRODUIT_ECOMMERCE.presentationLayer
{
    public partial class FRM_ORDERS_LIST : Form
    {
        public FRM_ORDERS_LIST()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_ORDERS_LIST_Load(object sender, EventArgs e)
        {
            fill_DGV_ORDERS();
            // this.dataGridView1.Rows[1].Selected = true;

           // DGVORDERS.Columns[0].Visible = false;
          //  DGVORDERS.Columns[4].Visible = false;
          //  this.DGVORDERS.RowHeadersWidth = 4;
            this.DGVORDERS.Columns[0].Width = 60;
        }

        void fill_DGV_ORDERS()
        {
            CLS_ORDERS order = new CLS_ORDERS();
            DGVORDERS.DataSource = order.GET_ALL_ORDERS();
            //  this.dataGridView1.Columns[3].Width = 130;

        }

        private void DGVORDERS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(btnDetails.BackColor==Color.Gainsboro)
            {
                btnDetails.BackColor = Color.Gold;
            }
            else
            {
                btnDetails.BackColor = Color.Gainsboro;
            }
        }

        private void boxSearchOrder_TextChanged(object sender, EventArgs e)
        {
            CLS_ORDERS order = new CLS_ORDERS();
            DataTable dt = new DataTable();
            dt = order.SearchOrder(boxSearchOrder.Text);
            DGVORDERS.DataSource = dt;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            /*  getaLLoRDERS();
              FRM_ORDER_DITAILLS ORDERDITAILLS=new FRM_ORDER_DITAILLS();
              ORDERDITAILLS.ShowDialog(); */
            //------------------
            // 
            //   FRM_ORDER_DITAILLS.dataGridViewtest.DataSource = order.GET_ALL_ORDERS();
            //  this.dataGridView1.Columns[3].Width = 130;
            FRM_ORDER_DITAILLS ORDERDITAILLS = new FRM_ORDER_DITAILLS();
            CLS_ORDERS order = new CLS_ORDERS();
            ORDERDITAILLS.dataGridViewtest.DataSource = order.GET_ORDER_DITAILLS(int.Parse(this.DGVORDERS.CurrentRow.Cells[0].Value.ToString()));
            ORDERDITAILLS.ShowDialog();
        }

        void getaLLoRDERS()
        {

        }
    }
}
