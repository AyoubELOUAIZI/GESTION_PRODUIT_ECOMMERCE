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
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace GESTION_PRODUIT_ECOMMERCE.presentationLayer
{
    public partial class FormMain : Form
    {
        private static FormMain frm;
        static void frm_formClosed(object sender,FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FormMain getFormMain
        {
            get
            {
                if (frm == null)
                {
                    frm = new FormMain();
                    frm.FormClosed +=new FormClosedEventHandler(frm_formClosed);
                }
                return frm;
            }

        }
        public FormMain()
        {
            InitializeComponent();
            if(frm == null)
            {
                frm = this;
            }
            this.productToolStripMenuItem.Enabled= false;
            this.customersToolStripMenuItem.Enabled = false;
            this.usersToolStripMenuItem.Enabled = false;
            this.ordersToolStripMenuItem.Enabled=false;
            this.sellesToolStripMenuItem.Enabled = false;
            this.boxUserName.Visible=false;
            this.boxtypeUser.Visible = false;
            this.labelWelcom.Visible=false;
            this.userImage.Visible=false;
            this.profName.Visible=false;    
            this.sentence1.Visible=false;
           }

        private void FormMain_Load(object sender, EventArgs e)
        {
            /////////////////////////////////////
            ///
            // Set the Anchor for the image to top and left
          //  userImage.Anchor = Anchor.Top;
            /// 
            /// 
            ///
             // Enable scrolling for the panel
            panel1.AutoScroll = true;
            CLS_PRODUCTS PRODUCTS=new CLS_PRODUCTS();
            DataTable mydt=new DataTable();
            mydt = PRODUCTS.GET_ALL_PRODUCTS_AMAGES();
         //   int y = 37;
            for (int i = 0; i < mydt.Rows.Count; i++)
            {
               

                //prepare img
                byte[] img1 = (byte[])mydt.Rows[i ][0];
                MemoryStream ms = new MemoryStream(img1);
                // this.picturUser.Image = Image.FromStream(ms);
                //image1
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Location = new Point(42,10+450*i);
                pictureBox1.Size = new Size(290, 327);
                //pictureBox1.Image = Image.FromFile("C:\\myimage.jpg");
                pictureBox1.Image = Image.FromStream(ms); //Properties.Resources.Avatar;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                this.panel1.Controls.Add(pictureBox1); //prepare img


                byte[] img2 = (byte[])mydt.Rows[i][1];
                MemoryStream ms2 = new MemoryStream(img2);
                // this.picturUser.Image = Image.FromStream(ms);
                //image1
                PictureBox pictureBox2 = new PictureBox();
                pictureBox2.Location = new Point(375, 54 + 450 * i);
                pictureBox2.Size = new Size(329, 438);
                //pictureBox1.Image = Image.FromFile("C:\\myimage.jpg");
                pictureBox2.Image = Image.FromStream(ms2); //Properties.Resources.Avatar;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                this.panel1.Controls.Add(pictureBox2); //prepare img


                byte[] img3 = (byte[])mydt.Rows[i][2];
                MemoryStream ms3 = new MemoryStream(img3);
                // this.picturUser.Image = Image.FromStream(ms);
                //image1
                PictureBox pictureBox3 = new PictureBox();
                pictureBox3.Location = new Point(753, 21 + 450 * i);
                pictureBox3.Size = new Size(369, 414);
                //pictureBox1.Image = Image.FromFile("C:\\myimage.jpg");
                pictureBox3.Image = Image.FromStream(ms3); //Properties.Resources.Avatar;
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                this.panel1.Controls.Add(pictureBox3);

            }
        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin frm=new FormLogin();
            frm.ShowDialog(this);
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT fdp= new FRM_ADD_PRODUCT();
            fdp.ShowDialog();
        }

        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                FORM_PRODUCTS fpd = new FORM_PRODUCTS();
                fpd.ShowDialog();
          
          
        }

        private void manageCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMERS fcus= new FRM_CUSTOMERS();    
            fcus.ShowDialog();
        }

        private void manageCiesategorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CATEGORIES fcategorie=new FRM_CATEGORIES();
            fcategorie.ShowDialog();
        }

       

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_USERS_LIST uSERS_LIST=new FRM_USERS_LIST();
            uSERS_LIST.ShowDialog();    
        }

        private void myOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDERS_LIST fRM_ORDERS_LIST=new FRM_ORDERS_LIST();
            fRM_ORDERS_LIST.ShowDialog();
        }

        private void addNewSelleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FRM_ORDERS forder = new FRM_ORDERS();
            forder.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void boxUserName_Click(object sender, EventArgs e)
        {

        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER FADDUSER = new FRM_ADD_USER();
            FADDUSER.ShowDialog();
        }
    }
}
