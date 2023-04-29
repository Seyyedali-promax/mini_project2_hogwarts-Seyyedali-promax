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
        public string[] PassedCourses = new string[1000];
        public string[] TermCourses = new string[1000];
        public int term = 1;
        public int PassedCoursesNumber = 0;
        public string[] TeachersOfStudent = new string[1000];
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
                Console.WriteLine("--------------------\nWhat do you want? :\n(1) I want do my personal works.\n(2) I want communicate with Dombledour.\n(3) I want Picking the plants.\n(4) I want choose my lessons\n (5) Exit\n--------------------");
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
        public Student StudentProccess(Student x,Teacher[] Teachers)
        {
            string ChooseLesson;
            int ChooseLessonInt = 0;
            while (1 == 1)
            {
                Console.WriteLine("--------------------\nWhat you want learn?\n(1) Sport \n(2) Chimistry \n(3) Magicology \n(4) Phyology\n--------------------");
                ChooseLesson = (Console.ReadLine());
                try
                {
                    ChooseLessonInt = Convert.ToInt32(ChooseLesson);
                }
                catch
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Please enter a number.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                if (ChooseLessonInt > /*Important when adding option*/  4 || ChooseLessonInt < 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Please enter a valid number.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                break;
            }
            switch (ChooseLessonInt)
            {
                case 1:
                    x.TeachingLesson = "Sport";
                    x.LessonsSchedule[ChooseDateInt] = "Sport";
                    break;
                case 2:
                    x.TeachingLesson = "Chimistry";
                    x.LessonsSchedule[ChooseDateInt] = "Chimistry";
                    break;
                case 3:
                    x.TeachingLesson = "Magicology";
                    x.LessonsSchedule[ChooseDateInt] = "Magicology";
                    break;
                case 4:
                    x.TeachingLesson = "Phytology";
                    x.LessonsSchedule[ChooseDateInt] = "Phytology";
                    break;
            }
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
