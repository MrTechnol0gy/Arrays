using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        //0 pistol
        //1 shotgun
        //2 spreader
        //3 laser
        //4 rocket launcher
        static int weapon;
        static int[] ammo = new int[] {6, 2, 25, 50, 1};
        static int[] ammoMax = new int[] { 6, 2, 25, 50, 1 };
                            
        static string[] weaponNames = new string[] {"Pistol", "Shotgun", "Spreader", "Laser", "Rocket Launcher"};
        static void Main(string[] args)
        {
            weapon = 0;     //this tells the array what index value to use       
            Console.WriteLine("Arrays:");
            Console.WriteLine();
                        
            ShowHud();
            Fire();            
            RangeCheckAmmo(ammo);
            ShowHud();
            Reload();
            ShowHud();

            Console.ReadKey(true);
        }
        static void ShowHud()
        {
            Console.WriteLine();
            Console.WriteLine("The current weapon is: " + weaponNames[weapon]);
            Console.WriteLine("Pistol: " + ammo[0] + " Shotgun: " + ammo[1] + " Laser: " + ammo[2] + " Spreader: " + ammo[3] + " Rocket Launcher: " + ammo[4]);            
            Console.WriteLine();
        }
        static void Fire()
        {
            Console.WriteLine();
            ammo[weapon] = ammo[weapon] - 1;

        }
        static void RangeCheckAmmo(int[] ammo)
        {            
            for ( ; ammo[weapon] < 0; )
            {
                ammo[weapon] = 0;
            }
        }
        static void Reload()
        {
            ammo[weapon] = ammoMax[weapon];
        }
        
    }
}
