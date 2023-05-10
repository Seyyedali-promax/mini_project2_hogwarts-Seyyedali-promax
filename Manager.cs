using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwartz_hoseynzadeh2
{
    class Manager:AouthorizedHuman
    {
        public string[] Actions = new string[] {"Read Letters","Supply Plants","Exit"};
        public List<int> StudentOfDemands = new List<int>();
       public bool Login ()
        {
            Console.WriteLine("If you are the manager, Please Enter your password:");
            string Input = Console.ReadLine();
            if (Input == "1234")
            {
                return true;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nPassword is Incorrect.");
            Console.ForegroundColor = ConsoleColor.White;
            return false;
        }
        //Supply Plants
        public void PlantProcess ()
        {
            Console.Clear();
            Console.WriteLine($"Your plants are:\n\n(1) Blue: {Program.Garden.BlueFlower} \n(2) Gray: {Program.Garden.GrayFlower} \n(3) Red: {Program.Garden.RedFlower} \n(4) Yellow: {Program.Garden.YellowFlower} \n(5) Green: {Program.Garden.GreenFlower} \n(6) Pink: {Program.Garden.PinkFlower} \n(7) Sunflower: {Program.Garden.SunFlower} ");

            string Chooseflower;
            int ChooseflowerInt = 0;
            while (1 == 1)
            {
                Console.WriteLine("--------------------\nChoose number of one of them for increasing its number:");
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
                Console.WriteLine("How much? :");
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
               case 1:
                   Program.Garden.BlueFlower += HowmuchIncreaseInt;
                   break;
               case 2:
                   Program.Garden.GrayFlower += HowmuchIncreaseInt;
                   break;
               case 3:
                   Program.Garden.RedFlower += HowmuchIncreaseInt;
                   break;
               case 4:
                   Program.Garden.YellowFlower += HowmuchIncreaseInt;
                   break;
               case 5:
                   Program.Garden.GreenFlower += HowmuchIncreaseInt;
                   break;
               case 6:
                   Program.Garden.PinkFlower += HowmuchIncreaseInt;
                   break;
               case 7:
                   Program.Garden.SunFlower += HowmuchIncreaseInt;
                   break;
           }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nThe plants Increased successfuly.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        //Answer The Students letters
        public void LetterProcess ()
        {
            if (Program.Dombledour.Letters.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n You haven't any letter!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("You have some letters:");
                for (int i = 0; i<Program.Dombledour.Letters.Count;i++)
                {
                    Console.WriteLine($"({i+1}) {Program.Dombledour.Letters[i]}");
                    string[] Choise = new string[2] {"Yes. I will send him a ticket.","NO!"};
                    int ChoiseInt = Program.MyMethods.Choise(Choise, "What do you do?");
                    switch(ChoiseInt)
                    {
                        case 1:
                            Program.Students[Program.Dombledour.StudentOfDemands[i]].Letters.Add("Dombledour: You have a ticket now!");
                            Program.Students[Program.Dombledour.StudentOfDemands[i]].Ticket = true;
                            break;
                        case 2:
                            Program.Students[Program.Dombledour.StudentOfDemands[i]].Letters.Add("Dombledour: Your request about ticket rejected.");
                            break;
                    }
                }
                Program.Dombledour.Letters.Clear();
                Program.Dombledour.StudentOfDemands.Clear();
            }
        }
    }
}
