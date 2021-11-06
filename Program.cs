/*****************************************************/
/* Лабораторная работа № 3 */
/* Наследование и полиморфизм */
/* Задание 1 */
/* Выполнил студент гр. 525в Туз А.В. */
/****************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuz.Lab03.Task03.ClassLib;

namespace Lab03App
{

    class Program
    {
        static void Main(string[] args)
        {
            Iron iron = new Iron();
            TV tv = new TV("Samsung", "UA2350");
            try
            {
                for (; ; )
                {
                    Console.WriteLine("MENU:\n 0--включить \n 1--функции утюга \n 2--функции TV \n 3--выключить");
                    int i = int.Parse(Console.ReadLine());
                    switch (i)
                    {
                        case 0:
                            iron.SwitchOn();
                            tv.SwitchOn();
                            break;
                        case 1:
                            for (; ; )
                            {
                                Console.WriteLine("\n1. Температура");
                                Console.WriteLine("2. Пар");
                                Console.WriteLine("3. Показать статус");
                                Console.WriteLine("4. Вернуться");
                                int pass = int.Parse(Console.ReadLine());
                                if (pass < 4)
                                {
                                    if (pass == 1)
                                    {
                                        Console.WriteLine("1. Выше");
                                        Console.WriteLine("2. Ниже");
                                        string go = Console.ReadLine();
                                        if (go == "1")
                                            iron.NextTemperature();
                                        else
                                            iron.PrevTemperature();
                                    }
                                    else if (pass == 2)
                                    {
                                        Console.WriteLine("1. Подача пара");
                                        Console.WriteLine("2. Удар паром");
                                        Console.WriteLine("3. Самоочистка системы подачи пара");
                                        Console.WriteLine("4. Отпаривание в вертикальном положении");
                                        int go = int.Parse(Console.ReadLine());
                                        if (go == 1)
                                            iron.SupplySteam();
                                        else if (go == 2)
                                            iron.HitSteam();
                                        else if (go == 3)
                                            iron.SelfCleaningSteam();
                                        else if (go == 4)
                                            iron.SteamingSteam();
                                        else
                                            throw new Exception("Не правильная команда");
                                    }
                                    else if (pass == 3)
                                        iron.Print();
                                    else if (pass == 4)
                                        break;
                                    else
                                        throw new Exception("Не правильная команда");
                                }
                            }
                            break;
                        case 2:
                            for (; ; )
                            {
                                Console.WriteLine("\n1. Разрешение");
                                Console.WriteLine("2. Диагональ");
                                Console.WriteLine("3. Показать статус");
                                Console.WriteLine("4. Вернуться");
                                int pass = int.Parse(Console.ReadLine());
                                if (pass < 4)
                                {
                                    if (pass == 1)
                                    {
                                        Console.WriteLine("1. HD");
                                        Console.WriteLine("2. UHD");
                                        int go = int.Parse(Console.ReadLine());
                                        if(go == 1)
                                            tv.HDresolution();
                                        else if(go == 2)
                                            tv.UHDresolution();
                                        else
                                            throw new Exception("Не правильная команда");
                                    }
                                    else if (pass == 2)
                                    {
                                        Console.WriteLine("Введите диагональ");
                                        float d = float.Parse(Console.ReadLine());
                                        tv.SetDiagonal(d);
                                    }
                                    else if (pass == 3)
                                        tv.Print();
                                    else if (pass == 4)
                                        break;
                                    else
                                        throw new Exception("Не правильная команда");
                                }
                            }
                            break;
                        case 3:
                            iron.SwitchOff();
                            tv.SwitchOff();
                            break;
                        default:
                            throw new Exception("Не правильная команда");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
        }
    }
}
