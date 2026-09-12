using System;

namespace ELMAGHAWRY
{
    class Person
    {
        public string Name;
        public int Age;
    }

    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    struct PersonData
    {
        public string Name;
        public int Age;
    }

    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    [Flags]
    enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }

    enum Colors
    {
        Red,
        Green,
        Blue
    }

    struct Point
    {
        public double X;
        public double Y;
    }

    internal class Program
    {
        static void ChangeByValue(int x)
        {
            x = 100;
        }

        static void ChangeByReference(ref int x)
        {
            x = 100;
        }

        static void ChangePersonByValue(Person p)
        {
            p = new Person();
            p.Name = "Ali";
        }

        static void ChangePersonByReference(ref Person p)
        {
            p = new Person();
            p.Name = "Ali";
        }

        static (int sum, int subtract) Calculate(int num1, int num2, int num3, int num4)
        {
            int sum = num1 + num2 + num3 + num4;
            int subtract = num1 - num2 - num3 - num4;
            return (sum, subtract);
        }

        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sum = sum + digit;
                number = number / 10;
            }
            return sum;
        }

        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        static void MinMaxArray(int[] numbers, ref int min, ref int max)
        {
            min = numbers[0];
            max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min) min = numbers[i];
                if (numbers[i] > max) max = numbers[i];
            }
        }

        static int Factorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result = result * i;
            }
            return result;
        }

        static string ChangeChar(string text, int position, char newChar)
        {
            char[] characters = text.ToCharArray();
            characters[position] = newChar;
            return new string(characters);
        }

        static void Main()
        {
            // ====================================================
            // PART 1
            // ====================================================
            Console.WriteLine("========================================");
            Console.WriteLine("PART 1");
            Console.WriteLine("Value Type Parameters");
            Console.WriteLine("========================================");

            int number1 = 10;
            int number2 = 10;

            ChangeByValue(number1);
            ChangeByReference(ref number2);

            Console.WriteLine("After Pass by Value: " + number1);
            Console.WriteLine("After Pass by Reference: " + number2);
            Console.WriteLine();

            // ====================================================
            // PART 2
            // ====================================================
            Console.WriteLine("========================================");
            Console.WriteLine("PART 2");
            Console.WriteLine("Reference Type Parameters");
            Console.WriteLine("========================================");

            Person person1 = new Person();
            person1.Name = "Ahmed";

            Person person2 = new Person();
            person2.Name = "Ahmed";

            ChangePersonByValue(person1);
            ChangePersonByReference(ref person2);

            Console.WriteLine("Pass by Value: " + person1.Name);
            Console.WriteLine("Pass by Reference: " + person2.Name);
            Console.WriteLine();

            // ====================================================
            // PART 3
            // ====================================================
            Console.WriteLine("========================================");
            Console.WriteLine("PART 3");
            Console.WriteLine("Four Parameters");
            Console.WriteLine("========================================");

            Console.Write("Enter number 1: ");
            int num1 = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter number 2: ");
            int num2 = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter number 3: ");
            int num3 = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter number 4: ");
            int num4 = int.Parse(Console.ReadLine() ?? "0");

            var calculation = Calculate(num1, num2, num3, num4);

            Console.WriteLine("Summation = " + calculation.sum);
            Console.WriteLine("Subtraction = " + calculation.subtract);
            Console.WriteLine();

            // ====================================================
            // PART 4
            // ====================================================
            Console.WriteLine("========================================");
            Console.WriteLine("PART 4");
            Console.WriteLine("Sum of Individual Digits");
            Console.WriteLine("========================================");

            Console.Write("Enter a number: ");
            int digitNumber = int.Parse(Console.ReadLine() ?? "0");

            int digitResult = SumOfDigits(digitNumber);

            Console.WriteLine("The sum of the digits of the number " + digitNumber + " is: " + digitResult);
            Console.WriteLine();

            // ====================================================
            // PART 5
            // ====================================================
            Console.WriteLine("========================================");
            Console.WriteLine("PART 5");
            Console.WriteLine("IsPrime");
            Console.WriteLine("========================================");

            Console.Write("Enter a number: ");
            int primeNumber = int.Parse(Console.ReadLine() ?? "0");

            if (IsPrime(primeNumber))
            {
                Console.WriteLine("The number is Prime.");
            }
            else
            {
                Console.WriteLine("The number is not Prime.");
            }
            Console.WriteLine();

            // ====================================================
            // PART 6
            // ====================================================
            Console.WriteLine("========================================");
            Console.WriteLine("PART 6");
            Console.WriteLine("MinMaxArray");
            Console.WriteLine("========================================");

            int[] numbers = { 5, 2, 9, 1, 7 };
            int min = 0;
            int max = 0;

            MinMaxArray(numbers, ref min, ref max);

            Console.WriteLine("Array: 5, 2, 9, 1, 7");
            Console.WriteLine("Minimum = " + min);
            Console.WriteLine("Maximum = " + max);
            Console.WriteLine();

            // ====================================================
            // PART 7
            // ====================================================
            Console.WriteLine("========================================");
            Console.WriteLine("PART 7");
            Console.WriteLine("Factorial");
            Console.WriteLine("========================================");

            Console.Write("Enter a number: ");
            int factorialNumber = int.Parse(Console.ReadLine() ?? "0");

            int factorialResult = Factorial(factorialNumber);

            Console.WriteLine("Factorial of " + factorialNumber + " = " + factorialResult);
            Console.WriteLine();

            // ====================================================
            // PART 8
            // ====================================================
            Console.WriteLine("========================================");
            Console.WriteLine("PART 8");
            Console.WriteLine("ChangeChar");
            Console.WriteLine("========================================");

            Console.Write("Enter a string: ");
            string text = Console.ReadLine() ?? "";

            Console.Write("Enter position (0 based): ");
            int position = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter new character: ");
            char newChar = char.Parse(Console.ReadLine() ?? "a");

            string changedText = ChangeChar(text, position, newChar);
            Console.WriteLine("Result: " + changedText);
            Console.WriteLine();

            // ====================================================
            // PART 9
            // ====================================================
            Console.WriteLine("========================================");
            Console.WriteLine("PART 9");
            Console.WriteLine("WeekDays Enum");
            Console.WriteLine("========================================");

            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            Console.WriteLine();

            // ====================================================
            // PART 10
            // ====================================================
            Console.WriteLine("========================================");
            Console.WriteLine("PART 10");
            Console.WriteLine("Person Struct");
            Console.WriteLine("========================================");

            PersonData[] people = new PersonData[3];
            people[0].Name = "Ahmed"; people[0].Age = 20;
            people[1].Name = "Ali"; people[1].Age = 22;
            people[2].Name = "Omar"; people[2].Age = 19;

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine("Name: " + people[i].Name);
                Console.WriteLine("Age: " + people[i].Age);
                Console.WriteLine();
            }

            // ====================================================
            // PART 11
            // ====================================================
            Console.WriteLine("========================================");
            Console.WriteLine("PART 11");
            Console.WriteLine("Season Enum");
            Console.WriteLine("========================================");

            Console.Write("Enter season: ");
            string seasonInput = Console.ReadLine() ?? "";
            Season season;

            if (Enum.TryParse(seasonInput, true, out season))
            {
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("December to February");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid season.");
            }
            Console.WriteLine();

            // ====================================================
            // PART 12
            // ====================================================
            Console.WriteLine("========================================");
            Console.WriteLine("PART 12");
            Console.WriteLine("Permissions Enum");
            Console.WriteLine("========================================");

            Permissions permissions = Permissions.None;
            permissions = permissions | Permissions.Read;
            permissions = permissions | Permissions.Write;
            permissions = permissions | Permissions.Execute;

            Console.WriteLine("Current Permissions: " + permissions);

            if ((permissions & Permissions.Read) == Permissions.Read)
            {
                Console.WriteLine("Read permission exists.");
            }

            permissions = permissions & ~Permissions.Write;
            Console.WriteLine("After removing Write: " + permissions);

            if ((permissions & Permissions.Write) == Permissions.Write)
            {
                Console.WriteLine("Write permission exists.");
            }
            else
            {
                Console.WriteLine("Write permission does not exist.");
            }
            Console.WriteLine();

            // ====================================================
            // PART 13
            // ====================================================
            Console.WriteLine("========================================");
            Console.WriteLine("PART 13");
            Console.WriteLine("Colors Enum");
            Console.WriteLine("========================================");

            Console.Write("Enter a color: ");
            string colorInput = Console.ReadLine() ?? "";
            Colors color;

            if (Enum.TryParse(colorInput, true, out color))
            {
                Console.WriteLine(color + " is a primary color.");
            }
            else
            {
                Console.WriteLine("This is not a primary color.");
            }
            Console.WriteLine();

            // ====================================================
            // PART 14
            // ====================================================
            Console.WriteLine("========================================");
            Console.WriteLine("PART 14");
            Console.WriteLine("Point and Distance");
            Console.WriteLine("========================================");

            Point point1;
            Point point2;

            Console.Write("Enter X1: ");
            point1.X = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter Y1: ");
            point1.Y = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter X2: ");
            point2.X = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter Y2: ");
            point2.Y = double.Parse(Console.ReadLine() ?? "0");

            double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
            Console.WriteLine("Distance = " + distance);
            Console.WriteLine();

            // ====================================================
            // PART 15
            // ====================================================
            Console.WriteLine("========================================");
            Console.WriteLine("PART 15");
            Console.WriteLine("Oldest Person");
            Console.WriteLine("========================================");

            PersonData[] persons = new PersonData[3];

            for (int i = 0; i < persons.Length; i++)
            {
                Console.Write("Enter name of person " + (i + 1) + ": ");
                persons[i].Name = Console.ReadLine() ?? "";

                Console.Write("Enter age of person " + (i + 1) + ": ");
                persons[i].Age = int.Parse(Console.ReadLine() ?? "0");
            }

            PersonData oldest = persons[0];

            for (int i = 1; i < persons.Length; i++)
            {
                if (persons[i].Age > oldest.Age)
                {
                    oldest = persons[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Oldest person is: " + oldest.Name);
            Console.WriteLine("Age: " + oldest.Age);
            Console.WriteLine();

            Console.WriteLine("========================================");
            Console.WriteLine("Assignment Finished");
            Console.WriteLine("========================================");
        }
    }
}