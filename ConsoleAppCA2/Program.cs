namespace ConsoleAppCA2
{
    class Program
    {
        static void Main(string[] args)
        {
            navigacija();

        }
        static void navigacija()
        {
            while (true)
            {

                //Console.WriteLine("Issirinkite uzduoti nuo 1 iki 10: ");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=TEMOS=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("1. System.String");
                Console.WriteLine("2. Conditionals - If");
                Console.WriteLine("3. Switch Case");
                Console.WriteLine("4. String Manipuliacija");
                Console.WriteLine("5. Ciklai - While");
                Console.WriteLine("6. Meetodai");
                Console.WriteLine("7. ...");
                Console.WriteLine("8. ..");
                Console.WriteLine("9. .");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                string slct = Console.ReadLine();

                switch (slct)
                {
                    case "6":
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=UZDUOTYS=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("PASIRINKITE UZDUOTI NUO 25 IKI 27 ARBA PROJEKTAS");
                        slct = Console.ReadLine();
                        switch (slct)
                        {
                            case "25":
                                uzduotis25();
                                break;
                            case "26":
                                uzduotis26();
                                break;
                            case "27":
                                uzduotis27();
                                break;
                            default:
                                Console.WriteLine("blogas pasirinkimas");
                                break;
                        }
                        break;
                    case "7":
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=NERA!=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        break;
                    case "8":
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=NERA!=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        break;
                    default:
                        Console.WriteLine("blogas pasirinkimas");
                        break;
                }
            }
        }

        #region Metodai
        static void uzduotis25()
        {
            while (true)
            {
                Console.WriteLine("Choose an app: ");
                Console.WriteLine("1. Pass checker program");
                Console.WriteLine("2. Email valid program");
                Console.WriteLine("3. Exchange program");
                var ab = Console.ReadLine();
                if (ab == "q") break;
                int xb = int.Parse(ab);

                if (xb == 1)
                {
                    Console.WriteLine("----------------------------------------------------");
                    while (true)
                    {
                        Console.Write("Enter a password:");
                        var miau = Console.ReadLine();
                        if (miau == "q") break;
                        if (!IsPasswordvalid(miau))
                        {
                            Console.WriteLine("Try again!");
                        }
                        else Console.WriteLine("Gratz, pass is aukei!");
                    }
                    Console.WriteLine("----------------------------------------------------");
                }
                if (xb == 2)
                {
                    Console.WriteLine("----------------------------------------------------");
                    while (true)
                    {
                        Console.Write("Enter an email address: ");
                        var miau = Console.ReadLine();
                        if (miau == "q") break;

                        bool isValid = IsEmailValid(miau);

                        Console.WriteLine(isValid ? "The email address is not valid." : "The email address is valid.");
                    }
                    Console.WriteLine("----------------------------------------------------");
                }
                if (xb == 3)
                {
                    Console.WriteLine("----------------------------------------------------");
                    while (true)
                    {
                        Console.Write("Enter a dollar sum to be converted to euros: ");
                        var miau = Console.ReadLine();
                        if (miau == "q") break;
                        Console.WriteLine(ConvertToEuros(miau));
                    }
                    Console.WriteLine("----------------------------------------------------");
                }
            }
        }
        static void uzduotis26()
        {
            while (true)
            {
                Console.WriteLine("Choose an app: ");
                Console.WriteLine("1. Name Initials program");
                Console.WriteLine("2. Cylinder Radius program");
                Console.WriteLine("3. Even program");
                Console.WriteLine("4. Rectangle Area program");
                var ab = Console.ReadLine();
                if (ab == "q") break;
                int xb = int.Parse(ab);

                if (xb == 1)
                {
                    Console.WriteLine("----------------------------------------------------");
                    while (true)
                    {
                        Console.Write("Enter a name:");
                        var miau = Console.ReadLine();
                        if (miau == "q") break;

                        Console.Write("Enter a surname:");
                        var miau1 = Console.ReadLine();
                        if (miau1 == "q") break;

                        Console.WriteLine(GetInitials(miau, miau1));
                    }
                    Console.WriteLine("----------------------------------------------------");
                }
                if (xb == 2)
                {
                    Console.WriteLine("----------------------------------------------------");
                    while (true)
                    {
                        Console.Write("Enter a height:");
                        var miau = Console.ReadLine();
                        if (miau == "q") break;
                        double miau1 = double.Parse(miau);

                        Console.Write("Enter a radius:");
                        var auau = Console.ReadLine();
                        if (auau == "q") break;
                        double auau1 = double.Parse(auau);

                        Console.WriteLine(CalculateCylinderVolume(miau1, auau1));
                    }
                    Console.WriteLine("----------------------------------------------------");
                }
                if (xb == 3)
                {
                    Console.WriteLine("----------------------------------------------------");
                    while (true)
                    {
                        Console.Write("Enter a integer to check if it's even or not:");
                        var miau = Console.ReadLine();
                        if (miau == "q") break;
                        int miau1 = int.Parse(miau);
                        Console.WriteLine(IsNumberEven(miau1));
                    }
                    Console.WriteLine("----------------------------------------------------");
                }
                if (xb == 4)
                {
                    Console.WriteLine("----------------------------------------------------");
                    while (true)
                    {
                        Console.WriteLine("Enter a length and width to calculate rect area. ");
                        Console.Write("Length: ");
                        var miau = Console.ReadLine();
                        if (miau == "q") break;
                        double miau1 = double.Parse(miau);

                        Console.Write("Width: ");
                        var auau = Console.ReadLine();
                        if (auau == "q") break;
                        double auau1 = double.Parse(auau);

                        Console.WriteLine(CalculateRectangleArea(miau1, auau1));
                    }
                    Console.WriteLine("----------------------------------------------------");
                }
            }
        }
        static void uzduotis27()
        {
            while (true)
            {
                Console.WriteLine("Choose an app: ");
                Console.WriteLine("1. Factorial");
                Console.WriteLine("2. Fibonnaci");
                Console.WriteLine("3. Challange Recursion");
                var ab = Console.ReadLine();
                if (ab == "q") break;
                int xb = int.Parse(ab);

                if (xb == 1)
                {
                    Console.WriteLine("----------------------------------------------------");
                    Console.Write("Enter a non-negative integer: ");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("----------------------------------------------------");

                    if (n < 0)
                    {
                        Console.WriteLine("Factorial is undefined for negative numbers.");
                    }
                    else
                    {
                        long factorial = RecursionFactorial(n);
                        Console.WriteLine($"Factorial of {n} is {factorial}");
                    }
                    Console.WriteLine("---------------------------------------------------");
                }

                if (xb == 2)
                {
                    Console.WriteLine("---------------------------------------------------");
                    Console.Write("Enter the number of Fibonacci numbers to generate: ");
                    int n = int.Parse(Console.ReadLine());

                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("Fibonacci Sequence:");

                    for (int i = 0; i < n; i++)
                    {
                        long fibonacciNumber = RecursionFibonacci(i);
                        Console.Write($"{fibonacciNumber} ");
                    }
                    Console.WriteLine("\n---------------------------------------------------");
                }

                if (xb == 3)
                {
                    Console.WriteLine("---------------------------------------------------");
                    Console.Write("Enter the position (n) of the Tribonacci number to calculate: ");
                    int n = int.Parse(Console.ReadLine());

                    Console.WriteLine("---------------------------------------------------");
                    if (n < 0)
                    {
                        Console.WriteLine("Please enter a non-negative integer.");
                    }
                    else
                    {
                        Console.WriteLine("Tribonacci Sequence:");
                        for (int i = 0; i < n; i++)
                        {
                            long tribonacciNumber = RecursionTribonacci(i);
                            Console.Write($"{tribonacciNumber} ");
                        }
                    }
                    Console.WriteLine("\n---------------------------------------------------");
                }
            }
        }
        #region PatysMetodai
        static bool IsPasswordvalid(string password)
        {
            bool yo = true;
            return password.Length > 8 ? yo : !yo;
        }

        static bool IsEmailValid(string email)
        {
            if (email.Contains("@") && email.Contains("."))                                                         // Check if the email contains "@" and "."
            {
                int atIndex = email.IndexOf("@");
                int dotIndex = email.LastIndexOf(".");                                                              // Check if "@" appears before "."

                if (atIndex < dotIndex)
                {
                    if (atIndex > 0 && dotIndex < email.Length - 1)                                                 // Check if there's at least one character before "@" and after "."
                    {
                        return false;                                                                               // The email is valid
                    }
                }
            }

            return true;                                                                                            // The email is not valid
        }

        static double ConvertToEuros(string eur)
        {
            bool isValid = double.TryParse(eur, out double eurC);
            double convRate = 0.85;

            if (isValid)
            {
                return eurC * convRate;
            }
            else Console.WriteLine("It is not a number! ");
            return -1;
        }
        static string GetInitials(string firstName, string lastName)
        {
            string fullName = $"Hello there, {firstName} {lastName}! Nice To meet you!";                            // Concatenate the first name, a space, and the last name

            return fullName;
        }
        static double CalculateCylinderVolume(double radius, double height)
        {
            double volume = Math.PI * Math.Pow(radius, 2) * height;                                                 // Calculate the volume of a cylinder: π * r^2 * h
            return volume;
        }

        static bool IsNumberEven(int number)
        {
            return number % 2 == 0;                                                                                 // Check if a number is even
        }

        static double CalculateRectangleArea(double length, double width)
        {
            double area = length * width;                                                                           // Calculate the area of a rectangle: length * width
            return area;
        }
        static long RecursionFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;                                                                                           // Base case: 0! and 1! are both 1
            }
            else
            {
                return n * RecursionFactorial(n - 1);                                                               // Recursive case
            }
        }
        static long RecursionFibonacci(int n)
        {
            if (n <= 1)
            {
                return n;                                                                                           // Base case: Fibonacci(0) = 0, Fibonacci(1) = 1
            }
            else
            {
                return RecursionFibonacci(n - 1) + RecursionFibonacci(n - 2);                                       // Recursive case
            }
        }
        static long RecursionTribonacci(int n)
        {
            if (n == 0)
            {
                return 0;                                                                                           // Base case: Tribonacci(0) = 0
            }
            else if (n == 1 || n == 2)
            {
                return 1;                                                                                           // Base cases: Tribonacci(1) = 1, Tribonacci(2) = 1
            }
            else
            {
                return RecursionTribonacci(n - 1) + RecursionTribonacci(n - 2) + RecursionTribonacci(n - 3);        // Recursive case: Tribonacci(n) = Tribonacci(n-1) + Tribonacci(n-2) + Tribonacci(n-3)
            }
        }
        #endregion
        #endregion

        #region UnitTesting
        static void uzduotis28()
        {

        }
        #endregion
    }
}