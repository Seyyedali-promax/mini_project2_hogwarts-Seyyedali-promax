using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogwartsProjects_hoseynzadeh
{
    class Dombledour : AuthorizedHuman
    {
        public int WhichProcess()
        {
            return 0;
        }
        public Student[] StudentProcess (Student[] x)
        {
            return x;
        }
        //Plant
        public Plants PlantsProccess(Plants x)
        {
            Console.WriteLine($"Your plants are:\n(1) Blue: {1}\n(2) Gray: {2}\n(1) Red: {3}\n(1) Yellow: {4}\n(1) Green: {5}\n(1) Pink: {6}\n(1) Sunflower: {7}",x.BlueFlower,x.GrayFlower,x.RedFlower,x.YellowFlower,x.GreenFlower,x.PinkFlower,x.SunFlower);
            string Chooseflower;
            int ChooseflowerInt = 0;
            while (1 == 1)
            {
                Console.WriteLine("Choose number of one of them for increasing its number:");
                Chooseflower = (Console.ReadLine());
                try
                {
                    ChooseflowerInt = Convert.ToInt32(Chooseflower);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Please enter a number.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                if (ChooseflowerInt > 7 || ChooseflowerInt < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Please enter a valid number.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                break;
            }
            string HowmuchIncrease;
            int HowmuchIncreaseInt = 0;
            while (1 == 1)
            {
                Console.WriteLine("Choose number of one of them for increasing its number:");
                HowmuchIncrease = (Console.ReadLine());
                try
                {
                    HowmuchIncreaseInt = Convert.ToInt32(HowmuchIncrease);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Please enter a number.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                if (HowmuchIncreaseInt < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Please enter a valid number.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                break;
            }
            switch (ChooseflowerInt)
            {
                case 1 :
                    x.BlueFlower += HowmuchIncreaseInt;
                    break;
                case 2:
                    x.GrayFlower += HowmuchIncreaseInt;
                    break;
                case 3:
                    x.RedFlower += HowmuchIncreaseInt;
                    break;
                case 4:
                    x.YellowFlower += HowmuchIncreaseInt;
                    break;
                case 5:
                    x.GreenFlower += HowmuchIncreaseInt;
                    break;
                case 6:
                    x.PinkFlower += HowmuchIncreaseInt;
                    break;
                case 7:
                    x.SunFlower += HowmuchIncreaseInt;
                    break;
            }
            return x;
        }
    }
}
