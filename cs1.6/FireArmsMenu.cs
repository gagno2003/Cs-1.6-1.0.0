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
    public partial class FireArmsMenu : UserControl
    {
        
        public FireArmsMenu()
        {
            InitializeComponent();
          
        }

        public static string Answer1 = "";
        public static string Answer2 = "";

        public static void InfoShow()
        {
            Form2 WeaponInfo = new Form2();
            WeaponInfo.Show();
        }

        

        private void FireArmsMenu_Load(object sender, EventArgs e)
        {

        }

        private void Ak47Weapon_MouseHover(object sender, EventArgs e)
        {
            Answer1 = AllWeapons.Ak47.Damage.ToString();
            Answer2 = AllWeapons.Ak47.Range.ToString();
            InfoShow();
        }

        private void M3Weapon_MouseHover(object sender, EventArgs e)
        {
            Answer1 = AllWeapons.M3.Damage.ToString();
            Answer2 = AllWeapons.M3.Range.ToString();
            InfoShow();
        }

        private void ZaferP07Weapon_MouseHover(object sender, EventArgs e)
        {
            Answer1 = AllWeapons.ZaferP07.Damage.ToString();
            Answer2 = AllWeapons.ZaferP07.Range.ToString();
            InfoShow();
        }

        private void Ak47Weapon_Click(object sender, EventArgs e)
        {
            if (AwpMenu.Player1Click == true)
            {
                Form1.P1text.Text = AllWeapons.Ak47.Name;
                Form1.Damage1 = AllWeapons.Ak47.Damage;
            }
            else if (AwpMenu.Player2Click == true)
            {
                Form1.P2text.Text = AllWeapons.Ak47.Name;
                Form1.Damage2 = AllWeapons.Ak47.Damage;
            }
        }

        private void M3Weapon_Click(object sender, EventArgs e)
        {
            if (AwpMenu.Player1Click == true)
            {
                Form1.P1text.Text = AllWeapons.M3.Name;
                Form1.Damage1 = AllWeapons.M3.Damage;
            }
            else if (AwpMenu.Player2Click == true)
            {
                Form1.P2text.Text = AllWeapons.M3.Name;
                Form1.Damage2 = AllWeapons.M3.Damage;
            }
        }

        private void ZaferP07Weapon_Click(object sender, EventArgs e)
        {
            if (AwpMenu.Player1Click == true)
            {
                Form1.P1text.Text = AllWeapons.ZaferP07.Name;
                Form1.Damage1 = AllWeapons.ZaferP07.Damage;
            }
            else if (AwpMenu.Player2Click == true)
            {
                Form1.P2text.Text = AllWeapons.ZaferP07.Name;
                Form1.Damage2 = AllWeapons.ZaferP07.Damage;
            }
        }
    }
}
