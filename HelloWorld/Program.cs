using System;

namespace HelloWorld
{
    class Student
    {
       public string[] name;
       public int[] age;
       public string[] major;
       public double[] gpa;
       public int num;
       public virtual void stuAssign()
        {
            Console.Write("How many students: ");
            num= Convert.ToInt32(Console.ReadLine());
            name = new string[num];
            age = new int[num];
            major = new string[num];
            gpa = new double[num];
            for (int i = 0; i < num; i++)
            {
                

                Console.WriteLine("For student " + (i + 1) + " please enter name:");
                name[i] = Console.ReadLine();
                Console.WriteLine("Enter age:");
                age[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter major:");
                major[i] = Console.ReadLine();
                Console.WriteLine("Enter GPA:");
                gpa[i] = Convert.ToDouble(Console.ReadLine());

            }
        }
        public virtual void stuOutput()
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine( name[i].ToUpper() + ":");
                Console.WriteLine("Age: " + age[i]);
                Console.WriteLine("Major: " + major[i]);
                Console.WriteLine("GPA: " + gpa[i]);
                Console.WriteLine("");

            }
        }
    }
    class Freshman : Student
    {
        public override void stuAssign()
        {
            Console.Write("How many Freshman students: ");
            num = Convert.ToInt32(Console.ReadLine()); 
            name = new string[num];
            age = new int[num];
            major = new string[num];
            gpa = new double[num];
            for (int i = 0; i < num; i++)
            {


                Console.WriteLine("For Freshman student " + (i + 1) + " please enter name:");
                name[i] = Console.ReadLine();
                Console.WriteLine("Enter age:");
                age[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter major:");
                major[i] = Console.ReadLine();
                Console.WriteLine("Enter GPA:");
                gpa[i] = Convert.ToDouble(Console.ReadLine());

            }
        }
        public override void stuOutput()
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine( name[i].ToUpper() + ":");
                Console.WriteLine("Age: " + age[i]);
                Console.WriteLine("Major: " + major[i]);
                Console.WriteLine("GPA: " + gpa[i]);
                Console.WriteLine("");

            }
        }
    }
    class Sophomore : Student
    {
        public override void stuAssign()
        {
            Console.Write("How many Sophomore students: ");
            num = Convert.ToInt32(Console.ReadLine());
            name = new string[num];
            age = new int[num];
            major = new string[num];
            gpa = new double[num];
            for (int i = 0; i < num; i++)
            {


                Console.WriteLine("For Sophomre student " + (i + 1) + " please enter name:");
                name[i] = Console.ReadLine();
                Console.WriteLine("Enter age:");
                age[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter major:");
                major[i] = Console.ReadLine();
                Console.WriteLine("Enter GPA:");
                gpa[i] = Convert.ToDouble(Console.ReadLine());

            }
        }
        public override void stuOutput()
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(name[i].ToUpper() + ":");
                Console.WriteLine("Age: " + age[i]);
                Console.WriteLine("Major: " + major[i]);
                Console.WriteLine("GPA: " + gpa[i]);
                Console.WriteLine("");
            }
        }
    }
    class Junior : Student
    {
        public override void stuAssign()
        {
            Console.Write("How many Junior students: ");
            num = Convert.ToInt32(Console.ReadLine());
            name = new string[num];
            age = new int[num];
            major = new string[num];
            gpa = new double[num];
            for (int i = 0; i < num; i++)
            {


                Console.WriteLine("For Junior student " + (i + 1) + " please enter name:");
                name[i] = Console.ReadLine();
                Console.WriteLine("Enter age:");
                age[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter major:");
                major[i] = Console.ReadLine();
                Console.WriteLine("Enter GPA:");
                gpa[i] = Convert.ToDouble(Console.ReadLine());

            }
        }
        public override void stuOutput()
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(name[i].ToUpper() + ":");
                Console.WriteLine("Age: " + age[i]);
                Console.WriteLine("Major: " + major[i]);
                Console.WriteLine("GPA: " + gpa[i]);
                Console.WriteLine("");
            }
        }
    }
    class Senior : Student
    {
        public override void stuAssign()
        {
            Console.Write("How many Senior students: ");
            num = Convert.ToInt32(Console.ReadLine());
            name = new string[num];
            age = new int[num];
            major = new string[num];
            gpa = new double[num];
            for (int i = 0; i < num; i++)
            {


                Console.WriteLine("For Senior student " + (i + 1) + " please enter name:");
                name[i] = Console.ReadLine();
                Console.WriteLine("Enter age:");
                age[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter major:");
                major[i] = Console.ReadLine();
                Console.WriteLine("Enter GPA:");
                gpa[i] = Convert.ToDouble(Console.ReadLine());

            }
        }
        public override void stuOutput()
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(name[i].ToUpper() + ":");
                Console.WriteLine("Age: " + age[i]);
                Console.WriteLine("Major: " + major[i]);
                Console.WriteLine("GPA: " + gpa[i]);

            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        { 
            Student fstu = new Freshman();
            fstu.stuAssign();
            Student sstu = new Sophomore();
            sstu.stuAssign();
            Student jstu = new Junior();
            jstu.stuAssign();
            Student s_stu = new Senior();
            s_stu.stuAssign();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Thank you! Here are the results:");
            Console.WriteLine("______________");
            Console.WriteLine("FRESHMEN:");
            fstu.stuOutput();
            Console.WriteLine("______________");
            Console.WriteLine("SOPHOMORE:");
            sstu.stuOutput();
            Console.WriteLine("______________");
            Console.WriteLine("JUNIOR:");
            jstu.stuOutput();
            Console.WriteLine("______________");
            Console.WriteLine("Senior:");
            s_stu.stuOutput();
            




        }
    }
}
