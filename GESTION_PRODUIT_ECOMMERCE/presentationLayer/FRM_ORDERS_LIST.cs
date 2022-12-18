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
            //FILL THE HEADER OF THE ORDER
           
            //FILL THE PANER FIRST WITHOUT LOOP
            CLS_ORDERS order = new CLS_ORDERS();
            DataTable DT=new DataTable();
            DT = order.GET_ORDER_DITAILLS(int.Parse(this.DGVORDERS.CurrentRow.Cells[0].Value.ToString()));
           // MessageBox.Show(DT.Rows[0][3].ToString());
            ORDERDITAILLS.dataGridViewtest.DataSource = DT;
            ORDERDITAILLS.boxCustomerName.Text = DT.Rows[0][3].ToString();
            ORDERDITAILLS.boxcity.Text = DT.Rows[0][4].ToString();
            ORDERDITAILLS.boxphone.Text = DT.Rows[0][5].ToString();
            ORDERDITAILLS.boxEmail.Text = DT.Rows[0][6].ToString();
            ORDERDITAILLS.boxOrderNumber.Text = DT.Rows[0][0].ToString();
            ORDERDITAILLS.boxDAte.Text = DT.Rows[0][1].ToString();
            ORDERDITAILLS.boxSeller.Text = DT.Rows[0][2].ToString();

            // AddProductsToPanel();
            // Enable scrolling for the panel
            ORDERDITAILLS.panel1.AutoScroll = true;
            // Add some controls to the panel
            for (int i = 1; i < 10; i++)
            {
                // Create a new label and set its properties
                Label label = new Label();
                label.Text = "Label " +i;
                label.Top = i * 280;
                label.Left = 25;


                Button button = new Button();
                button.Text = "Button " + i;
                button.Top = i * 205;
                ORDERDITAILLS.panel1.Controls.Add(button);
            }

            ORDERDITAILLS.ShowDialog();
        }

        void AddProductsToPanel()
        {
            FRM_ORDER_DITAILLS ORDERDITAILLS = new FRM_ORDER_DITAILLS();

            // Add some controls to the panel
            for (int i = 0; i < 50; i++)
            {
                Button button = new Button();
                button.Text = "Button " + i;
                button.Top = i * 25;
                ORDERDITAILLS.panel1.Controls.Add(button);
            }
        }

        void getaLLoRDERS()
        {

        }
    }
}
