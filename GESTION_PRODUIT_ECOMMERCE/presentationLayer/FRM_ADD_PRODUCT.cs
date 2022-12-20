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
    public partial class FRM_ADD_PRODUCT : Form
    {
        public string status = "add";
        public int idproduct;
        public FRM_ADD_PRODUCT()
        {         
            InitializeComponent();
            CLS_PRODUCTS prd = new CLS_PRODUCTS();
            cmbCategories.DataSource = prd.GetAllGategores();
            cmbCategories.DisplayMember= "NamCAT";
            cmbCategories.ValueMember= "idCAT";
        }

        private void FRM_ADD_PRODUCT_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd =new OpenFileDialog();
            ofd.Filter = "images folder | *.jpg; *.png; *.SVG; *.gif; *.bmp ";
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                pictureBox2.Image=Image.FromFile(ofd.FileName);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "images folder | *.jpg; *.png; *.SVG; *.gif; *.bmp ";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(ofd.FileName);
            }

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

        private void btnOK_Click(object sender, EventArgs e)
        {
            CLS_PRODUCTS prd = new CLS_PRODUCTS();
            MemoryStream ms1=new MemoryStream();
            MemoryStream ms2=new MemoryStream();
            MemoryStream ms3=new MemoryStream();
            pictureBox1.Image.Save(ms1, pictureBox1.Image.RawFormat);
            pictureBox2.Image.Save(ms2, pictureBox2.Image.RawFormat);
            pictureBox3.Image.Save(ms3, pictureBox3.Image.RawFormat);
            byte[] imgbyte1 = ms1.ToArray(); 
            byte[] imgbyte2 = ms2.ToArray(); 
            byte[] imgbyte3 = ms3.ToArray();
           // if (this.status == "add")
            if (this.status == "add")
            {
                MessageBox.Show("add");
                prd.ADD_PRODUCT(textname.Text, textdescription.Text, int.Parse(textQantete.Text), float.Parse(textPrice.Text), imgbyte1, imgbyte2, imgbyte3, Convert.ToInt32(cmbCategories.SelectedValue));
                MessageBox.Show("inserted seccessfuly", "inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(this.status == "update")
            {
                 MessageBox.Show("update");
                prd.Update_PRODUCT(textname.Text, textdescription.Text, int.Parse(textQantete.Text), float.Parse(textPrice.Text), imgbyte1, imgbyte2, imgbyte3, Convert.ToInt32(cmbCategories.SelectedValue), this.idproduct);
                MessageBox.Show("Updated seccessfuly", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();       
        }
    }
}
