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
    public partial class FRM_ORDER_DITAILLS : Form
    {
        public FRM_ORDER_DITAILLS()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FRM_ORDER_DITAILLS_Load(object sender, EventArgs e)
        {

           // ADD_PRODUCTS();
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        void ADD_PRODUCTS()
        {


            // Enable scrolling for the panel
            panel1.AutoScroll = true;


            for (int i = 1; i < 25; i++)
            {
                //first line //
                // Create a new label and set its properties
                int x, y,z;
                x = 11;
                y = 300;
                z = 200;
                Label ProName = new Label();
                ProName.Text = "product name :";
                ProName.Size = new Size(194, 30);
                ProName.Location = new Point(x, y*i);
                ProName.Font = new Font("Microsoft Sans Serif", 20);
                panel1.Controls.Add(ProName);

                // Create a new label and set its properties
                Label ProNameres = new Label();
                ProNameres.Text = "name of product";
                ProNameres.Size = new Size(297, 30);
                ProNameres.Location = new Point(z, y*i);
                ProNameres.Font = new Font("Microsoft Sans Serif", 20);
                panel1.Controls.Add(ProNameres);

                //Second line //
                // Create a new label and set its properties
                Label Description = new Label();
                Description.Text = "Description :";
                Description.Size = new Size(114, 24);
                Description.Location = new Point(x, 30+y*i);
                Description.Font = new Font("Microsoft Sans Serif", 14);
                panel1.Controls.Add(Description);

                // Create a new label and set its properties
                Label Descriptiontext = new Label();
                Descriptiontext.Text = "product description kkkkkkkkkkkkkkkkkkkkkkkkkkkk";
                Descriptiontext.Size = new Size(428, 24);
                Descriptiontext.Location = new Point(122, 30+y*i);
                Descriptiontext.Font = new Font("Microsoft Sans Serif", 14);
                panel1.Controls.Add(Descriptiontext);



                //3 line //
                // Create a new label and set its properties
                Label price = new Label();
                price.Text = "Price(DH) :";
                price.Size = new Size(114, 24);
                price.Location = new Point(x, 54+y * i );
                price.Font = new Font("Microsoft Sans Serif", 14);
                panel1.Controls.Add(price);

                // Create a new label and set its properties
                Label priceres = new Label();
                priceres.Text = "priceeeee";
                priceres.Size = new Size(428, 24);
                priceres.Location = new Point(122, 54+y * i);
                priceres.Font = new Font("Microsoft Sans Serif", 14);
                panel1.Controls.Add(priceres);


                //4 line //
                // Create a new label and set its properties
                Label Qantite = new Label();
                Qantite.Text = "Qantite Orderd :";
                Qantite.Size = new Size(144, 24);
                Qantite.Location = new Point(x, 78+y* i);
                Qantite.Font = new Font("Microsoft Sans Serif", 14);
                panel1.Controls.Add(Qantite);

                // Create a new label and set its properties
                Label Qantiteres = new Label();
                Qantiteres.Text = "Qantete";
                Qantiteres.Size = new Size(76, 24);
                Qantiteres.Location = new Point(152, 78+y* i);
                Qantiteres.Font = new Font("Microsoft Sans Serif", 14);
                panel1.Controls.Add(Qantiteres);


                //5 line //
                // Create a new label and set its properties
                Label Descounte = new Label();
                Descounte.Text = "Descounte :";
                Descounte.Size = new Size(111, 24);
                Descounte.Location = new Point(x, 102+y * i);
                Descounte.Font = new Font("Microsoft Sans Serif", 14);
                panel1.Controls.Add(Descounte);

                // Create a new label and set its properties
                Label descounte = new Label();
                descounte.Text = "descounte";
                descounte.Size = new Size(101, 24);
                descounte.Location = new Point(122, 102 + y * i);
                descounte.Font = new Font("Microsoft Sans Serif", 14);
                panel1.Controls.Add(descounte);

                //6 line //
                // Create a new label and set its properties
                Label Amount = new Label();
                Amount.Text = "Amount :";
                Amount.Size = new Size(86, 24);
                Amount.Location = new Point(x,126+y * i);
                Amount.Font = new Font("Microsoft Sans Serif", 14);
                panel1.Controls.Add(Amount);

                // Create a new label and set its properties
                Label amount = new Label();
                amount.Text = "amount";
                amount.Size = new Size(101, 24);
                amount.Location = new Point(116, 126+y* i);
                amount.Font = new Font("Microsoft Sans Serif", 14);
                panel1.Controls.Add(amount);


                //7 line //
                // Create a new label and set its properties
                Label Categorie = new Label();
                Categorie.Text = "Categorie :";
                Categorie.Size = new Size(101, 24);
                Categorie.Location = new Point(x,150+y * i);
                Categorie.Font = new Font("Microsoft Sans Serif", 14);
                panel1.Controls.Add(Categorie);

                // Create a new label and set its properties
                Label categorie1 = new Label();
                categorie1.Text = "categorie";
                categorie1.Size = new Size(101, 24);
                categorie1.Location = new Point(x, 150+y* i);
                categorie1.Font = new Font("Microsoft Sans Serif", 14);
                panel1.Controls.Add(categorie1); 


                //image1
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Location = new Point(1000, y * i);
                pictureBox1.Size = new Size(200, 205);
                //pictureBox1.Image = Image.FromFile("C:\\myimage.jpg");
                pictureBox1.Image = Properties.Resources.Avatar;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                panel1.Controls.Add(pictureBox1);

                //image2
                PictureBox pictureBox2 = new PictureBox();
                pictureBox2.Location = new Point(795, y * i);
                pictureBox2.Size = new Size(200, 205);
                //pictureBox1.Image = Image.FromFile("C:\\myimage.jpg");
                pictureBox2.Image = Properties.Resources.Avatar;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                panel1.Controls.Add(pictureBox2);

                //image3
                PictureBox pictureBox3 = new PictureBox();
                pictureBox3.Location = new Point(587, y * i);
                pictureBox3.Size = new Size(200, 205);
                //pictureBox1.Image = Image.FromFile("C:\\myimage.jpg");
                pictureBox3.Image = Properties.Resources.Avatar;
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                panel1.Controls.Add(pictureBox3);


                // Create a new label and set its properties
                Label line = new Label();
                line.Text = "______________________________________________________________";
                line.Size = new Size(630, 24);
                line.Location = new Point(272, 200+y * i);
                line.Font = new Font("Microsoft Sans Serif", 14);
                panel1.Controls.Add(line);   










            }

        }





    }
}
