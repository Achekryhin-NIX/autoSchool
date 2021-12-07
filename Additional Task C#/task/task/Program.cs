using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Delegate
{
    public class Program
    {

        //Задача № 1
        //Необходимо написать консольную программу, где пользователь будет вводить с клавиатуры 2 числа.
        //Числа будут сравниваться с последующим выводом в консоль результата этого сравнения(равны ли значения, а если нет,
        //то какое число больше/меньше).

        static void Main(string[] args)
        {
            Console.WriteLine("Input first digit:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second digit:");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("First digit is greater then second digit");
            }

            if (a < b)
            {
                Console.WriteLine("First digit is less then second digit");
            }

            if (a == b)
            {
                Console.WriteLine("First digit are equale second digit");
            }



            //Задача № 2
            //Теперь несколько усложним ситуацию в создаваемой программе.Пусть пользователь имеет возможность ввести одно число,причем:
            //— когда значение больше пяти и одновременно с этим меньше десяти, выводится один текст с соответствующим сообщением;
            //—  когда значение не попадает в указанный диапазон, программа его не узнает, выводя другой текст с соответствующим сообщением.


            static void Task2(string[] args)
            {
                Console.WriteLine("Input first digit:");
                int a = Convert.ToInt32(Console.ReadLine());


                if (a > 5 && a < 10)
                {
                    Console.WriteLine("The digit is greater then 5 and less then 10");
                }
                else

                {
                    Console.WriteLine("unknown digit");
                }

                //Задача № 3

                //Далее решим задачу сложнее.Представим банк, в котором алгоритм начисления процента по вкладу зависит от суммы вклада.

                //На вход будет подаваться число (сумма вклада). При значении меньше 100, будет начислено 5 %, если значение находится


                //в диапазоне от ста до двухсот — 7 %, если больше — 10 %. Отработав, программа должна вывести общую сумму с начисленными

                //процентами.когда значение не попадает в указанный диапазон, программа его не узнает, выводя другой текст            //с соответствующим сообщением.


                static void Task3(string[] args)
                {
                    Console.WriteLine("Input deposit:");

                    double a = Convert.ToDouble(Console.ReadLine());



                    if (a < 100)

                    {
                        a = a * 0.05 + a;
                    }

                    else if (a >= 100 && a <= 200)
                    {
                        a = a * 0.07 + a;
                    }
                    else if (a > 200)
                    {
                        a = a * 0.1 + a;
                    }
                    Console.WriteLine($"Deposit sum with percent is: {a}");





                    //Задача № 4
                    // На ввод принимаються символы через розделитель(определить самостоятельно (пробел, запятая, точка, звездочка,
                    // пробел и запятая и т.д.)), необходимо вывести список повторяющихся символов и список уникальных символов.
                    //* добавить счетчик повторений для списка повторяющихся.


                    static void Task4(string[] args)
                    {


                        string input = Console.ReadLine();
                        string result = string.Join(",", input.AsEnumerable());
                        Console.WriteLine(result);



                        while (input.Length > 0)
                        {
                            Console.Write(input[0] + " : ");
                            int count = 0;
                            for (int j = 0; j < input.Length; j++)
                            {
                                if (input[0] == input[j])
                                {
                                    count++;
                                }
                            }
                            Console.WriteLine(count);
                            input = input.Replace(input[0].ToString(), string.Empty);
                        }
                        Console.ReadLine();


                        //Задача № 5
                        //Из предложения(строка), состоящего не более чем из 20 символов, удалить все пробелы.Не использовать .Replace().


                        static void Task5()
                        {
                            string source = "abc d ef r7  8 9 54";
                            string result = string.Concat(source.Where(c => !char.IsWhiteSpace(c)));

                            Console.WriteLine(result);

                        }

                        //Задача № 6
                        //Из предложения(строка), состоящего не более, чем из 20 символов, выбрать только цифры и переписать в символьный
                        //массив. Определить максимальную из этих цифр.


                        static void Task6()
                        {

                            string test = "1 2 3 hell hjh4j5 67t o";
                            string digits = new String(test.Where(Char.IsDigit).ToArray());

                            Console.WriteLine(digits);

                            char[] charArr = digits.ToCharArray();

                            {

                                int i;

                                char max = charArr[0];

                                for (i = 1; i < charArr.Length; i++)
                                    if (charArr[i] > max)

                                        max = charArr[i];


                                Console.WriteLine(max);


                            }
                        }













                    }
                }
            }
        }
    }
}