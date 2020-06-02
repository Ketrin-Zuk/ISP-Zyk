using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
//using System.


namespace ConsoleApplication1
{

    class Program
    {
        static string P(string str, char c)
        {
            string s;
            int kol=0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                {
                    kol++;
                }
            }
            s = "Количество \""+ c +"\" = " +kol;
            return s;
        }

        static void Main(string[] args)
        {//•	В заданной строке поменять порядок слов на обратный (слова разделены пробела-ми).
            Console.WriteLine("===================================");
                        Console.WriteLine("ЗАДАНИЕ 1");
                        Console.WriteLine();
                        Console.WriteLine("Введите строку:");
                        string s=Console.ReadLine();
                        int kol=s.Length;
                        string[] mas=new string[kol];
                        mas = s.Split(' ');
                        Console.WriteLine();
                        Console.WriteLine("Строка в обратном порядке: ");
                        for (int i = mas.Length - 1; i >= 0; i--)
                        {
                            Console.Write(mas[i] + " ");
                        }
                        Console.ReadLine();



  //          Добавить перед каждым словом тот знак препинания, который стоит после него.
                        Console.WriteLine("===================================");
                        Console.WriteLine("ЗАДАНИЕ 2");
                        Console.WriteLine();
                        Console.WriteLine("Введите строку:");
                        string str = Console.ReadLine();
                        string[] mass;
                        mass = str.Split(' ');
                        char simvol;

                        for (int i = 0; i < mass.Length; i++)
                        {
                            simvol = mass[i][mass[i].Length - 1];
                            if (simvol == '.')
                            {
                                mass[i] = '.' + mass[i];
                            }
                            if (simvol == ',')
                            {
                                mass[i] = ',' + mass[i];
                            }
                            if (simvol == '!')
                            {
                                mass[i] = '!' + mass[i];
                            }
                            if (simvol == '?')
                            {
                                mass[i] = '?' + mass[i];
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Результат:");
                        for (int i = 0; i < mass.Length; i++)
                        {
                            Console.Write(mass[i] + " ");
                        }

                        Console.ReadLine();


            //•	Дана строка. Найти в ней все заглавные буквы, не входящие в английский алфавит.
            Console.WriteLine("===================================");
            Console.WriteLine("ЗАДАНИЕ 3");
            Console.WriteLine();
            Console.WriteLine("Введите строку:");
            string strr = Console.ReadLine();
            for (int i = 0; i < strr.Length; i++)
            {
                if (Char.IsUpper(strr[i]) && strr[i] >= 'А' && strr[i] <= 'Я')
                {
                    Console.WriteLine(strr[i] + " ");
                }
                //пыавAПdScвdaРhjfJCИвыwdsZВаugviЕDFТ                
            }
            Console.ReadLine();


            //•	Получить текущее время и дату в двух разных форматах и вывести на экран коли-чество нулей, единиц, …, девяток в их записи.
            Console.WriteLine("===================================");
            Console.WriteLine("ЗАДАНИЕ 4");
            Console.WriteLine();

            str=DateTime.Now.ToString("yyyy.MM.dd");
            
            Console.WriteLine("Текущее время: " + str +"\n"+ (Program.P(str, '0'))
                + "\n" + (Program.P(str, '1'))
                + "\n" + (Program.P(str, '2'))
                + "\n" + (Program.P(str, '3'))
                + "\n" + (Program.P(str, '5'))
                + "\n" + (Program.P(str, '6'))
                + "\n" + (Program.P(str, '7'))
                + "\n" + (Program.P(str, '8'))
                + "\n" + (Program.P(str, '9'))
                );

            kol = 0;
            str = DateTime.Now.ToLongDateString() +" "+ DateTime.Now.ToShortTimeString();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '0')
                {
                    kol++;
                }
            }
            Console.WriteLine("Текущее время: " + str + "\n" + (Program.P(str, '0'))
                + "\n" + (Program.P(str, '1'))
                + "\n" + (Program.P(str, '2'))
                + "\n" + (Program.P(str, '3'))
                + "\n" + (Program.P(str, '5'))
                + "\n" + (Program.P(str, '6'))
                + "\n" + (Program.P(str, '7'))
                + "\n" + (Program.P(str, '8'))
                + "\n" + (Program.P(str, '9'))
                );
         

            Console.ReadLine();
        }
    }
}
