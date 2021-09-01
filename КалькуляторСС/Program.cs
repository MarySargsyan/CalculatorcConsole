using System;
using static System.Net.Mime.MediaTypeNames;

namespace КалькуляторСС
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            while(a == 0)
            {
                try
                {
                    Console.WriteLine("please, input first vale:");
                    a = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Error! input only numeric values");
                    continue;
                }

               
                double rez = a;
                   
                while (a == rez)
                {
                    try
                    {
                        Console.WriteLine("select an action: \n 1-add \n 2-min \n 3-sub \n 4-divv \n 5-clean");
                        int deistvie = Convert.ToInt32(Console.ReadLine());
                        if (deistvie == 5)
                        {
                            try
                            {
                                Console.WriteLine("please, input first vale:");
                                a = Convert.ToDouble(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Error! input only numeric values");
                                continue;
                            }
                            rez = a;
                        }
                        else
                        {
                            try
                            {
                                Console.WriteLine("please, input second vale:");
                                double b = Convert.ToDouble(Console.ReadLine());
                                switch (deistvie)
                                {
                                case 1:
                                    rez = a + b;
                                    Console.WriteLine("Result : \n" + rez);
                                    a = rez;
                                    break;
                                case 2:
                                    rez = a - b;
                                    Console.WriteLine("Result : \n" + rez);
                                    a = rez;
                                    break;
                                case 3:
                                    rez = a * b;
                                    Console.WriteLine("Result : \n" + rez);
                                    a = rez;
                                    break;
                                case 4:
                                    rez = a / b;
                                    Console.WriteLine("Result : \n" + rez);
                                    a = rez;
                                    break;
                                    default:
                                        Console.WriteLine("Error! the command was not found");
                                        break;

                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Error! input only numeric values");
                                continue;
                            }
                           

                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Erorr! incorrect action");
                        continue;
                    }                    
                }
            }
            Console.ReadKey();
        }

    }
}
