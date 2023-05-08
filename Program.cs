using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwartz_hoseynzadeh2
{
    static class Program
    {
        public static Manager Dombledour = new Manager();
        public static Teacher[] Teachers = new Teacher[1000];
        public static Student[] Students = new Student[1000];
        public static Plants Garden = new Plants();
        public static Group[] Groups = new Group[4];
        public static ProjectMethodsLibrary MyMethods = new ProjectMethodsLibrary();
        public static int TeacherIndex = 0, StudentIndex = 0;
        public static Group Gryffindor = new Group();
        public static Group Hufflepuff = new Group();
        public static Group Ravenclaw = new Group();
        public static Group Slytherin = new Group();
        public static List<Lesson> Cources;
        public static int GryffindorMaleDormMembers = 0, HufflepuffMaleDormMembers = 0, RavenclawMaleDormMembers = 0, SlytherinMaleDormMembers = 0, GryffindorFemaleDormMembers = 0, HufflepuffFemaleDormMembers = 0, RavenclawFemaleDormMembers = 0, SlytherinFemaleDormMembers = 0;

        static void Main(string[] args)
        { 
            //Definitions
            for (int i = 0; i < 1000; i++)
            {
                Students[i] = new Student();
                Teachers[i] = new Teacher();
            }
            Gryffindor.Groupname = "Gryffindor";
            Hufflepuff.Groupname = "Hufflepuff";
            Slytherin.Groupname = "Slytherin";
            Ravenclaw.Groupname = "Ravenclaw";
            //ReadingFile
            MyMethods.ReadingFile();
            //UI
            while (1 == 1)
            {
                //Console.Clear();
                //RUN PROGRAM
                //Choose Role
                string[] Roles = new string[4] { "Dombledour", "Teacher", "Student", "New Student" };
                int Role = MyMethods.Choise(Roles, "Hello! Who are you?");
                switch (Role)
                {
                    //Dombledour Actions
                    case 1:
                        if (Dombledour.Login())
                        {
                            bool Exit = false;
                            Console.Clear();
                            while (!Exit)
                            {
                                switch (MyMethods.Choise(Dombledour.Actions, "welcome Dombledour! What do You want?"))
                                {
                                    case 1:
                                        Dombledour.LetterProcess();
                                        break;

                                    case 2:
                                        Dombledour.PlantProcess();
                                        break;
                                    case 3:
                                        Exit = true;
                                        break;
                                }
                            }
                        }
                        break;


                    //Teacher Actions
                    case 2:
                        int TeacherLoginNumber = Teachers[0].Login();
                        break;


                    //Student Actions
                    case 3:
                        int StudentLoginNumber= Students[0].Login();
                        if (StudentLoginNumber != -1)
                        {
                            bool Exit = false;
                            Console.Clear();
                            while (!Exit)
                            {
                                if (Students[StudentLoginNumber].IsHeInHogwartz == false)
                                {
                                    Students[StudentLoginNumber].Actions = new string[4] { "Read my letters", "Request a ticket.", "Boarding the train.", "Exit" };
                                }
                                else
                                {
                                    Students[StudentLoginNumber].Actions = new string[6] { "Read my letters.", "Request a ticket.", "Boarding the Train.", "Exit", "Choose my Courses.", "Doing my phytology homeworks." };
                                }
                                switch (MyMethods.Choise(Students[StudentLoginNumber].Actions, $"welcome {Students[StudentLoginNumber].Name} {Students[StudentLoginNumber].Family}! What do You want?"))
                                {
                                    case 1:
                                        MyMethods.showList(Students[StudentLoginNumber].Letters, $"Hello! I.m your {Students[StudentLoginNumber].pet}. Your letters are:");
                                        Students[StudentLoginNumber].Letters.Clear();
                                        break;
                                    case 2:
                                        Students[StudentLoginNumber].LetterProcess(StudentLoginNumber);
                                        break;
                                    case 3:
                                        if (Students[StudentLoginNumber].Ticket)
                                        {
                                            Students[StudentLoginNumber].Ticket = false;
                                            Students[StudentLoginNumber].IsHeInHogwartz = true;
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("\n\nYou are in the train!");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\n\nYou haven't any ticket!");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        break;
                                    case 4:
                                        Exit = true;
                                        break;
                                    case 5:
                                        ////////////////
                                        break;
                                    case 6:
                                        Students[StudentIndex].HomeworkProcess(StudentLoginNumber);
                                        break;
                                }
                            }
                        }
                        break;
                    //Add new student
                    case 4:
                        //Students
                        break;

                }

            }
        }
    }
}