using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs1._6
{
    public partial class Form1 : Form
    {
        public List<UserControl> Weapons;
        public Form1()
        {
            InitializeComponent();
            Weapons = new List<UserControl>()
            {
                FireArmWeaponsMenu,
                AwpWeaponsMenu
            };

        }

        public int ClickCounter1 = 0;
        public int ClickCounter2 = 0;

        public void Showmenuitem(int index, int counter)
        {
            Weapons[index].Show();
            foreach (var item in Weapons)
            {
                if (item != Weapons[index])
                {
                    item.Hide();
                }
            }

            if (counter % 2 == 0)
            {
                foreach (var item in Weapons)
                {
                    item.Hide();
                }
                counter = 0;
            }
        }

        public static Label P1text = new Label();
        public static Label P2text = new Label();
        public static double Damage1 = new double();
        public static double Damage2 = new double();

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in Weapons)
            {
                item.Hide();
            }

            P1text = Player1selected;
            P2text = Player2selected;
        }

        private void FireArms_Click(object sender, EventArgs e)
        {
            ClickCounter2 = 0;
            ClickCounter1++;
            Showmenuitem(0, ClickCounter1);
        }

        private void Awp_Click(object sender, EventArgs e)
        {
            ClickCounter1 = 0;
            ClickCounter2++;
            Showmenuitem(1, ClickCounter2);
        }

        private void Player1_Click(object sender, EventArgs e)
        {
            AwpMenu.Player2Click = false;
            AwpMenu.Player1Click = true;
        }

        private void Player2_Click(object sender, EventArgs e)
        {
            AwpMenu.Player1Click = false;
            AwpMenu.Player2Click = true;
        }

        private void Versus_Click(object sender, EventArgs e)
        {
            Versus.ForeColor = Color.Red;

            if (Damage1 == 0 && Damage2 == 0)
            {
                MessageBox.Show("Please select weapons!");
            }
            else if (Damage1 == 0 && Damage2 > 0)
            {
                MessageBox.Show("Player I need weapon!");
            }
            else if (Damage1 > 0 && Damage2 == 0)
            {
                MessageBox.Show("Player II need weapon!");
            }
            else if (Damage1 > Damage2)
            {
                MessageBox.Show("Player I Win!");
            }
            else if (Damage1 == Damage2)
            {
                MessageBox.Show("Draw!");
            }
            else
            {
                MessageBox.Show("Player II Win!");
            }

            Versus.ForeColor = Color.White;
        }
    }
}
