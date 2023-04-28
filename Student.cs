using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogwartsProjects_hoseynzadeh
{
    class Student : AuthorizedHuman
    {
        // His Information
        public string[] PassedCourses = { };
        public int term = 1;
        public int DormNumber = -1;
        // His Plants
        public int BlueFlower = 0;
        public int GrayFlower = 0;
        public int RedFlower = 0;
        public int YellowFlower = 0;
        public int GreenFlower = 0;
        public int PinkFlower = 0;
        public int SunFlower = 0;

        // Methods

        //Log in
        public int Whichone(Student[] List, int Number)
        {
            int Result = -1;
            Console.WriteLine("What is your username?");
            string InUsername = Console.ReadLine();
            for (int i = 0; i < Number; i++)
            {
                if (List[i].Username == InUsername)
                {
                    Console.WriteLine("Enter your password:");
                    string InPassword = Console.ReadLine();
                    if (InPassword == List[i].Password)
                    {
                        Result = i;
                        return Result;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Password is incorrect.\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            return Result;
        }
        // Choose Proccess
        public int WhichProcess()
        {
            string ChooseProcess;
            int ChooseProcessInt = 0;
            while (1 == 1)
            {
                Console.WriteLine("What do you want? :\n(1) I want do my personal works.\n(2) I want communicate with Dombledour.\n(3) I want Picking the plants.\n(4) I want choose my lessons\n (5) Exit\n--------------------");
                ChooseProcess = (Console.ReadLine());
                try
                {
                    ChooseProcessInt = Convert.ToInt32(ChooseProcess);
                }
                catch
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Please enter a number.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                if (ChooseProcessInt > /*Important when adding option*/  5 || ChooseProcessInt < 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Please enter a valid number.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                break;
            }
            return ChooseProcessInt;
        }
        // Proccess related to classes
        public Student StudentProccess(Student x)
        {
            return x;
        }
        public Dombledour ManagerProccess(Dombledour x)
        {
            return x;
        }
        public Plants PlantProcess(Plants x)
        {
            return x;
        }
        public Student HomeworkProcess(Plants x, Plants y, Student z)
        {
            return z;
        }
        // Determine dorm
    }
}
