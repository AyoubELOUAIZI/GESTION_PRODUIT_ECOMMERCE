using GESTION_PRODUIT_ECOMMERCE.bisnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        CLS_ORDERS order = new CLS_ORDERS();
        double Amount;
        int AvailabelQte;
      //  string productId;
        DataTable Dt = new DataTable();
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
            this.dataGridV.RowHeadersWidth = 75;
            this.dataGridV.Columns[0].Width = 159;
            this.dataGridV.Columns[1].Width = 126;
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
            boxOrderNum.Text = order.GET_LAST_ORDER_ID().Rows[0][0].ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void browsCus_Click(object sender, EventArgs e)
        {
            FRM_All_CUSTOMERS FAC = new FRM_All_CUSTOMERS();
            FAC.ShowDialog();
           
            textBoxFirstName.Text = FAC.dtgvCustomers.CurrentRow.Cells[1].Value.ToString();
            textBoxlastName.Text = FAC.dtgvCustomers.CurrentRow.Cells[2].Value.ToString();
            textBoxPhone.Text = FAC.dtgvCustomers.CurrentRow.Cells[3].Value.ToString();
            textBoxEmail.Text = FAC.dtgvCustomers.CurrentRow.Cells[4].Value.ToString();
            textBoxCity.Text = FAC.dtgvCustomers.CurrentRow.Cells[5].Value.ToString();
            byte[] picture = (byte[])FAC.dtgvCustomers.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(picture);
            pictureBox1.Image = Image.FromStream(ms);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ALL_PRODUCTS ALL_PRODUCTS = new FRM_ALL_PRODUCTS();
            ALL_PRODUCTS.ShowDialog();
          //   productId= ALL_PRODUCTS.dgvproducts.CurrentRow.Cells[0].Value.ToString();
            boxproduct.Text = ALL_PRODUCTS.dgvproducts.CurrentRow.Cells[1].Value.ToString();
            boxprice.Text = ALL_PRODUCTS.dgvproducts.CurrentRow.Cells[4].Value.ToString();
            AvailabelQte = Convert.ToInt32(ALL_PRODUCTS.dgvproducts.CurrentRow.Cells[4].Value.ToString());
            boxquantete.Focus();
           
        }

        private void dataGridV_SelectionChanged(object sender, EventArgs e)
        {
            /*  CLS_PRODUCTS PRD = new CLS_PRODUCTS();

              byte[] img1 = (byte[])PRD.GET_PRODUCT_IMAGE1(int.Parse(this.dataGridV.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
              MemoryStream ms = new MemoryStream(img1);
              this.ppictur1.Image = Image.FromStream(ms);
              byte[] img2 = (byte[])PRD.GET_PRODUCT_IMAGE2(int.Parse(this.dataGridV.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
              MemoryStream ms2 = new MemoryStream(img2);
              this.ppictur2.Image = Image.FromStream(ms2);

              byte[] img3 = (byte[])PRD.GET_PRODUCT_IMAGE3(int.Parse(this.dataGridV.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
              MemoryStream ms3 = new MemoryStream(img3);
              this.ppictur3.Image = Image.FromStream(ms3);*/
        }

        private void dataGridV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void boxDescount_KeyPress(object sender, KeyPressEventArgs e)
        {

            char decimaleSeparater = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (boxDescount.Text != "")
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != decimaleSeparater)
                {
                    e.Handled = true;
                }
            } 
            else
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }

           



        }

        private void boxquantete_KeyPress(object sender, KeyPressEventArgs e)
        {
            char decimaleSeparater = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }


        }

        private void boxquantete_TextChanged(object sender, EventArgs e)
        {
            if (boxquantete.Text == "")
            {
                boxAmount.Text = "";
                Amount = 0;
                boxTotalAmount.Text = "";
                boxDescount.Text = "";


            }
        }

        private void boxquantete_KeyDown(object sender, KeyEventArgs e)
        {
            
            //-------------------------------//
            if (e.KeyCode == Keys.Enter && boxquantete.Text != string.Empty)
            {
                if (AvailabelQte >= int.Parse(boxquantete.Text))
                {
                    boxDescount.Focus();
                }
                else
                {
                    MessageBox.Show("Sorry this Quantity " + boxquantete.Text + " does not existe on stock", "Quantity error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    boxquantete.Focus();
                    // boxAmount.Text = "";
                }
            }
        }

        private void boxquantete_KeyUp(object sender, KeyEventArgs e)
        {
            //check if the product exists
            for (int i = 0; i < dataGridV.Rows.Count; i++)
            {
                if (this.dataGridV.Rows[i].Cells[0].Value.ToString() == boxproduct.Text && this.dataGridV.Rows[i].Cells[1].Value.ToString() == boxprice.Text)
                {
                    boxquantete.Text = "";
                    boxAmount.Text = "";
                    MessageBox.Show("Sorry this product already exist in the list\nyou can update it if you want", "product repeated", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

            }
            CalculateAmount();
        }

        void CalculateAmount()
        {
            if (boxquantete.Text != string.Empty && AvailabelQte >= double.Parse(boxquantete.Text))
            {
                Amount = int.Parse(boxquantete.Text) * double.Parse(boxprice.Text);
                boxAmount.Text = Amount.ToString();
            }
            else if (boxquantete.Text != string.Empty)
            {
                if (boxproduct.Text != string.Empty)
                {
                    MessageBox.Show("Sorry this Quantity " + boxquantete.Text + " does not existe on stock\nthe max Quantity possible is " + AvailabelQte, "Quantity error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    boxquantete.Focus();
                    boxquantete.Text = "";
                    // boxAmount.Text = "";
                }
                else
                {
                    MessageBox.Show("Sorry you did not chose a Product ", "chose Product", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    boxquantete.Text = "";
                    boxAmount.Text = "";
                    boxTotalAmount.Text = "";
                    boxTotalAmount.Text = "";
                    btnbrows.Focus();
                    btnbrows.BackColor = Color.Goldenrod;



                }
            }

        }

        private void btnbrows_Click(object sender, EventArgs e)
        {
            FRM_ALL_PRODUCTS ALL_PRODUCTS = new FRM_ALL_PRODUCTS();
            CLS_PRODUCTS PRD = new CLS_PRODUCTS();
            ALL_PRODUCTS.ShowDialog();

            boxproduct.Text = ALL_PRODUCTS.dgvproducts.CurrentRow.Cells[1].Value.ToString();
            boxprice.Text = ALL_PRODUCTS.dgvproducts.CurrentRow.Cells[4].Value.ToString();
            AvailabelQte = Convert.ToInt32(ALL_PRODUCTS.dgvproducts.CurrentRow.Cells[3].Value.ToString());

            byte[] img1 = (byte[])PRD.GET_PRODUCT_IMAGE1(int.Parse(ALL_PRODUCTS.dgvproducts.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms = new MemoryStream(img1);
            ppictur1.Image = Image.FromStream(ms);

            byte[] img2 = (byte[])PRD.GET_PRODUCT_IMAGE2(int.Parse(ALL_PRODUCTS.dgvproducts.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms2 = new MemoryStream(img2);
            ppictur2.Image = Image.FromStream(ms2);

            byte[] img3 = (byte[])PRD.GET_PRODUCT_IMAGE3(int.Parse(ALL_PRODUCTS.dgvproducts.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms3 = new MemoryStream(img3);
            ppictur3.Image = Image.FromStream(ms3);


            boxquantete.Focus();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        void ClearBoxes()
        {

            boxproduct.Text = "";
            boxprice.Text = "";
            boxquantete.Text = "";
            boxAmount.Text = "";
            boxDescount.Text = "";
            boxTotalAmount.Text = "";
            btnbrows.Focus();
        }

        void CalculateTotalAmount()
        {
            double totalAmount = Amount - (Amount * double.Parse(boxDescount.Text) / 100);
            boxTotalAmount.Text = totalAmount.ToString();
        }

        private void boxDescount_TextChanged(object sender, EventArgs e)
        {



            if (boxDescount.Text == "")
            {
                boxTotalAmount.Text = "";
                return;
            }
            if (boxAmount.Text.Length == 0)
            {
                MessageBox.Show("Sorry you did not specify the Quantity", "Quantity error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                boxDescount.Text = "";
                boxquantete.Focus();
                return;

            }

            if (double.Parse(boxDescount.Text) < 0 || double.Parse(boxDescount.Text) > 100)
            {
                MessageBox.Show("Sorry Descount shoud be between 0% end 100%", "Descount error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                boxDescount.Text = "";
                return;
            }
            CalculateTotalAmount();
           
        }

        private void boxAmount_TextChanged(object sender, EventArgs e)
        {
            boxDescount.Text = "";
            boxTotalAmount.Text = "";
        } 

        void fillDataRow()
        {

            for(int i =0; i < dataGridV.Rows.Count; i++)
            {
                if (this.dataGridV.Rows[i].Cells[0].Value.ToString()==boxproduct.Text && this.dataGridV.Rows[i].Cells[1].Value.ToString() == boxprice.Text)
                {
                  MessageBox.Show("Sorry this product already exist in the list\nyou can update it if you want", "product repeated", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

            }  



            //why this problem//

            DataRow r = Dt.NewRow();
            r[0] = boxproduct.Text;
            r[1] = boxprice.Text;
            r[2] = boxquantete.Text;
            r[3] = boxAmount.Text;
            r[4] = boxDescount.Text;
            r[5] = boxTotalAmount.Text;
            Dt.Rows.Add(r);
            dataGridV.DataSource = Dt;
            ClearBoxes();
            //calculate somme
            boxSomme.Text = (from DataGridViewRow row in dataGridV.Rows
                             where row.Cells[5].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            if (boxTotalAmount.Text == "")
            {
               // MessageBox.Show("oooooooo");
                return;
            }
            fillDataRow();
        }

        private void dataGridV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ClearBoxes();
                boxproduct.Text = dataGridV.CurrentRow.Cells[0].Value.ToString();
                boxprice.Text = dataGridV.CurrentRow.Cells[1].Value.ToString();
                boxquantete.Text = dataGridV.CurrentRow.Cells[2].Value.ToString();
                boxAmount.Text = dataGridV.CurrentRow.Cells[3].Value.ToString();
                boxDescount.Text = dataGridV.CurrentRow.Cells[4].Value.ToString();
                boxTotalAmount.Text = dataGridV.CurrentRow.Cells[5].Value.ToString();
                dataGridV.Rows.RemoveAt(dataGridV.CurrentRow.Index);
                boxquantete.Focus();

            }
            catch
            {
                MessageBox.Show("there is an error ");
            }
            }

        private void boxDescount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && boxTotalAmount.Text != "")
            {
                //fill by just click enter
                fillDataRow();
            }
        }

        private void dataGridV_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //calculate somme
            boxSomme.Text = (from DataGridViewRow row in dataGridV.Rows
                             where row.Cells[5].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();

        }
    }
}
