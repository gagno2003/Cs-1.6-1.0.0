using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs1._6
{
    class AllWeapons
    {
        public static WeaponsAbilities Ak47 = new WeaponsAbilities() { Damage = 20, Range = 8.5, Name = "Ak47" };
        public static WeaponsAbilities M3 = new WeaponsAbilities() { Damage = 30, Range = 5.5, Name = "M3" };
        public static WeaponsAbilities ZaferP07 = new WeaponsAbilities() { Damage = 15, Range = 2.5, Name = "ZaferP07" };
        public static WeaponsAbilities SVD = new WeaponsAbilities() { Damage = 50, Range = 10.5, Name = "SVD" };
        public static WeaponsAbilities M40A5 = new WeaponsAbilities() { Damage = 40, Range = 15, Name = "M40A5" };
        public static WeaponsAbilities L115A3 = new WeaponsAbilities() { Damage = 55, Range = 9.5, Name = "L115A3" };
        public static WeaponsAbilities L39A1 = new WeaponsAbilities() { Damage = 60, Range = 7.5, Name = "L39A1" };
    }
}
