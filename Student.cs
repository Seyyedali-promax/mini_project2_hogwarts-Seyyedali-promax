using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hogwartz_hoseynzadeh2
{
    class Student : AouthorizedHuman
    {
        public string[] Actions = new string[6] { "Read my letters.", "Give a ticket.","Boarding the Train.","Choose my Courses.","Doing my homeworks.","Exit"};
        public string[] PassedCourses = new string[4];
        public int NumberOfTerm = 1;
        public bool Ticket = false;
        public bool IsHeInHogwartz = false;
        public int BlueFlower =   0;
        public int GrayFlower =   0;
        public int RedFlower =    0;
        public int YellowFlower = 0;
        public int GreenFlower =  0;
        public int PinkFlower =   0;
        public int SunFlower =    0;
        public void LetterProcess(int Whichone)
        {
            string Request = "Enter";
            if (Program.Students[Whichone].IsHeInHogwartz == true)
            {
                Request = "Exit";
            }
            string[] Choises = new string[2] { "Yes", "No" };
            int Choise = Program.MyMethods.Choise(Choises, $"Do you want {Request} Hogwartz?");
            if (Choise == 1)
            {
                Program.Dombledour.Letters.Add($"Hello Dombledour! i.m {Program.Students[Whichone].Name} {Program.Students[Whichone].Family}.\n I want {Request} Hogwartz.\n Please send me a ticket.");
                Program.Dombledour.StudentOfDemands.Add(Whichone);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nYour request sent successfuly.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        // Log in
        public int Login()
        {
            //UI
            Console.Clear();
            Console.WriteLine("Enter Your username:");
            string InputUsername = Console.ReadLine();
            Console.WriteLine("EnterYour Password:");
            string InputPassword = Console.ReadLine();
            //Background
            int Result = -1;
            bool ValidAcoount = false;
            for (int i = 0; i < Program.StudentIndex; i++)
            {
                if (Program.Students[i].Username == InputUsername)
                {
                    ValidAcoount = true;
                    if (Program.Students[i].Password == InputPassword)
                    {
                        Result = i;
                    }

                }
            }
            if (!ValidAcoount)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\nInvalid Account! Try again.");
            }
            else if (Result == -1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\nIncorrect password! Try again.");
            }
            Console.ForegroundColor = ConsoleColor.White;
            return Result;
        }
        //Homework
        public void HomeworkProcess (int StudentNumber)
        {
            Console.WriteLine($"Garden plants are:\n\n(1) Blue: {Program.Garden.BlueFlower} \n(2) Gray: {Program.Garden.GrayFlower} \n(3) Red: {Program.Garden.RedFlower} \n(4) Yellow: {Program.Garden.YellowFlower} \n(5) Green: {Program.Garden.GreenFlower} \n(6) Pink: {Program.Garden.PinkFlower} \n(7) Sunflower: {Program.Garden.SunFlower} ");

            string Chooseflower;
            int ChooseflowerInt = 0;
            while (1 == 1)
            {
                Console.WriteLine("--------------------\nChoose number of one of them for picking up");
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
            string HowMuch;
            int HowmuchInt = 0;
            while (1 == 1)
            {
                Console.WriteLine("How much? :");
                HowMuch = (Console.ReadLine());
                try
                {
                    HowmuchInt = Convert.ToInt32(HowMuch);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Please enter a number.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                if (HowmuchInt < 0)
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
                    Program.Students[StudentNumber].BlueFlower += HowmuchInt;
                    break;
                case 2:
                    Program.Students[StudentNumber].GrayFlower += HowmuchInt;
                    break;
                case 3:
                    Program.Students[StudentNumber].RedFlower += HowmuchInt;
                    break;
                case 4:
                    Program.Students[StudentNumber].YellowFlower += HowmuchInt;
                    break;
                case 5:
                    Program.Students[StudentNumber].GreenFlower += HowmuchInt;
                    break;
                case 6:
                    Program.Students[StudentNumber].PinkFlower += HowmuchInt;
                    break;
                case 7:
                    Program.Students[StudentNumber].SunFlower += HowmuchInt;
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nThe plants picked up successfuly.");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
