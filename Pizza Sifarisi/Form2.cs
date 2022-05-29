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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add( Pizza_sifarisi.gidenbilgi.ToString());
            
        }
    }
}
