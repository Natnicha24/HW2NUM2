using System;

namespace HW3_num2
{
    /*โปรแกรมลงทะเบียนกิจกรรม โดยทุกคนจะต้องกรอกข้อมูลชื่อ คณะ อีเมลล์ แต่ถ้าเป็นนักเรียนจะต้องกรอก ID และ จำนวนชั่วโมงกิจกรรมที่ตนมีอยู่ และเมื่อลงทะเบียน นักเรียนจะได้จำนวนกิจกรรมเพิ่ม3ชั่วโมง
     * แต่ถ้าเป็นครูจะไม่ได้ชั่วโมงกิจกรรมโปรแกรมนี้จะสามารถเรียกดูลิสต์เฉพาะนักเรียน ครู หรือดูทั้งครูและนักเรียนก็ได้*/
    enum Menu
    {
        Student = 1,
        Teacher,
        GetListStudent,
        GetListTeacher,
        GetListPersons
    }
    class Program
    {
        static Personlist personlist;
        static Studentlist studentlist;
        static Teacherlist teacherlist;
        static void Main(string[] args)
        {
            PreparePersonListWhenProgramIsLoad();
            PrintMenuScreen();
        }
        static void PreparePersonListWhenProgramIsLoad()
        {
            Program.personlist = new Personlist();/*สร้างพื้นที่สแตกก่อนเริ่มโปรแกรม*/
            Program.studentlist = new Studentlist();
            Program.teacherlist = new Teacherlist();

        }
        static void PrintMenuScreen()
        {
            Console.Clear();
            PrintHeader();
            PrintListMenu();
            InputMenu();
        }
        static void PrintHeader()
        {
            Console.WriteLine("ACTIVITY REGISTER");
            Console.WriteLine("------------------");
        }
        static void PrintListMenu()
        {
            Console.WriteLine("1.Student");
            Console.WriteLine("2.Teacher");
            Console.WriteLine("3.Get List Students");
            Console.WriteLine("4.Get List Teachers");
            Console.WriteLine("5.Get List Persons");
        }
        static void InputMenu()
        {
            Console.Write("You are : ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            GoToMenu(menu);

        }
        static void GoToMenu(Menu menu)
        {
            if (menu == Menu.Student/*Enum*/)
            {
                ShowInputStudentScreen();/*ไปscreenใหม่*/
            }
            else if (menu == Menu.Teacher/*enum*/)
            {
                ShowInputTeacherScreen();
            }
            else if (menu == Menu.GetListStudent)
            {
                ShowGetListStudentScreen();
            }
            else if (menu == Menu.GetListTeacher)
            {
                ShowGetListTeacherScreen();
            }
            else if (menu == Menu.GetListPersons)
            {
                ShowGetListPersonScreen();
            }
        }
        static void ShowInputStudentScreen()
        {
            Console.Clear();
            PrintHeaderInputStudentScreen();
            InputStudentInformation();
            PrintMenuScreen();
        }
        static void PrintHeaderInputStudentScreen()
        {
            Console.WriteLine("Input Student Information");
            Console.WriteLine("-------------------------");
        }
        static void InputStudentInformation()
        {
            Student student = CreateNewStudent();
            Program.personlist.AddNewPerson(student);
            Program.studentlist.AddNewStudent(student);
        }
        static Student CreateNewStudent()
        {
            return new Student(InputName(), InputMajor(), InputID(), InputEmail(),InputActivityHour());
        }
      
        static string InputName()
        {
            Console.Write("Name: ");

            return Console.ReadLine();
        }
        static string InputMajor()
        {
            Console.Write("Major: ");

            return Console.ReadLine();
        }
        static string InputEmail()
        {
            Console.Write("Email: ");

            return Console.ReadLine();
        }
        static string InputID()
        {
            Console.Write("ID:");

            return Console.ReadLine();
        }
        static int InputActivityHour()
        {
            Console.Write("Your Old Activity Hour:");

            return int.Parse(Console.ReadLine());
        }
        static void ShowInputTeacherScreen()
        {
            Console.Clear();
            PrintHeaderInputTeacherScreen();
            InputTeacherInformation();
            PrintMenuScreen();
        }
        static void PrintHeaderInputTeacherScreen()
        {
            Console.WriteLine("Input Teacher Information");
            Console.WriteLine("-------------------------");
        }
        static void InputTeacherInformation()
        {
            Teacher teacher = CreateNewTeacher();
            Program.personlist.AddNewPerson(teacher);
            Program.teacherlist.AddNewTeacher(teacher);
        }
        static Teacher CreateNewTeacher()
        {
            return new Teacher(InputName(), InputMajor(), InputEmail(),0);
        }
        static void ShowGetListPersonScreen()
        {
            Console.Clear();
            Program.personlist.FetchPersonList();
            InputExistFromKeyboard();
        }

            static void InputExistFromKeyboard()
            {
                string text = "";
                Console.Write("\nPress exit to end program & Press any key to back to Menu : ");
                text = Console.ReadLine();
                if (text == "exit")
                {
                 Console.WriteLine();
                }
                else
                {
                  Console.Clear();
                  PrintMenuScreen();
                }
               
            }


        static void ShowGetListStudentScreen()
        {
            Console.Clear();
            Program.studentlist.FetchStudentList();
            InputExistFromKeyboard();
        }
        static void ShowGetListTeacherScreen()
        {
            Console.Clear();
            Program.teacherlist.FetchTeacherList();
            InputExistFromKeyboard();
        }
    }
    }
