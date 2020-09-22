using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs1._6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            Answer1.Text = FireArmsMenu.Answer1;
            Answer2.Text = FireArmsMenu.Answer2;
        }
    }
}
