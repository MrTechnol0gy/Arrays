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

        static int[] ammo = new int[] {6, 2, 50, 25, 1}; //array of integers; declaration
        
        static string[] weapon = new string[] { "Pistol", "Shotgun", "Spreader", "Laser", "Rocket Launcher" };
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays:");
            Console.WriteLine();
            
            ShowHud();
            Fire();
            //RangeCheckAmmo();
            ShowHud();

            Console.ReadKey(true);
        }
        static void ShowHud()
        {
            Console.WriteLine();
            Console.WriteLine("The current weapon is: " + weapon[0]);
            Console.WriteLine("Pistol: " + ammo[0] + " Shotgun: " + ammo[1] + " Laser: " + ammo[2] + " Spreader: " + ammo[3] + " Rocket Launcher: " + ammo[4]);            
            Console.WriteLine();
        }
        static void Fire()
        {
            Console.WriteLine();
            ammo[0]--;

        }
        static void RangeCheckAmmo()
        {
            foreach (var ammo in ammo)
            {

            }
        }
        
    }
}
