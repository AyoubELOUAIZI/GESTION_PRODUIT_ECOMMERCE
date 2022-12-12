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
        CLS_CUSTOMERS customer = new CLS_CUSTOMERS();
        public FRM_CUSTOMERS()
        {
            InitializeComponent();
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
            try
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] imgbyte = ms.ToArray();
                customer.ADD_CUSTOMER(textBoxFirstName.Text, textBoxlastName.Text, textBoxPhone.Text, textBoxEmail.Text, textBoxCity.Text, imgbyte);
                MessageBox.Show("Customer Added seccessfully", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void priviostbtn_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
