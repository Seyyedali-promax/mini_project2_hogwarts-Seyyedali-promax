using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogwartsProjects_hoseynzadeh
{
    class Teacher : AuthorizedHuman
    {
        bool TeachSameTime;
        public int Whichone(Teacher[] List,int Number)
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
        public int WhichProcess()
        {
            string ChooseProcess;
            int ChooseProcessInt = 0;
            while (1 == 1)
            {
                Console.WriteLine("What do you want? :\n(1) \n(2) \n(3) Exit\n--------------------");
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
                if (ChooseProcessInt > /*Important when adding option*/  3 || ChooseProcessInt < 1)
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
        public Teacher TeacherProccess(Teacher x)
        {
            Console.WriteLine("Hi!");
            return x;
        }
    }
}
