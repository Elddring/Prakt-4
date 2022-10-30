/*using System;
using System.Data;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Практическая_работа_4
{
    internal class Program
    {
        public static ConsoleKeyInfo zaeb;
        public static DateTime date_0 = new DateTime(2022, 07, 14);
        public static DateTime date_1 = new DateTime(2022, 07, 14);
        public static int position = 2;
        public static int a = 0;
        static void Main(string[] args)
        {
            Switching();
        }
        static void List_0_1()
        {
            DateTime f = new DateTime(2022, 07, 14);
            List<string> zametki = new List<string>();
            zametki.Add("Погулять с собакой");
            zametki.Add("Помыть посуду");
            zametki.Add("Сходить в магазин");
            zametki.Add("Протереть пыль");
            zametki.Add("Погулять");

            List<string> podzametki = new List<string>();
            podzametki.Add("Погулять с собакой вечером");
            podzametki.Add("Помыть посуду до приезда мамы");
            podzametki.Add("Купить водку и пиво");
            podzametki.Add("Протереть пыль у себя в комнате");
            podzametki.Add("Позвонить Диме");
            if (zaeb.Key == ConsoleKey.V)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выберите дату для добавления заметки");
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("Выбрана дата: " + date_0);
                zaeb = Console.ReadKey();
                a = 2;
                Switching_1();
                Console.WriteLine("Введите заголовок заметки");
                string vvod_0 = Console.ReadLine();
                zametki.Add(vvod_0);
                Console.WriteLine("Введите описание заметки");
                string vvod_1 = Console.ReadLine();
                podzametki.Add(vvod_1);
                Console.WriteLine("Ура! Вы добавили новую заметку. Нажмите любую клавишу для выхода");
                zaeb = Console.ReadKey();
                Console.Clear();
                Switching();
            }

            *//*if (date == f)
            {
            Console.WriteLine(zametki[0] + "\n" + zametki[1]);
            for (int i = 1; i < zametki.Count; i++)
            {
            Console.WriteLine(" " + i + ". " + zametki[i]);
            if (Regex.IsMatch(i.ToString(), @"[1-9]"))
            {
            int b = 1;
            b++;
            Console.WriteLine(b);
            }
            }
            }*//*

        }
        static void lol()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("\r" + new string(' ', 100));
        }
        static void Switching()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Выбрана дата: " + date_0);
            Console.WriteLine("Чтобы добавить заметку нажмите кнопку v");
            do
            {
                
                if (zaeb.Key == ConsoleKey.LeftArrow | zaeb.Key == ConsoleKey.RightArrow)
                {
                    a = 1;
                    Switching_1();
                }
                if (zaeb.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(0, position--);
                    Console.Write("->");
                }
                else if (zaeb.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(0, position++);
                    Console.Write("->");
                }
                if (zaeb.Key == ConsoleKey.V)
                {
                    List_0_1();
                }
                Console.Write("\r" + new string(' ', 2));
                Console.SetCursorPosition(0, position);
                Console.Write("->");
                if (zaeb.Key == ConsoleKey.Escape)
                {
                    return;
                }
                zaeb = Console.ReadKey();
            } while (true);
        }
        static void Switching_1()
        {
            do
            {
                
                if (zaeb.Key == ConsoleKey.LeftArrow)
                {
                    
                    if (a == 1)
                    {
                        Console.SetCursorPosition(0, 0);
                        date_0 = date_0.AddDays(-1);
                        Console.Write("Выбрана дата: " + date_0);
                        Console.SetCursorPosition(0, 1);
                        Console.WriteLine("Чтобы добавить заметку нажмите кнопку v");
                        Console.Write("\r" + new string(' ', 100));
                        Console.SetCursorPosition(0, position);
                        Console.Write("->");
                    }
                    if (a == 2)
                    {
                        Console.SetCursorPosition(0, 1);
                        date_0 = date_0.AddDays(-1);
                        Console.WriteLine("Выбрана дата: " + date_0);
                        Console.SetCursorPosition(0, 1);
                        Console.WriteLine("Чтобы добавить заметку нажмите кнопку v");
                        Console.Write("\r" + new string(' ', 100));

                    }
                }
                if (zaeb.Key == ConsoleKey.RightArrow)
                {
                    if (a == 1)
                    {
                        Console.SetCursorPosition(0, 0);
                        date_0 = date_0.AddDays(-1);
                        Console.WriteLine("Выбрана дата: " + date_0);
                        Console.SetCursorPosition(0, 1);
                        Console.WriteLine("Чтобы добавить заметку нажмите кнопку v");
                        Console.Write("\r" + new string(' ', 100));
                        Console.SetCursorPosition(0, position);
                        Console.Write("->");
                    }
                    if (a == 2)
                    {
                        Console.SetCursorPosition(0, 1);
                        date_0 = date_0.AddDays(+1);
                        Console.WriteLine("Выбрана дата: " + date_0);
                        Console.SetCursorPosition(0, 1);
                        Console.WriteLine("Чтобы добавить заметку нажмите кнопку v");
                        Console.Write("\r" + new string(' ', 100));
                    }
                }
                if (zaeb.Key == ConsoleKey.V)
                {
                    List_0_1();
                }
                if (zaeb.Key == ConsoleKey.UpArrow | zaeb.Key == ConsoleKey.DownArrow)
                {
                    if (a == 1)
                    {
                        Switching();
                    }
                }
                if (zaeb.Key == ConsoleKey.Escape)
                {
                    return;
                }
                zaeb = Console.ReadKey();
            } while (zaeb.Key != ConsoleKey.Enter);
        }
    }
}*/


/*namespace Практическая_работа_4
{
    internal class Program
    {
        public static class List_0
        {

        }
        public static ConsoleKeyInfo zaeb;
        public static DateTime date = new DateTime(2022, 07, 14);
        static void Main(string[] args)
        {
            Switching();
        }
        static void List_0_1()
        {
            DateTime f = new DateTime(2022, 07, 14);
            DateTime d = new DateTime(2022, 07, 18);
            List<string> zametki = new List<string>();
            zametki.Add("  1. Погулять с собакой");
            zametki.Add("  2. Помыть посуду");
            zametki.Add("  1. Сходить в магазин");
            zametki.Add("  2. Протереть пыль");
            zametki.Add("  1. Погулять");
            if (date == f)
            {
                Console.WriteLine(zametki[0] + "\n" + zametki[1]);
            }
            if (date == d)
            {
                Console.WriteLine(zametki[2] + "\n" + zametki[3]);
            }

        }
        static void Switching()
        {
            Console.WriteLine("   Выбрана дата: " + date);
            List_0_1();
            int position = 2;
            Console.SetCursorPosition(0, position);
            Console.Write("->");
            do
            {
                zaeb = Console.ReadKey();
                if (zaeb.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(0, position--);
                    Console.Write("->");
                }
                else if (zaeb.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(0, position++);
                    Console.Write("->");
                }
                Console.Write("\r" + new string(' ', 2) + "\r");
                Console.SetCursorPosition(0, position);
                Console.Write("->");
                if (zaeb.Key == ConsoleKey.LeftArrow)
                {
                    Console.SetCursorPosition(0, 2);
                    string s = "   33      333 3  ", z = "";
                    s = s.Trim();
                    for (int i = 0; i < s.Length; i++)
                    {

                        if (s[i] == ' ')
                        {
                            if (z[z.Length - 1] != '_')
                                z += '_';
                        }
                        else
                            z += s[i];

                    }
                    Console.Write("\r" + new string(' ', 100) + "\r");
                    date = date.AddDays(-1);
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("   Выбрана дата: " + date);
                    Console.SetCursorPosition(0, 1);
                    List_0_1();
                }
                if (zaeb.Key == ConsoleKey.RightArrow)
                {
                    string s = "   33      333 3  ", z = "";
                    s = s.Trim();
                    for (int i = 0; i < s.Length; i++)
                    {

                        if (s[i] == ' ')
                        {
                            if (z[z.Length - 1] != '_')
                                z += '_';
                        }
                        else
                            z += s[i];

                    }

                    date = date.AddDays(+1);
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("   Выбрана дата: " + date);
                    Console.SetCursorPosition(0, 1);
                    List_0_1();
                }
                if (zaeb.Key == ConsoleKey.Escape)
                {
                    return;
                }
            } while (true);
        }
    }
}


namespace Ежедневник2._0
{
    internal class Notes
    {
        public void example()
        {
            Notes note1 = new Notes();
            note1.Name = "fast";
            note1.Description = "fast";
            note1.EndDate = DateTime.Now;

            List<Notes> notes = new List<Notes>();
            notes.Add(note1);
            notes.Add(note1);
            notes.Add(note1);
            notes.Add(note1);
            DateTime date = DateTime.Now;

            List<Notes> nowNotes = Notes.Where(x => x.EndDate.Date == date.Date).ToList();
            //стелка направо
            DateTime = DateTime.AddDays(-1);
            //стрелка налево
            date = DateTime.AddDays(-1);


        }
    }
}
namespace Ежедневник2._0
{
    internal class Notes
    {
        public class Employee
        {
            public string Name { get; set; }
            public string Gender { get; set; }
            public string Phone { get; set; }
            public string Adress { get; set; }
            public string BirthDate { get; set; }
            public Employee() { }
            public void WriteEmployee()
            {
                using (StreamWriter sw = File.AppendText("SimpleNotebook.txt"))
                {
                    sw.WriteLine(this.Name);
                    sw.WriteLine(this.Gender);
                    sw.WriteLine(this.Phone);
                    sw.WriteLine(this.Adress);
                    sw.WriteLine(this.BirthDate);
                }
            }
            public static void DisplayEmployee(string name)
            {
                using (StreamReader sr = File.OpenText("SimpleNotebook.txt"))
                {
                    string temp = null;
                    while ((temp = sr.ReadLine()) != name && temp != null) ;
                    if (temp == name)
                    {
                        Console.WriteLine("Полное имя: " + temp);
                    }
                    else
                        Console.WriteLine("Такой сотрудник не найден . .");
                }
            }
        }
    }
}
public class Program
{
    public void second(string[] args)
    {
        Console.Clear()
        string state = null;
        while (state != "3")
        {
            Console.WriteLine(" 1 - добавить новую запись  2 - найти запись  3 - выход");
            state = Console.ReadLine();
            switch (state)
            {
                case "1":
                    Ejednevnik temp = new Ejednevnik();
                    Console.WriteLine("Введите заметку: ");
                    temp.Name = Console.ReadLine();
                    temp.WriteEmployee();
                    break;
                case "2":
                    string n = null;
                    Console.WriteLine("Введите имя сотрудника,которого ищем: ");
                    n = Console.ReadLine();
                    Ejednevnik.DisplayEmployee(n);
                    break;
                default:
                    break;
            }

        }
        Console.WriteLine("Работа завершена . . Нажмите клавишу для выхода . .");
        Console.ReadLine();
    }
}


public class Employee
{
    public static void TimE(DateTime r)
    {
        DateTime Time = new DateTime(2022, 10, 20);
        r = Time.AddDays(1);
    }
    public string State { get; set; }
    public string BigState { get; set; }
    public Employee() { }
    public void WriteEmployee()
    {
        using (StreamWriter sw = File.AppendText("EJEVNEVNIC.txt"))
        {
            sw.WriteLine(this.State);
            sw.WriteLine(this.BigState);
            sw.WriteLine(DateTime.Now);
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
            int count = System.IO.File.ReadAllLines("EJEVNEVNIC.txt").Length;
            string[] NewFile = File.ReadAllLines("EJEVNEVNIC.txt");
            for (int i = 0; i < count; i += 3)
            {

                int a = i;
                string line = File.ReadLines("EJEVNEVNIC.txt").Skip(a).Take(1).First();
                Console.WriteLine("  " + a / 3 + ". " + line);

            }
            string line = File.ReadLines("EJEVNEVNIC.txt").Skip(4).Take(1).First();
            Console.WriteLine(line);

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(String.Format(sr.ReadLine()));
            }
        }
    }

    internal static void TimE(object? r)
    {
        throw new NotImplementedException();
    }
}
namespace Практическая_работа_4
{
    internal class Program
    {
        public static class List_0
        {

        }
        public static ConsoleKeyInfo zaeb;
        public static DateTime Date = new DateTime(2022, 10, 20);
        static void Main(string[] args)
        {
            Switching();
        }
        static void List_0_1()
        {
            List<string> zametki = new List<string>();
            DateTime date = new(2022, 10, 20);
            zametki.Add(" 1. Погулять с собакой");
            zametki.Add(" 2. Погулять с собакой");
            zametki.Add(" 3. Погулять с собакой");
            zametki.Add(" 4. Погулять с собакой");
            if (date == Date)
            {
                Console.WriteLine(zametki[0] + "\n" + zametki[1] + "\n" + zametki[2] + "\n" + zametki[3]);
            }

        }
        static void Switching()
        {
            Console.WriteLine("Выбрана дата: " + Date);
            int position = 2;
            Console.SetCursorPosition(0, position);
            Console.Write("->");
            do
            {
                List_0_1();
                zaeb = Console.ReadKey();
                if (zaeb.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(0, position--);
                    Console.Write("->");
                }
                else if (zaeb.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(0, position++);
                    Console.Write("->");
                }
                Console.Write("\r" + new string(' ', 2) + "\r");
                Console.SetCursorPosition(0, position);
                Console.Write("->");
                if (zaeb.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    Date = Date.AddDays(-1);
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Выбрана дата: " + Date);
                    Console.SetCursorPosition(0, 1);
                }
                if (zaeb.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    Date = Date.AddDays(+1);
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Выбрана дата: " + Date);
                    Console.SetCursorPosition(0, 1);

                }
                if (zaeb.Key == ConsoleKey.Escape)
                {
                    return;
                }
            } while (true);
        }
    }
}
namespace daily_planer
{
    internal class Program
    {
        public static ConsoleKeyInfo SuicideBoy;
        public static int z = 0;
        public static int position = 1;
        public static int x = 0;
        public static int c = 0;
        public static int c1 = 0;
        static void Main(string[] args)
        {
            Perekluchenie_0();
        }
        public static void List_0()
        {
            List<string> zaebki = new List<string>();
            DateOnly date = new(2022, 10, 18);
            Console.Write("Выбрана дата ");
            Console.WriteLine(date);
            zaebki.Add(" 1. Придти на пары.");
            zaebki.Add(" 2. Пойти повеситься.");
            x = zaebki.Count;
            foreach (string item in zaebki)
                Console.WriteLine(item);
        }
        public static void List_1()
        {
            List<string> zaebki = new List<string>();
            DateOnly date = new(2022, 10, 19);
            Console.Write("Выбрана дата ");
            Console.WriteLine(date);
            zaebki.Add(" 1. Пойти в зал.");
            zaebki.Add(" 2. Приехать домой и откинуться.");
            z = zaebki.Count;
            foreach (string item in zaebki)
                Console.WriteLine(item);
        }
        public static void List_2()
        {
            List<string> zaebki = new List<string>();
            DateOnly date = new(2022, 10, 20);
            Console.Write("Выбрана дата ");
            Console.WriteLine(date);
            zaebki.Add(" 1. Походить по магазинам");
            x = zaebki.Count;
            foreach (string item in zaebki)
                Console.WriteLine(item);
        }
        static void PodList_0_1()
        {
            List<string> podzaebki = new List<string>();
            podzaebki.Add("1. Придти на пары.");
            podzaebki.Add("------------------------------------------");
            podzaebki.Add("Описание: Со 2 по 5.");
            podzaebki.Add("Дата: 18.10.2022");
            foreach (string item in podzaebki)
                Console.WriteLine(item);
        }
        static void PodList_0_2()
        {
            List<string> podzaebki = new List<string>();
            podzaebki.Add("2. Пойти повеситься.");
            podzaebki.Add("------------------------------------------");
            podzaebki.Add("Описание: Я дед инсайд?");
            podzaebki.Add("Дата: 18.10.2022");
            foreach (string item in podzaebki)
                Console.WriteLine(item);
        }
        static void PodList_1_1()
        {
            List<string> podzaebki = new List<string>();
            podzaebki.Add("1. Пойти в зал.");
            podzaebki.Add("------------------------------------------");
            podzaebki.Add("Описание: Жестко потрениться.");
            podzaebki.Add("Дата: 19.10.2022");
            foreach (string item in podzaebki)
                Console.WriteLine(item);
        }
        static void PodList_1_2()
        {
            List<string> podzaebki = new List<string>();
            podzaebki.Add("2. Приехать домой и откинуться.");
            podzaebki.Add("------------------------------------------");
            podzaebki.Add("Описание: После тренировки можно и откинуться.");
            podzaebki.Add("Дата: 19.10.2022");
            foreach (string item in podzaebki)
                Console.WriteLine(item);
        }
        static void PodList_2_1()
        {
            List<string> podzaebki = new List<string>();
            podzaebki.Add("1. Походить по магазинам");
            podzaebki.Add("------------------------------------------");
            podzaebki.Add("Описание: Купить одежду.");
            podzaebki.Add("Дата: 20.10.2022");
            foreach (string item in podzaebki)
                Console.WriteLine(item);
        }
        static void Perekluchenie_0()
        {
            Console.Clear();
            do
            {
                do
                {
                    DateTime date = new DateTime(2022, 10, 20);
                    if (SuicideBoy.Key == ConsoleKey.LeftArrow)
                    {
                        date = date.AddDays(-1);
                    }
                    if (SuicideBoy.Key == ConsoleKey.RightArrow)
                    {
                        date = date.AddDays(+1);
                    }
                    if (z == 0 && position == 1 && SuicideBoy.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        PodList_0_1();
                        SuicideBoy = Console.ReadKey();
                        if (SuicideBoy.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    else if (z == 0 && position == 2 && SuicideBoy.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        PodList_0_2();
                        SuicideBoy = Console.ReadKey();
                        if (SuicideBoy.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    if (z == 1 && position == 1 && SuicideBoy.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        PodList_1_1();
                        SuicideBoy = Console.ReadKey();
                        if (SuicideBoy.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    else if (z == 1 && position == 2 && SuicideBoy.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        PodList_1_2();
                        SuicideBoy = Console.ReadKey();
                        if (SuicideBoy.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    if (z == 2 && position == 1 && SuicideBoy.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        PodList_2_1();
                        SuicideBoy = Console.ReadKey();
                        if (SuicideBoy.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                } while (SuicideBoy.Key == ConsoleKey.Escape);
                switch (z)
                {
                    case 0:
                        Console.Clear();
                        List_0();
                        Perekluchenie_1();
                        return;
                    case 1:
                        Console.Clear();
                        List_1();
                        Perekluchenie_1();
                        return;
                    case 2:
                        Console.Clear();
                        List_2();
                        Perekluchenie_1();
                        return;
                }
                SuicideBoy = Console.ReadKey();
                switch (SuicideBoy.Key)
                {
                    case ConsoleKey.LeftArrow:
                        z--;
                        switch (z)
                        {
                            case -1:
                                Console.Clear();
                                z = 2;
                                List_2();
                                break;
                            case 0:
                                Console.Clear();
                                List_0();
                                break;
                            case 1:
                                Console.Clear();
                                List_1();
                                break;
                            case 2:
                                Console.Clear();
                                List_2();
                                break;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        z++;
                        switch (z)
                        {
                            case 3:
                                Console.Clear();
                                z = 0;
                                List_0();
                                break;
                            case 0:
                                Console.Clear();
                                List_0();
                                break;
                            case 1:
                                Console.Clear();
                                List_1();
                                break;
                            case 2:
                                Console.Clear();
                                List_2();
                                break;
                        }
                        break;
                }
            } while (true);
        }

        static void Perekluchenie_1()
        {
            Console.SetCursorPosition(0, position);
            Console.Write("->");
            do
            {
                SuicideBoy = Console.ReadKey();
                if (SuicideBoy.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(0, position--);
                    if (z == 0 && position == 0)
                    {
                        position++;
                    }
                    if (z == 1 && position == 0)
                    {
                        position++;
                    }
                    if (z == 2 && position == 0)
                    {
                        position++;
                    }
                    Console.Write("->");
                }
                else if (SuicideBoy.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(0, position++);
                    if (z == 0 && position == x)
                    {
                        position--;
                    }
                    if (z == 1 && position == z)
                    {
                        position--;
                    }
                    if (z == 2 && position == x)
                    {
                        position--;
                    }
                    Console.Write("->");
                }
                Console.Write("\r" + new string(' ', 2) + "\r");
                Console.SetCursorPosition(0, position);
                Console.Write("->");
            } while (SuicideBoy.Key == ConsoleKey.UpArrow | SuicideBoy.Key == ConsoleKey.DownArrow);
            if (SuicideBoy.Key == ConsoleKey.LeftArrow | SuicideBoy.Key == ConsoleKey.RightArrow)
            {
                switch (SuicideBoy.Key)
                {
                    case ConsoleKey.LeftArrow:
                        z--;
                        if (z == -1)
                            z = 2;
                        break;
                    case ConsoleKey.RightArrow:
                        z++;
                        if (z == 3)
                            z = 0;
                        break;
                }
                Perekluchenie_0();
            }
            else if (SuicideBoy.Key == ConsoleKey.Enter)
            {
                Perekluchenie_0();
            }
            if (SuicideBoy.Key == ConsoleKey.Escape)
            {
                return;
            }
        }
    }
}*/