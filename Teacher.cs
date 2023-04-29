using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogwartsProjects_hoseynzadeh
{
    class Teacher : AuthorizedHuman
    {
        public bool TeachSameTime = false;
        public string[] ClassStudents = new string[1000];
        public string TeachingLesson;
        public string TeachingDay;
        public int Whichone(Teacher[] List, int Number)
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
        //
        public int WhichProcess()
        {
            string ChooseProcess;
            int ChooseProcessInt = 0;
            while (1 == 1)
            {
                Console.WriteLine("--------------------\nWhat do you want? :\n(1) Cange my classes Schedule \n(2) Grading Student \n(3) Exit\n--------------------");
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

            string ChooseProcess;
            int ChooseProcessInt = 0;
            while (1 == 1)
            {
                Console.WriteLine("--------------------\nCan you teach with another teacher in same time?\n(1) Yes (2) No\n--------------------");
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
                if (ChooseProcessInt > /*Important when adding option*/  2 || ChooseProcessInt < 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Please enter a valid number.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                break;
            }
            if (ChooseProcessInt == 1)
            {
                x.TeachSameTime = true;
            }
            else
            {
                x.TeachSameTime = false;
            }
            //
            string ChooseDate;
            int ChooseDateInt = 0;
            while (1 == 1)
            {
                Console.WriteLine("--------------------\nWhich day you can teach?\n(1) Saturday \n(2) Sunday \n(3) Monday \n(4) Thusday \n(5) Wednesday\n--------------------");
                ChooseDate = (Console.ReadLine());
                try
                {
                    ChooseDateInt = Convert.ToInt32(ChooseDate);
                }
                catch
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Please enter a number.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                if (ChooseDateInt > /*Important when adding option*/  5 || ChooseDateInt < 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Please enter a valid number.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                break;
            }
            switch (ChooseDateInt)
            {
                case 1:
                    x.TeachingDay = "Saturday";
                    break;
                case 2:
                    x.TeachingDay = "Sunday";
                    break;
                case 3:
                    x.TeachingDay = "Monday";
                    break;
                case 4:
                    x.TeachingDay = "Thusday";
                    break;
                case 5:
                    x.TeachingDay = "Wednesday";
                    break;
            }
            string ChooseLesson;
            int ChooseLessonInt = 0;
            while (1 == 1)
            {
                Console.WriteLine("--------------------\nWhat you can teach?\n(1) Sport \n(2) Chimistry \n(3) Magicology \n(4) Phyology\n--------------------");
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
    }
}
