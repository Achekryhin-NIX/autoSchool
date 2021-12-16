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

        //LINQ:
        //Задача №1
        //Из списка чисел найти позитивные используя методы LINQ.

        public static void Main()
        {

        }
        public static void Task1()
        {

            int[] numbers = {
         1, 3, 6, 9, 10, -4, -2, -3, -88, 12, 19,  14
            };

            var nQuery =
            from VrNum in numbers
            where VrNum > 0

            select VrNum;
            Console.Write("The positive numbers  are :");
            foreach (var VrNum in nQuery)
            {
                Console.Write("{0}  ", VrNum);
            }
            Console.ReadLine();
        }





        //LINQ:
        //Задача № 2
        //Для каждого числа в списке вывести число и его квадрат в виде: {Number = 2, Sqrt = 4}, {Number = 9, Sqrt = 81},
        //... { Number = x, Sqrt = x * x}


        static void Task2()
        {
            // code from DevCurry.com
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };

            var sqNo = from int Number in arr1
                       let Sqrt = Number * Number

                       select new { Number, Sqrt };

            foreach (var a in sqNo)
                Console.WriteLine(a);

            Console.ReadLine();
        }

        // Задача №3
        // Из предложения(строка), состоящего не более, чем из 20 символов, выбрать только цифры и переписать
        // в символьный массив.Определить максимальную из этих цифр. Теперь с использованием LINQ

        static void Task3()
        {

            string test = "1 267388 hjh4j5 67to";
            string digits = new String(test.Where(Char.IsDigit).ToArray());

            Console.WriteLine(digits);

            char[] charArr = digits.ToCharArray();



            int i;

            char max = charArr[0];

            for (i = 1; i < charArr.Length; i++)
            {
                if (charArr[i] > max)

                    max = charArr[i];
            }

            Console.WriteLine(max);
        }

        //Задача № 4
        //Из списка строк убедится что хоть 1 содержит искомую подстроку.Убедиться чт овсе строки из списка содержат искомую
        //подстроку.

        static void Task4()
        {

            // Define a list
            List<string> XEmployee = new List<string>();

            // Add names into the list
            XEmployee.Add("MANVITHA");
            XEmployee.Add("SRIMANTH");
            XEmployee.Add("RAVI");
            XEmployee.Add("MANASA");
            XEmployee.Add("MOUNIKA");
            XEmployee.Add("MANAS");

            // Choose the employee's name that
            // contains MAN as a sub string
            IEnumerable<string> final = XEmployee.Where(
                                        employee => employee.Contains("MAN"));

            Console.WriteLine("Names that conatin MAN substring:");

            // Display employee names
            foreach (string stname in final)
            {
                Console.WriteLine(stname);
            }
        }

        //Задача № 5
        // Из списка обьектов(с двумя стрковыми свойствами A, B и целочисленным C) получить обьекты, в которых свойство A
        // равно Х, свойство B содержит Y.Отсортировать результат по убыванию значения свойства C.



        public static void Task5()
        {
            Employee object1 = new Employee("John", "Cash", 24);
            Employee object2 = new Employee("Sam", "Brith", 27);
            Employee object3 = new Employee("Roger", "Cibastos", 21);

            Employee object4 = object3;

            object4.name = "X";
            object4.surname = "BrithY";
            object4.age = 36;

            List<Employee> employees = new List<Employee>() { object1, object2, object3 };

            employees.Sort(delegate (Employee x, Employee y)
            {
                return y.age.CompareTo(x.age);
            });

            Console.WriteLine(String.Join(Environment.NewLine, employees));
        }


        public class Employee
        {
            public string name;
            public string surname;
            public int age;

            public Employee(string name, string surname, int age)
            {
                this.name = name;
                this.surname = surname;
                this.age = age;
            }

            public override string ToString()
            {
                return name + " " + surname + "," + age;
            }
        }


    }
}


