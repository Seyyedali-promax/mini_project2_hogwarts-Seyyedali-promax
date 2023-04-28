using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HogwartsProjects_hoseynzadeh
{
    class AuthorizedHuman : Human
    {
        //Variables
        public int BedroomNumber = -1;
        public string[][] LessonsSchedule;
        public enum GroupType { Hufflepuff = 1, Gryffindor, Ravenclaw, Slytherin }
        public string GroupName;
        public bool HaveBaggage = false;
        public enum Pet { Owl = 1, Cat, Rat }
        public enum Job { Teacher = 1, Student }
        public string[] Letters;
        //Methods
        // Number of teachers and students in file
        public int NumberOfStudentsInFile()
        {
            int Result = 0;
            using (StreamReader File = new StreamReader("file.tsv"))
            {
                string ln;
                while ((ln = File.ReadLine()) != null)
                {
                    string[] Human = ln.Split('\t').ToArray<string>();
                    if (Human[8] == "student")
                    { Result++; }
                }
                File.Close();
            }
            return Result;
        }
        public int NumberOfTeachersInFile()
        {
            int Result = 0;
            using (StreamReader File = new StreamReader("file.tsv"))
            {
                string ln;
                while ((ln = File.ReadLine()) != null)
                {
                    string[] Human = ln.Split('\t').ToArray<string>();
                    if (Human[8] == "teacher")
                    { Result++; }
                }
                File.Close();
            }
            return Result;
        }
        // Choosing role
        public int ChooseRole()
        {
            string ChooseRole;
            int ChooseRoleInt = 0;
            while (1 == 1)
            {
                Console.WriteLine("Hello! Welcome to Hogwarts school.\nChoose your role number and log in:\n(1) Dombledour\n(2) Teacher\n(3) Student\n(4) New Student\n--------------------");
                ChooseRole = (Console.ReadLine());
                try
                {
                    ChooseRoleInt = Convert.ToInt32(ChooseRole);
                }
                catch
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Please enter a number.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                if (ChooseRoleInt > 4 || ChooseRoleInt < 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Please enter a valid number.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                break;
            }
            return ChooseRoleInt;
        }
        //Goup determination
        public string RandomGroup(string x, int y)
        {
            int A = 15;
            byte[] Arr = Encoding.ASCII.GetBytes(x);
            foreach (byte e in Arr)
            {
                A = Convert.ToInt32(e);
            }
            Random rnd = new Random();
            int B = (rnd.Next(A + y + 14) % 4);
            switch (B)
            {
                case 0:
                    return "Gryffindor";
                case 1:
                    return "Ravenclaw";
                case 2:
                    return "Hufflepuff";
                case 3:
                    return "Slytherin";
                default:
                    return "Impossible!";
            }
        }
    }
}
