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
          //  MessageBox.Show(DT.Rows.Count.ToString());

            // AddProductsToPanel();
            // Enable scrolling for the panel
            // ORDERDITAILLS.panel1.AutoScroll = true;
            // Add some controls to the panel
            //////////////////////////////////////////////////////////////////////
            // Enable scrolling for the panel
            ORDERDITAILLS.panel1.AutoScroll = true;
            for (int i = 1; i <= DT.Rows.Count; i++)
            {
                //first line //
                // Create a new label and set its properties
                int x, y, z;
                x = 11;
                y = 300;
                z = 200;
                Label ProName = new Label();
                ProName.Text = "product name :";
                ProName.Size = new Size(194, 30);
                ProName.Location = new Point(x, y * i);
                ProName.Font = new Font("Microsoft Sans Serif", 20);
                ORDERDITAILLS.panel1.Controls.Add(ProName);

                // Create a new label and set its properties
                Label ProNameres = new Label();
                ProNameres.Text = DT.Rows[i-1][7].ToString();
                ProNameres.Size = new Size(297, 30);
                ProNameres.Location = new Point(z, y * i);
                ProNameres.Font = new Font("Microsoft Sans Serif", 20);
                ORDERDITAILLS.panel1.Controls.Add(ProNameres);

                //Second line //
                // Create a new label and set its properties
                Label Description = new Label();
                Description.Text = "Description :";
                Description.Size = new Size(114, 24);
                Description.Location = new Point(x, 30 + y * i);
                Description.Font = new Font("Microsoft Sans Serif", 14);
                ORDERDITAILLS.panel1.Controls.Add(Description);

                // Create a new label and set its properties
                Label Descriptiontext = new Label();
                Descriptiontext.Text = DT.Rows[i - 1][8].ToString();
                Descriptiontext.Size = new Size(428, 24);
                Descriptiontext.Location = new Point(122, 30 + y * i);
                Descriptiontext.Font = new Font("Microsoft Sans Serif", 14);
                ORDERDITAILLS.panel1.Controls.Add(Descriptiontext);



                //3 line //
                // Create a new label and set its properties
                Label price = new Label();
                price.Text = "Price(DH) :";
                price.Size = new Size(114, 24);
                price.Location = new Point(x, 54 + y * i);
                price.Font = new Font("Microsoft Sans Serif", 14);
                ORDERDITAILLS.panel1.Controls.Add(price);

                // Create a new label and set its properties
                Label priceres = new Label();
                priceres.Text = DT.Rows[i - 1][9].ToString();
                priceres.Size = new Size(428, 24);
                priceres.Location = new Point(122, 54 + y * i);
                priceres.Font = new Font("Microsoft Sans Serif", 14);
                ORDERDITAILLS.panel1.Controls.Add(priceres);


                //4 line //
                // Create a new label and set its properties
                Label Qantite = new Label();
                Qantite.Text = "Qantite Orderd :";
                Qantite.Size = new Size(144, 24);
                Qantite.Location = new Point(x, 78 + y * i);
                Qantite.Font = new Font("Microsoft Sans Serif", 14);
                ORDERDITAILLS.panel1.Controls.Add(Qantite);

                // Create a new label and set its properties
                Label Qantiteres = new Label();
                Qantiteres.Text = DT.Rows[i - 1][10].ToString();
                Qantiteres.Size = new Size(76, 24);
                Qantiteres.Location = new Point(152, 78 + y * i);
                Qantiteres.Font = new Font("Microsoft Sans Serif", 14);
                ORDERDITAILLS.panel1.Controls.Add(Qantiteres);


                //5 line //
                // Create a new label and set its properties
                Label Descounte = new Label();
                Descounte.Text = "Descounte :";
                Descounte.Size = new Size(111, 24);
                Descounte.Location = new Point(x, 102 + y * i);
                Descounte.Font = new Font("Microsoft Sans Serif", 14);
                ORDERDITAILLS.panel1.Controls.Add(Descounte);

                // Create a new label and set its properties
                Label descounte = new Label();
                descounte.Text = DT.Rows[i - 1][11].ToString();
                descounte.Size = new Size(101, 24);
                descounte.Location = new Point(122, 102 + y * i);
                descounte.Font = new Font("Microsoft Sans Serif", 14);
                ORDERDITAILLS.panel1.Controls.Add(descounte);
    
                //6 line //
                // Create a new label and set its properties
                Label Amount = new Label();
                Amount.Text = "Amount :";
                Amount.Size = new Size(86, 24);
                Amount.Location = new Point(x, 126 + y * i);
                Amount.Font = new Font("Microsoft Sans Serif", 14);
                ORDERDITAILLS.panel1.Controls.Add(Amount);

                // Create a new label and set its properties
                Label amount = new Label();
                amount.Text = DT.Rows[i - 1][12].ToString();
                amount.Size = new Size(101, 24);
                amount.Location = new Point(116, 126 + y * i);
                amount.Font = new Font("Microsoft Sans Serif", 14);
                ORDERDITAILLS.panel1.Controls.Add(amount);


                //7 line //
                // Create a new label and set its properties
                Label Categorie = new Label();
                Categorie.Text = "Categorie :";
                Categorie.Size = new Size(101, 24);
                Categorie.Location = new Point(x, 150 + y * i);
                Categorie.Font = new Font("Microsoft Sans Serif", 14);
                ORDERDITAILLS.panel1.Controls.Add(Categorie);

                // Create a new label and set its properties
                Label categorie1 = new Label();
                categorie1.Text = DT.Rows[i - 1][13].ToString(); ///
                categorie1.Size = new Size(208, 24);
                categorie1.Location = new Point(116, 150 + y * i);
                categorie1.Font = new Font("Microsoft Sans Serif", 14);
                ORDERDITAILLS.panel1.Controls.Add(categorie1);

                //prepare img
                byte[] img1 = (byte[])DT.Rows[i - 1][14];
                MemoryStream ms = new MemoryStream(img1);
               // this.picturUser.Image = Image.FromStream(ms);
                //image1
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Location = new Point(1000, y * i);
                pictureBox1.Size = new Size(200, 205);
                //pictureBox1.Image = Image.FromFile("C:\\myimage.jpg");
                pictureBox1.Image = Image.FromStream(ms); //Properties.Resources.Avatar;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                ORDERDITAILLS.panel1.Controls.Add(pictureBox1);

                //prepare img
                byte[] img2 = (byte[])DT.Rows[i - 1][15];
                MemoryStream ms2 = new MemoryStream(img2);
                //image2
                PictureBox pictureBox2 = new PictureBox();
                pictureBox2.Location = new Point(795, y * i);
                pictureBox2.Size = new Size(200, 205);
                //pictureBox1.Image = Image.FromFile("C:\\myimage.jpg");
                pictureBox2.Image = Image.FromStream(ms2);// Properties.Resources.Avatar;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                ORDERDITAILLS.panel1.Controls.Add(pictureBox2);


                //prepare img
                byte[] img3 = (byte[])DT.Rows[i - 1][16];
                MemoryStream ms3 = new MemoryStream(img3);
                //image3
                PictureBox pictureBox3 = new PictureBox();
                pictureBox3.Location = new Point(587, y * i);
                pictureBox3.Size = new Size(200, 205);
                //pictureBox1.Image = Image.FromFile("C:\\myimage.jpg");
                pictureBox3.Image = Image.FromStream(ms3);// Properties.Resources.Avatar;
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                ORDERDITAILLS.panel1.Controls.Add(pictureBox3);


                // Create a new label and set its properties
                Label line = new Label();
                line.Text = "______________________________________________________________";
                line.Size = new Size(630, 24);
                line.Location = new Point(272, 200 + y * i);
                line.Font = new Font("Microsoft Sans Serif", 14);
                ORDERDITAILLS.panel1.Controls.Add(line);










            }
            /////////////////////////////////////

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
