using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hw_06._10
{

    struct Ded
    {
        public string name;
        public byte vorch;
        public string[] phrases;
        public byte blows;


        public Ded(string Name, byte Vorch, string[] Phrases, byte Hit)
        {
            this.name = Name;
            this.vorch = Vorch;
            this.phrases = Phrases;
            this.hit = Hit;
        }
    }

    class Program
    {


        public static void task_1_ReshYravn(double a, double b, double c)
        {
            double D = (a * a + 4 * a * c);
            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D) / 2 * a);
                double x2 = (-b - Math.Sqrt(D) / 2 * a);
                Console.WriteLine($"Первый корень равен {x1}, второй корень равен {x2}");
            }
            else if (D == 0)
            {
                double x1 = (-b + Math.Sqrt(D) / 2 * a);
                Console.WriteLine($"Единственный корень равен {x1}");

            }
            else
            {
                Console.WriteLine("Корней нет");
            }

        }
        public static void Task_2()
        {
            int[] mas = new int[20];
            Random random = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = random.Next(0, 100);
                Console.Write(mas[i] + " ");

            }

        }
       
        public static void task_3()
        {
            int[] num;
            int temp;
            for (int m = 0; m < num.Length; m++)
            {
                for (int j = 0; j < num.Length - 1 - m; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        temp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = temp;
                    }
                }
            }
            for (int m = 0; m < num.Length; m++)
            {
                Console.WriteLine(num[m]);
            }
        }

        public static void task_4_Sortirovka(ref int umn, out double srar, ref int sum, params int[] array1)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                sum = sum + array1[i];
            }
            for (int i = 0; i < array1.Length; i++)
            {
                umn = umn * array1[i];
            }
            srar = sum / array1.Length;

        }
        public static void task_5()
        {
            bool run = true;
            do
            {
                try
                {
                    Console.WriteLine("Введите число в диапозоне 0-9");
                    int chislo = int.Parse(Console.ReadLine());
                    string[] PictureNumber = new string[10];
                    PictureNumber[0] = "###" + "\n" + "# #" + "\n" + "# #" + "\n" + "# #" + "\n" + "###";
                    PictureNumber[1] = " # " + "\n" + "## " + "\n" + " # " + "\n" + " # " + "\n" + "###";
                    PictureNumber[2] = " # " + "\n" + "# #" + "\n" + "  #" + "\n" + " # " + "\n" + "###";
                    PictureNumber[3] = "## " + "\n" + "  #" + "\n" + " # " + "\n" + "  #" + "\n" + "## ";
                    PictureNumber[4] = "# #" + "\n" + "# #" + "\n" + "###" + "\n" + "  #" + "\n" + "  #";
                    PictureNumber[5] = "###" + "\n" + "#  " + "\n" + "###" + "\n" + "  #" + "\n" + "### ";
                    PictureNumber[6] = "###" + "\n" + "#  " + "\n" + "###" + "\n" + "# #" + "\n" + "###";
                    PictureNumber[7] = "####" + "\n" + "  #" + "\n" + " ###" + "\n" + " # " + "\n" + " # ";
                    PictureNumber[8] = "###" + "\n" + "# #" + "\n" + " # " + "\n" + "# #" + "\n" + "###";
                    PictureNumber[9] = "###" + "\n" + "# #" + "\n" + "###" + "\n" + "  #" + "\n" + "###";

                    if (chislo >= 0 && chislo <= 9)
                    {
                        Console.WriteLine(PictureNumber[chislo]);
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Thread.Sleep(3000);
                        Console.ResetColor();
                        Console.Clear();
                        Console.WriteLine("Ошибка");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введенное вами число некорректно ");
                }
                Console.WriteLine("Хотите продолжижть?(если нет - exit/закрыть)");
                string ex = Console.ReadLine();
                if (ex == "exit" || ex == "закрыть")
                {
                    run = false;
                }
            } while (run == true);

        }

        public static int ded(string[] words, params string[] mats)
        {
            int fingal = 0;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < mats.Length; j++)
                {
                    if (mats[j] == words[i])
                    {
                        fingal++;
                    }
                }
            }
            return fingal;
        }
        int[] numb = { 1, 2, 4, 6, 8, 10, 12, -34 };
        public static int FindPivot(int[] numb, int minIndex, int maxIndex)
        {

            int pivot = minIndex - 1;
            int temp = 0;
            for (int i = minIndex; i < maxIndex; i++)
            {
                if (numb[i] < numb[maxIndex])
                {
                    pivot++;
                    temp = numb[pivot];
                    numb[i] = temp;
                }
            }
            pivot++;
            temp = numb[pivot];
            numb[pivot] = numb[maxIndex];
            numb[maxIndex] = temp;
            return pivot;

        }
        static int[] QuickSort(int[] numb, int maxIndex, int minIndex)
        {
            if (minIndex >= maxIndex)//условие при котором мин индекс больше или равен макс,тогда масс будет сост из одного элемента 
            {
                return numb;
            }
            int pivot = FindPivot(numb, minIndex, maxIndex);
            QuickSort(numb, minIndex, pivot - 1);
            QuickSort(numb, pivot + 1, maxIndex);
            return numb;// чтобы вызвать,в основом методе пишем 
            // int[] numb={chisla};
            //numb = QuicSort(numb,0,numb.Length-1);
            //for(int i = 0; i <numb.Length;i++
            //{Console.WriteLine(numb[i]);}}
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите коэффиценты a,b,c для решения квадратного уравнения");
            double koef1 = double.Parse(Console.ReadLine());
            double koef2 = double.Parse(Console.ReadLine());
            double koef3 = double.Parse(Console.ReadLine());
            task_1_ReshYravn(koef1, koef2, koef3);
            Console.WriteLine();

            Console.WriteLine("Задание 2");
            Console.Write("Введите первое число ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == n2)
                {
                    mas[i] = n1;
                    continue;
                }
                if (mas[i] == n1)
                {
                    mas[i] = n2;
                    continue;
                }
            }
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i]);

            }
            Console.ReadKey();

            Console.WriteLine("Задание 3");
            Console.WriteLine("Массив:");
            int[] num = { 1, 8, 7, -9, 4, 2, 15, 98 };
            for (int m = 0; m < num.Length; m++)
            {
                Console.WriteLine(num[m]);
            }
            Console.ReadKey();

            Console.WriteLine("Задание 4");
            Console.Write("Массив - ");
            int[] array1 = { 1, 2, 3, 4 };
            for (int i = 0; i < array1.Length; i++)
                Console.Write(array1[i] + " ");
            int sum = 0;
            int umn = 1;
            double srar;
            task_4_Sortirovka(ref umn, out sr, ref sum, array1);
            Console.WriteLine();
            Console.WriteLine($"Сумма = {sum}, Произведение = {umn}, Среднее арифметическое = {srar}");
            Console.ReadKey();

            Console.WriteLine("Задание 5");
            task_5();
            Console.ReadKey();

            Console.WriteLine("Задание 6");
            string[] mats1 = { "сволочи!", "твари", "подонки" };
            Ded ded1 = new Ded("Зиният Зиниятович", 2, mats1, 0);
            string[] mats2 = { "засранцы", "тваритвари", "простофили!", "кровопийцы" };
            Ded ded2 = new Ded("Акакий Акакиевич", 4, mats2, 0);
            string[] mats3 = { "бестолочи!", "шмары!", "гады", "алкоголики", "душегубы", "дуралеи" };
            Ded ded3 = new Ded("Витька Бар", 5, mats3, 0);
            string[] mats4 = { "бабник", "мудаки", "ебоба", "лицемеры" };
            Ded ded4 = new Ded("Злюк Злюкович", 6, mats4, 0);
            string[] mats5 = { "вруны", "прохиндяи", "плохиши" };
            Ded ded5 = new Ded("Ворчун Ворчунович", 1, mats5, 0);
            string[] slova = { "что нынче молодежь творит", "ты погляди на них", "твари", "бестолочи", "гады", "вот прохиндяи" };
            Console.WriteLine("Количество финаглов первого деда от бабки: " + ded(slova, mats1));
            Console.WriteLine("Количество  финаглов второго деда от бабки: " + ded(slova, mats2));
            Console.WriteLine("Количество  финаглов третьего деда от бабки: " + ded(slova, mats3));
            Console.WriteLine("Количество  финаглов четвертого деда от бабки: " + ded(slova, mats4));
            Console.WriteLine("Количество  финаглов пятого деда от бабки: " + ded(slova, mats5));
            Console.ReadKey();

            Console.WriteLine("Задание 7");
            int[] numb = { 1, 2, 4, 6, 8, 10, 12, -34 };
            numb = QuickSort(numb, 0, numb.Length - 1);
            for (int i = 0; i < numb.Length; i++)
            {
                Console.WriteLine(numb[i]);
            }
            Console.ReadKey();


















        } }








