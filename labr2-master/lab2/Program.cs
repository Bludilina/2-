using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Magaz[] Pokupat = new Magaz[] { };
            string output;
            int ID;
            string FIO;
            string Adress;
            string Data;
            bool go = true;
            while (go)
            {
                Console.WriteLine(" МЕНЮ \n 1. Ввод покупателей\n 2. Вывести таблицу Покупателей\n 3. Вывести измененную таблицу\n 0. Выход");
                Console.Write("\n Выберите пункт -> ");
                int N = 0;
                int sw = int.Parse(Console.ReadLine());
                switch (sw)
                {
                    case 1:
                        {
                            Console.Clear();
                            StreamWriter dataOut;
                            dataOut = new StreamWriter("F:\\10.txt");
                            Console.Write("Количество покупателей -> ");
                            N = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < N; i++)
                            {
                                Console.Write("Введите ID -> ");
                                ID = Convert.ToInt32(Console.ReadLine());
                                dataOut.WriteLine(Convert.ToString(ID));
                                Console.Write("\nВведите ФИО -> ");
                                FIO = Console.ReadLine();
                                dataOut.WriteLine(FIO);
                                Console.Write("Введите Адрес-> ");
                                Adress = Console.ReadLine();
                                dataOut.WriteLine(Adress);
                                Console.Write("Введите дату-> ");
                                Data = Console.ReadLine();
                                dataOut.WriteLine(Data);
                            }
                            dataOut.Close();
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            StreamReader dataIn = new StreamReader("F:\\10.txt");
                            Console.WriteLine(" ID  FIO              Адрес        Дата\n");
                            while (dataIn.EndOfStream != true)
                            {
                                int id = Convert.ToInt32(dataIn.ReadLine());
                                string fio = dataIn.ReadLine();
                                string adres = dataIn.ReadLine();
                                string dat = dataIn.ReadLine();
                                output = String.Format("{0,-2} {1,-15} {2,-8} {3,-8}", id, fio, adres, dat);
                                Console.WriteLine(output);
                            }
                            dataIn.Close();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            StreamReader dataIn = new StreamReader("F:\\10.txt");
                            int count = 0;
                            Console.WriteLine(" ID  FIO              Адрес        Дата\n");
                            while (dataIn.EndOfStream != true)
                            {
                                int id = Convert.ToInt32(dataIn.ReadLine());
                                string fio = dataIn.ReadLine();
                                string adres = dataIn.ReadLine();
                                string dat = dataIn.ReadLine();
                                output = String.Format("{0,-2} {1,-15} {2,-8} {3,-8}", id, fio, adres, dat);
                                Console.WriteLine(output);
                                count++;

                            }
                            dataIn.Close();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 0:
                        {
                            go = false; continue;
                        }
                }
            }
        }
    }

    internal class Magaz
    {
    }
}
