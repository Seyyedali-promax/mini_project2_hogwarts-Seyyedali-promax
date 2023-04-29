using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace HogwartsProjects_hoseynzadeh
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static Instances and variables
            //Variables
            int StudentIndex = 0;
            int TeacherIndex = 0;
            // Instances from things
            Dombledour ManagerIns = new Dombledour();
            Teacher[] TeacherIns = new Teacher[10000];
            Student[] StudentIns = new Student[10000];
            Group Hufflepuff = new Group();
            Group Gryffindor = new Group();
            Group Rawenclaw = new Group();
            Group Slytherin = new Group();
            Plants PlantIns = new Plants();
            //
            Dorm[] DormsIns = new Dorm[9];
            for (int i = 0; i < 9; i++)
            {
                DormsIns[i] = new Dorm();
            }
            //Reading file
            //Define person by person instances
            for (int i = 0; i < 10000; i++)
            {
                TeacherIns[i] = new Teacher();
            }
            for (int i = 0; i < 10000; i++)
            {
                StudentIns[i] = new Student();
            }
            // Giving information from file.tsv
            using (StreamReader File = new StreamReader("file.tsv"))
            {
                string ln;
                while ((ln = File.ReadLine()) != null)
                {
                    string[] Human = ln.Split('\t').ToArray<string>();
                    if (Human[8] == "teacher")
                    {
                        TeacherIns[TeacherIndex].Name = Human[0];
                        TeacherIns[TeacherIndex].Family = Human[1];
                        TeacherIns[TeacherIndex].Birthyear = Convert.ToInt32(Human[2][0] + Human[2][1] + Human[2][2] + Human[2][3]);
                        if (Human[3] == "male")
                        {
                            TeacherIns[TeacherIndex].IsHeMale = true;
                        }
                        if (Human[3] == "female")
                        {
                            TeacherIns[TeacherIndex].IsHeMale = false;
                        }
                        TeacherIns[TeacherIndex].NameOfFather = Human[4];
                        TeacherIns[TeacherIndex].Username = Human[5];
                        TeacherIns[TeacherIndex].Password = Human[6];
                        TeacherIns[TeacherIndex].Blood = Human[7];
                        TeacherIns[TeacherIndex].GroupName = ManagerIns.RandomGroup(Human[6], TeacherIndex);
                        TeacherIns[TeacherIndex].HaveBaggage = true;
                        TeacherIndex++;

                    }
                    else if (Human[8] == "student")
                    {
                        StudentIns[StudentIndex].Name = Human[0];
                        StudentIns[StudentIndex].Family = Human[1];
                        StudentIns[StudentIndex].Birthyear = Convert.ToInt32(Human[2][0] + Human[2][1] + Human[2][2] + Human[2][3]);
                        if (Human[3] == "male")
                        {
                            StudentIns[StudentIndex].IsHeMale = true;
                        }
                        if (Human[3] == "female")
                        {
                            StudentIns[StudentIndex].IsHeMale = false;
                        }
                        StudentIns[StudentIndex].NameOfFather = Human[4];
                        StudentIns[StudentIndex].Username = Human[5];
                        StudentIns[StudentIndex].Password = Human[6];
                        StudentIns[StudentIndex].Blood = Human[7];
                        StudentIns[StudentIndex].GroupName = ManagerIns.RandomGroup(Human[6], StudentIndex);
                        StudentIns[StudentIndex].HaveBaggage = true;
                        StudentIns[StudentIndex].BedroomNumber = DormsIns[1].DetDorm(DormsIns, StudentIns[StudentIndex].GroupName, StudentIns[StudentIndex].IsHeMale);
                        DormsIns[DormsIns[1].GroupDormForPlus(StudentIns[StudentIndex].GroupName, StudentIns[StudentIndex].IsHeMale)].CompletedCapacity++;
                        StudentIns[StudentIndex].term = 3;
                        StudentIns[StudentIndex].PassedCourses[0] = "Sport";
                        StudentIns[StudentIndex].PassedCourses[1] = "Magicology";
                        StudentIns[StudentIndex].PassedCoursesNumber = StudentIns[StudentIndex].PassedCourses.Length;
                        //Console.WriteLine(StudentIns[StudentIndex].DormNumber);
                        StudentIndex++;
                    }
                }
                File.Close();
            }
            //END OF STATIC WORKS
            //RUN PROGRAM
            while (1 == 1)
            {
                // Choose Role 1 Dombledour 2 Teacher 3 Student
                int Role = ManagerIns.ChooseRole();

                //Dombledour
                if (Role == 1)
                {
                    // Choose Process
                    int WhichProcess = ManagerIns.WhichProcess();
                    //1 Student 2 Plant
                    if (WhichProcess == 1)
                    {
                        StudentIns = ManagerIns.StudentProcess(StudentIns);
                    }
                    else if (WhichProcess == 2)
                    {
                        PlantIns = ManagerIns.PlantsProccess(PlantIns);
                    }
                }

                //Teacher
                if (Role == 2)
                {
                    int WhichTeacher = TeacherIns[0].Whichone(TeacherIns, TeacherIndex);
                    if (WhichTeacher == -1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("User account not found!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    //Logged in successfully
                    else
                    {
                        // Choose Process
                        int WhichProcess = TeacherIns[0].WhichProcess();
                        //1 Himself 2 Student 3 Exit
                        if (WhichProcess == 1)
                        {
                            TeacherIns[WhichTeacher] = TeacherIns[WhichTeacher].TeacherProccess(TeacherIns[WhichTeacher]);
                            Console.Clear();
                        }
                        else if (WhichProcess == 2)
                        {
                            Console.Clear();
                        }
                        //Withiut any special process
                        else if (WhichProcess == 3)
                        {
                            Console.Clear();
                        }
                    }
                }

                //Student
                if (Role == 3)
                {
                    int WhichStudent = StudentIns[0].Whichone(StudentIns, StudentIndex);
                    if (WhichStudent == -1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("User account not found!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    //Logged in successfully 
                    else
                    {
                        // Choose Process
                        int WhichProcess = StudentIns[0].WhichProcess();
                        //1 Himself 2 Manager 3 Plants 4 Choose lessons 5 Exit
                        if (WhichProcess == 1)
                        {
                            StudentIns[WhichStudent] = StudentIns[WhichStudent].StudentProccess(StudentIns[WhichStudent]);
                            Console.Clear();
                        }
                        else if (WhichProcess == 2)
                        {
                            ManagerIns = StudentIns[WhichStudent].ManagerProccess(ManagerIns);
                            Console.Clear();
                        }
                        else if (WhichProcess == 3)
                        {
                            Plants PlantBackup = PlantIns;
                            PlantIns = StudentIns[WhichStudent].PlantProcess(PlantIns);
                            StudentIns[WhichStudent] = StudentIns[WhichStudent].HomeworkProcess(PlantBackup, PlantIns, StudentIns[WhichStudent]);
                            Console.Clear();
                        }
                        //Without any special process
                        else if (WhichProcess == 4)
                        {
                            Console.Clear();
                        }
                    }
                }

                // New student
                if (Role == 4)
                {

                }
            }
        }
    }
}
