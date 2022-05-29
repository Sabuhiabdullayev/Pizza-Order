using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Sifarisi
{
    public partial class Pizza_sifarisi : Form
    {
        public static string gidenbilgi = "";
        public Pizza_sifarisi()
        {
            InitializeComponent();
        }

        private void Pizza_sifarisi_Load(object sender, EventArgs e)
        {
            
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            

        }

     

        private void button3_Click(object sender, EventArgs e)
        {
           
            

            
        }

      
        
        private void button2_Click(object sender, EventArgs e)
        {

        }

      

      

        private void pizzacatdirilma(object sender, EventArgs e)
        {
            //RadioButton catdirilma = (RadioButton)sender;
            //lblicecekler.Text = catdirilma.Text;
        }

        private void sifarisi_yoxla(object sender, EventArgs e)
        {

        }

        private void sifaris_ekranda(object sender, EventArgs e)
        {

        }

        private void sifaris_legv(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(comboBox1.Text == "Peperoni")
            {
                pictureBox1.ImageLocation = (@"D:\programs\Pizza Sifarisi\Pizza Sifarisi\bin\Debug\Pizza icon\Pepperoni.png");
            }else if(comboBox1.Text == "Italyano")
            {
                pictureBox1.ImageLocation = (@"D:\programs\Pizza Sifarisi\Pizza Sifarisi\bin\Debug\Pizza icon\Italliano.png");
            }else if(comboBox1.Text == "Americano")
            {
                pictureBox1.ImageLocation = (@"D:\programs\Pizza Sifarisi\Pizza Sifarisi\bin\Debug\Pizza icon\Italliano.png");
            }else if(comboBox1.Text == "4 Pendirli")
            {
                pictureBox1.ImageLocation = (@"D:\programs\Pizza Sifarisi\Pizza Sifarisi\bin\Debug\Pizza icon\4pendirli.png");
            }else if(comboBox1.Text == "4 Etli")
            {
                pictureBox1.ImageLocation = (@"D:\programs\Pizza Sifarisi\Pizza Sifarisi\bin\Debug\Pizza icon\4_meat.png");
            }
        }
    }
}
