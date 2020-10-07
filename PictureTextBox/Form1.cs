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

namespace PictureTextBox
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
                string[] picture = Directory.GetFiles(@"C:\Users\user\Desktop\Pictures");
                foreach (string file in picture)
                {

                if (file.Contains(txtText.Text))
                {
                    picP1.Image = Image.FromFile(Path.Combine(@"C:\Users\user\Desktop\Pictures", txtText.Text) + ".jpg");
                }
                }
        }
    }
    }
    
    
    

