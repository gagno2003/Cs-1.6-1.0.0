using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs1._6
{
    public partial class AwpMenu : UserControl
    {
        public AwpMenu()
        {
            InitializeComponent();
        }

        public static bool Player1Click = false;
        public static bool Player2Click = false;
        
        private void SVDWeapon_MouseHover(object sender, EventArgs e)
        {
            FireArmsMenu.Answer1 = AllWeapons.SVD.Damage.ToString();
            FireArmsMenu.Answer2 = AllWeapons.SVD.Range.ToString();
            FireArmsMenu.InfoShow();
        }

        private void M40A5Weapon_MouseHover(object sender, EventArgs e)
        {
            FireArmsMenu.Answer1 = AllWeapons.M40A5.Damage.ToString();
            FireArmsMenu.Answer2 = AllWeapons.M40A5.Range.ToString();
            FireArmsMenu.InfoShow();
        }

        private void L115A3Weapon_MouseHover(object sender, EventArgs e)
        {
            FireArmsMenu.Answer1 = AllWeapons.L115A3.Damage.ToString();
            FireArmsMenu.Answer2 = AllWeapons.L115A3.Range.ToString();
            FireArmsMenu.InfoShow();
        }

        private void AwpMenu_Load(object sender, EventArgs e)
        {

        }

        private void SVDWeapon_Click(object sender, EventArgs e)
        {
            if (Player1Click == true)
            {
                Form1.P1text.Text = AllWeapons.SVD.Name;
                Form1.Damage1 = AllWeapons.SVD.Damage;
            }
            else if (Player2Click == true)
            {
                Form1.P2text.Text = AllWeapons.SVD.Name;
                Form1.Damage2 = AllWeapons.SVD.Damage;
            }
        }

        private void M40A5Weapon_Click(object sender, EventArgs e)
        {
            if (Player1Click == true)
            {
                Form1.P1text.Text = AllWeapons.M40A5.Name;
                Form1.Damage1 = AllWeapons.M40A5.Damage;
            }
            else if (Player2Click == true)
            {
                Form1.P2text.Text = AllWeapons.M40A5.Name;
                Form1.Damage2 = AllWeapons.M40A5.Damage;
            }
        }

        private void L115A3Weapon_Click(object sender, EventArgs e)
        {
            if (Player1Click == true)
            {
                Form1.P1text.Text = AllWeapons.L115A3.Name;
                Form1.Damage1 = AllWeapons.L115A3.Damage;
            }
            else if (Player2Click == true)
            {
                Form1.P2text.Text = AllWeapons.L115A3.Name;
                Form1.Damage2 = AllWeapons.L115A3.Damage;
            }
        }

        private void L39A1_MouseHover(object sender, EventArgs e)
        {
            FireArmsMenu.Answer1 = AllWeapons.L39A1.Damage.ToString();
            FireArmsMenu.Answer2 = AllWeapons.L39A1.Range.ToString();
            FireArmsMenu.InfoShow();
        }

        private void L39A1_Click(object sender, EventArgs e)
        {
            if (Player1Click == true)
            {
                Form1.P1text.Text = AllWeapons.L39A1.Name;
                Form1.Damage1 = AllWeapons.L39A1.Damage;
            }
            else if (Player2Click == true)
            {
                Form1.P2text.Text = AllWeapons.L39A1.Name;
                Form1.Damage2 = AllWeapons.L39A1.Damage;
            }
        }
    }
}
