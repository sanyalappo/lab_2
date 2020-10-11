using System;
using System.Text;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ТИПЫ
            //a)
            int a;
            double b;
            float c;
            bool d;
            decimal e;
            Console.WriteLine("Введите переменную типа int");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную типа double");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную типа float");
            c = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную типа bool");
            d = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную типа decimal");
            e = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Переменная типа int {0}", a);
            Console.WriteLine("Переменная типа double {0}", b);
            Console.WriteLine("Переменная типа float {0}", c);
            Console.WriteLine("Переменная типа bool {0}", d);
            Console.WriteLine("Переменная типа decimal {0}", e);

            //b) явные и неявные преобразования

            int num_1 = 2147483647;
            long Num_1 = num_1;
            Console.WriteLine("Тип  int преобразован в тип long {0}", Num_1);

            float num_2 = 12;
            double Num_2 = num_2;
            Console.WriteLine("Тип  float преобразован в тип double {0}", Num_2);

            sbyte num_3 = -101;
            short Num_3 = num_3;
            Console.WriteLine("Тип  sbyte преобразован в тип short {0}", Num_3);

            ulong num_4 = 18446;
            decimal Num_4 = num_4;
            Console.WriteLine("Тип  ulong преобразован в тип decimal {0}", Num_4);

            uint num_5 = 421;
            float Num_5 = num_5;
            Console.WriteLine("Тип  uint преобразован в тип float {0}", Num_5);

            double num_6 = 1234.7;
            int Num_6;
            Num_6 = (int)num_6;
            Console.WriteLine("Тип double преобразован к типу int {0} ", Num_6);

            long num_7 = -2333;
            ulong Num_7;
            Num_7 = (ulong)num_7;
            Console.WriteLine("Тип long преобразован к типу ulong {0} ", Num_7);

            sbyte num_8 = -125;
            byte Num_8;
            Num_8 = (byte)num_8;
            Console.WriteLine("Тип sbyte преобразован к типу byte {0} ", Num_8);

            short num_9 = -22345;
            ushort Num_9;
            Num_9 = (ushort)num_9;
            Console.WriteLine("Тип short преобразован к типу ushort {0} ", Num_9);

            decimal num_10 = 7;
            int Num_10;
            Num_10 = (int)num_10;
            Console.WriteLine("Тип decimal преобразован к типу int {0} ", Num_10);

            int n = Convert.ToInt32("23");
            bool b_1 = true;
            double d_1 = Convert.ToDouble(b_1);
            Console.WriteLine($"n={n}  d={d_1}");

            //Упаковка и распаковка значимых типов

            Int32 x = 5;
            object o = x;
            byte m = (byte)(int)o;

            //Неявно типизированная переменная

            var arr = new[] { 2, 3, 4, 5, 6, 7 };
            Console.Write(arr.GetType());
            Console.WriteLine();

            //nullable типы
            int? z1 = 5;
            bool? enabled1 = null;
            Double? d1 = 3.3;

            Nullable<int> z2 = 5;
            Nullable<bool> enabled2 = null;
            Nullable<System.Double> d2 = 3.3;

            //переменная типа var ( var не может динамически изменятся)
            //var f = 5;
            // F = (double)f;

            //-----------------------------------

            //СТРОКИ

            //a) Объявление строковых литералов

            string name = "Sasha";
            Console.WriteLine($"Имя: {name}"); //$????

            //b) Создать три строки на основе string

            string str1 = "Hello";
            string str2 = "wonderful";
            string str3 = "world";

            // сцепление 
            string str4 = str1 + " " + str2 + " " + str3;
            Console.WriteLine(str4);

            string str6 = String.Concat(str1, " ", str2, " ", str3);
            Console.WriteLine(str6);

            //копирование
            string str7 = String.Copy(str1);
            Console.WriteLine(str1);

            //Выделение подстроки ??? substring
            string str_i = str4;
            str_i = str4.Substring(2);
            Console.WriteLine(str_i);

            //разделение строки на слова  ???

            string text = "That is why it happends so";

            string[] words = text.Split(new char[] { ' ' });

            foreach (string s in words)
            {
                Console.WriteLine(s);

            }

            // вставка подстроки в заданную позицию

            string text_0 = " bad";
            string text_1 = text.Insert(26, text_0);
            Console.WriteLine(text_1);

            // удаление заданной подстроки
            //???
            string text_rm;
            int ind = text.Length - 2;
            Console.WriteLine(ind);
            text_rm = text.Remove(ind);
            Console.WriteLine(text_rm);

            //интерполирование строк

            int x_0 = 8;
            int y_0 = 7;
            string result = $"{x_0} + {y_0} = {x_0 + y_0}";
            Console.WriteLine(result); // 8 + 7 = 15

            //null-строка

            string strr = null;
            string strr_1 = "";
            Console.WriteLine(String.IsNullOrEmpty(strr));
            Console.WriteLine(String.IsNullOrEmpty(strr_1));

            //создание строки на основе StringBuilder

            StringBuilder sb = new StringBuilder("Hello, sun!");
            sb.Remove(7, 3); //удаляет 3 символа, начиная с 7
            Console.WriteLine(sb);

            sb.Append("!!"); //добавляет подстроку в конец
            sb.Insert(6, "dear");// вставляет, начиная с заданного символа
            Console.WriteLine(sb);

            //---------------------------------

            //МАССИВЫ

            // Создайте целый двумерный массив и выведите его на консоль отформатированном виде(матрица).

            int[,] array = new int[4, 4];
            Random ran = new Random();
            for (int j = 0; j < 4; j++)
            {
                for (int z = 0; z < 4; z++)
                {
                    array[j, z] = ran.Next(-50, 50);
                    Console.Write("{0}\t", array[j, z]);
                }
                Console.WriteLine();
            }

            // Массив строк

            string[] array_str = { "Program","Code","Sleep"};
            foreach (object obj in array_str)
                Console.WriteLine(obj);

            int arr_len = array_str.Length;
            Console.WriteLine("Размер массива :"+ arr_len);

            Console.WriteLine("\nВведите номер индекса массива, который нужно изменить:");
            int indx_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите новое значение:");
            string indx_2 = Console.ReadLine();
            array_str[indx_1] = indx_2;
            Console.WriteLine("Измененный массив строк ");
            foreach (object me in array_str)
                Console.WriteLine(me);

            //Ступенчатый массив

            float[][] arr3 = new float[3][];
            arr3[0] = new float[2];
            arr3[1] = new float[3];
            arr3[2] = new float[4];
            for (int q = 0; q < 3; q++)
            {
                for (int w = 0; w < arr3[q].Length; w++)
                {
                    Console.WriteLine("Введите элемент массива: ");
                    arr3[q][w] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int q = 0; q < 3; q++)
            {
                for (int w = 0; w < arr3[q].Length; w++)
                {
                    Console.Write(arr3[q][w] + "  ");

                }
                Console.Write("\n");
            }

            //неявно типизированные переменные для хранения строк 

            Console.WriteLine();
            var strg = new[] { 1, 2, 3, 4 };
            for (int pi = 0; pi < strg.Length; pi++)
            {
                Console.Write("{0}\t", strg[pi]);
            }
            Console.WriteLine();
            var strg1 = new[] { "Monday", "Tuesday", "Friday" };
            for (int pi = 0; pi < strg1.Length; pi++)
            {
                Console.Write("{0}\t", strg1[pi]);
            }
            Console.WriteLine();

            //КОРТЕЖИ

            int tu_1 = 1;
            string tu_2 = "Today";
            char tu_3 = 'A';
            string tu_4 = "Tomorrow";
            ulong tu_5 = 10;

            var tuple1 = Tuple.Create<int, string, char, string, ulong>(tu_1, tu_2, tu_3, tu_4, tu_5);
            var tuple2 = Tuple.Create<int,string,char, string,ulong>(tu_1,tu_2, tu_3, tu_4,tu_5);

            //распаковка кортежа
            int last = (int)tuple1.Item1;
            string last2 = (string)tuple1.Item2;
            char last3 = (char)tuple1.Item3;
            string last4 = (string)tuple1.Item4;
            ulong last5 = (ulong)tuple1.Item5;

            //вывести кортежи 

            Console.WriteLine(tuple1);
            Console.WriteLine(tuple1.Item1);
            Console.WriteLine(tuple1.Item3);
            Console.WriteLine(tuple1.Item4);

            //сравнение кортежей

            var t1 = (A: 5, B: 10);
            var t2 = (B: 5, A: 10);
            Console.WriteLine(t1 == t2);  // output: True
            Console.WriteLine(t1 != t2);  // output: False

            // _

            int _ = 7;
            Console.WriteLine(_);

            // 

            static Tuple<int, int, int, char> fun(string a, int[] b)
            {
                int min = 99, max = 0, sum = 0; char h;
                foreach (int key in b)
                {
                    if (key > max) { max = key; }
                    if (key < min) { min = key; }
                    sum += key;
                }
                h = a[0];
                var tuples = Tuple.Create<int, int, int, char>(min, max, sum, h);
                return tuples;
            }

            //
            void Chek()
            {
                unchecked
                {
                    Console.WriteLine(2147483647 + 10);
                }

            }
            Chek();

            //void Check()
            //{
            //    checked
            //    {
            //        Console.WriteLine(2147483647 + 10);
            //    }

            //}

        }

    }
 }

