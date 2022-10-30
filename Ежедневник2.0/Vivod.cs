using System.Collections;
using System;
using System.Reflection.PortableExecutable;
using System.Text;

public class Employee
{

    public static string Time1 { get; set; }
    public string State { get; set; }
    public string BigState { get; set; }
    public string Time { get; set; }
    public Employee() { }
    public void WriteEmployee()
    {
        using (StreamWriter sw = File.AppendText("EJEVNEVNIC.txt"))
        {
            sw.WriteLine(this.State);
            sw.WriteLine(this.BigState);
            sw.WriteLine(this.Time);
        }
    }
    public static void DisplayEmployee(string name)
    {
        using (StreamReader sr = File.OpenText("EJEVNEVNIC.txt"))
        {
            string Name = null;
            string below = Time1;
            int count = System.IO.File.ReadAllLines("EJEVNEVNIC.txt").Length;
            string[] NewFile = File.ReadAllLines("EJEVNEVNIC.txt");
            for (int i = 1; i < count; i += 1)
            {
                int a = i;
                string line = File.ReadLines("EJEVNEVNIC.txt").Skip(a).Take(1).First();
                /*Console.WriteLine("  " + a / 3 + ". " + line);*/
                string b = (line);
                /*Console.WriteLine(b);*/
                string temp;
                /*Console.WriteLine(b);
                Console.Read();*/
                if (b == below)
                {
                    /*Console.Clear();
                    Console.WriteLine(b);
                    Console.Read();*/
                    for (int i1 = 1; i1 < count; i1 += 2)
                    {
                        /*Console.Clear();*/
                        string sline = File.ReadLines("EJEVNEVNIC.txt").Skip(a).Take(1).First();
                        /*Console.WriteLine(sline);*/
                        /*Console.Read();*/
                        /*int a1 = i1;
                        string nameline = File.ReadLines("EJEVNEVNIC.txt").Skip(a1).Take(1).First();
                        Console.WriteLine("  " + a1 / 3 + ". " + nameline);*/
                        /* temp = sr.ReadLine();
                         if (temp.Contains(Time1))
                         {
                         temp += "\n__________" + sr.ReadLine() + "__________\n";    
                         temp += "\n__________" + sr.ReadLine() + "__________\n";
                          Console.WriteLine("         "+temp);
                         }*/

                    }
                }
            }
        }
    }
    public static void LIST()
    {
       
    }
}
/*using System.Reflection.PortableExecutable;

public class Employee
{
    public string Time;
    public static string Time1 { get; set; }

    public string State { get; set; }

    public string BigState { get; set; }
    public Employee() { }
    public void WriteEmployee()
    {
        using (StreamWriter sw = File.AppendText("EJEVNEVNIC.txt"))
        {
            sw.WriteLine(this.State);
            sw.WriteLine(this.BigState);
            sw.WriteLine(this.Time);
        }
    }
    public static void DisplayEmployee(string name)
    {
        using (StreamReader sr = File.OpenText("EJEVNEVNIC.txt"))
        {
            string Name = null;

            while ((Name = sr.ReadLine()) != name && Name != null) ;
            if (Name == name)
            {
                Console.WriteLine("заметка: ");
                Console.WriteLine(String.Format("ТЕкст заметки  : " + sr.ReadLine()));
                Console.WriteLine(String.Format("Время: \n" + sr.ReadLine()));

            }
            int count = System.IO.File.ReadAllLines("EJEVNEVNIC.txt").Length;
            string[] NewFile = File.ReadAllLines("EJEVNEVNIC.txt");
            for (int i = 0; i < count; i += 3)
            {
                if (Name.Contains(d))
                {
                    int a = i;
                    string line = File.ReadLines("EJEVNEVNIC.txt").Skip(a).Take(1).First();
                    Console.WriteLine("  " + a / 3 + ". " + line);
                }


            }
            string below = Time1;
            int count = System.IO.File.ReadAllLines("EJEVNEVNIC.txt").Length;
            string[] NewFile = File.ReadAllLines("EJEVNEVNIC.txt");
            for (int i = 2; i < count; i += 1)
            {


                int a = i;
                string line = File.ReadLines("EJEVNEVNIC.txt").Skip(a).Take(1).First();
                Console.WriteLine("  " + a / 3 + ". " + line);
                string b = (line);
                string temp;
                if (b == below)
                {
                    string nameline = File.ReadLines("EJEVNEVNIC.txt").Skip(a).Take(2).First();
                    Console.WriteLine(nameline);


                    temp = sr.ReadLine();
                    if (NewFile.Contains(Time1))
                    {
                        temp += sr.ReadLine() + "\n";
                        temp += sr.ReadLine() + "\n";
                        temp += sr.ReadLine() + "\n";
                        Console.WriteLine(temp);

                    }
                }
                if (b == below)
                {


                    Console.WriteLine("  " + i / 3 + ". " + b);
                    string temp;
                    while (true)
                    {
                        temp = sr.ReadLine();
                        if (NewFile.Contains(Time1))
                        {
                            temp += sr.ReadLine() + "\n";
                            temp += sr.ReadLine() + "\n";
                            Console.WriteLine(temp);

                        }
                    }
                    Console.WriteLine("  заметка: ");
                    Console.WriteLine(String.Format("  ТЕкст заметки  : " + sr.ReadLine()));
                    Console.WriteLine(String.Format("  Время: \n" + sr.ReadLine()));

                }
                if (NewFile.Contains(below))
                {
                    Console.WriteLine(b);
                    Console.WriteLine("  " + a / 3 + ". " + line);
                }



            }


            string fileText = File.ReadAllText("EJEVNEVNIC.txt");
            if (fileText.Contains("20.10.2022"))
            {
                Console.WriteLine("ПСИХ Присутсвует в тексте");

            }

            else
            {
                Console.WriteLine("блаблабла НЕ НАЙДЕН");
            }



            string line = File.ReadLines("EJEVNEVNIC.txt").Skip(4).Take(1).First();
            Console.WriteLine(line);

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(String.Format(sr.ReadLine()));
            }
        }
    }

}*/