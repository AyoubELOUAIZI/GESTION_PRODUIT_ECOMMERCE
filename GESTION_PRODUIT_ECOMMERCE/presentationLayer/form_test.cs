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
    public partial class form_test : Form
    {
        // Counter to keep track of how many controls have been added
        private int controlCount = 0;
        public form_test()
        {
            InitializeComponent();
        }

        private void form_test_Load(object sender, EventArgs e)
        {

        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
          
    
      
           
            private void button1_Click(object sender, EventArgs e)
            {
                // Increment the control count
                controlCount++;

                // Create a new label and set its properties
                Label label = new Label();
                label.Text = "Label " + controlCount;
                label.Top = controlCount * 25;
                label.Left = 25;

                // Add the label to the form
                this.Controls.Add(label);

                // Create a new text box and set its properties
                TextBox textBox = new TextBox();
                textBox.Name = "textBox" + controlCount;
                textBox.Top = controlCount * 25;
                textBox.Left = 100;

                // Add the text box to the form
                this.Controls.Add(textBox);

                // Create a new button and set its properties
                Button button = new Button();
                button.Text = "Button " + controlCount;
                button.Top = controlCount * 25;
                button.Left = 200;

                // Add an event handler for the button click event
                button.Click += new EventHandler(button_Click);

                // Add the button to the form
                this.panel1.Controls.Add(button);
            }

            private void button_Click(object sender, EventArgs e)
            {
                // Cast the sender object to a Button
                Button button = (Button)sender;

                // Get the index of the button by parsing the number at the end of its Text property
                int buttonIndex = int.Parse(button.Text.Substring(button.Text.Length - 1));

                // Find the corresponding text box using its name
                TextBox textBox = (TextBox)this.Controls.Find("textBox" + buttonIndex, true)[0];

                // Display a message box with the text from the text box
                MessageBox.Show(textBox.Text);
            }

       
    }
}

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
