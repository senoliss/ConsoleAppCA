using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Channels;
using System.Net.Http;

namespace ConsoleAppCA
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
                Console.WriteLine("Issirinkite uzduoti nuo 1 iki 12: ");
                string slct = Console.ReadLine();

                //try
                //{
                //    slct = Int32.Parse(Console.ReadLine());
                //}
                //catch
                //{
                //    Console.WriteLine("Wrong Selection! ");

                //    if(slct.ToString() == "projektas")
                //    {
                //        Console.Write("do you want to open IF PROJECT? y/n: ");
                //        string selection = Console.ReadLine();

                //        if (selection == "y")
                //        {
                //            projektas();
                //        }

                //        else if (selection == "n")
                //        {
                //            Console.WriteLine("bye bye");
                //            navigacija();
                //        }
                //    }
                //}
                switch (slct)
                {
                    case "1":
                        uzduotis1();
                        break;

                    case "2":
                        uzduotis2();
                        break;

                    case "3":
                        uzduotis3();
                        break;

                    case "4":
                        uzduotis4();
                        break;

                    case "5":
                        uzduotis5();
                        break;

                    case "6":
                        uzduotis6();
                        break;

                    case "7":
                        uzduotis7();
                        break;

                    case "8":
                        uzduotis8();
                        break;

                    case "9":
                        uzduotis9();
                        break;

                    case "10":
                        uzduotis10();
                        break;

                    case "projektas":
                        projektas();
                        break;
                    case "11":
                        uzduotis11();
                        break;
                    case "12":
                        uzduotis12();
                        break;
                    case "13":
                        uzduotis13();
                        break;

                    default:
                        Console.WriteLine("blogas pasirinkimas");
                        break;
                }

                //if (slct == 1) uzduotis1();
                //else if (slct == 2) uzduotis2();
                //else if (slct == 3) uzduotis3();
                //else if (slct == 4) uzduotis4();
                //else if (slct == 5) uzduotis5();
                //else if (slct == 6) uzduotis6();
                //else if (slct == 7) uzduotis7();
                //else if (slct == 8) uzduotis8();
                //else if (slct == 9) uzduotis9();
                //else if (slct == 10) uzduotis10();
                //else if (slct > 10) Console.WriteLine("Wong Selection!");
            }
        }
        #region IfStatementUzduotys
        static void uzduotis1()
        {
            Console.WriteLine("nebaigta! go back to menu press 'q': ");
            string ab = Console.ReadLine();
            if (ab == "q")
            {
                navigacija();
            }
        }
        static void uzduotis2()
        {
            Console.WriteLine("nebaigta! go back to menu press 'q': ");
            string ab = Console.ReadLine();
            if (ab == "q")
            {
                navigacija();
            }
        }
        static void uzduotis3()
        {
            Console.WriteLine("nebaigta! go back to menu press 'q': ");
            string ab = Console.ReadLine();
            if (ab == "q")
            {
                navigacija();
            }
        }
        static void uzduotis4()
        {

            // -Parašykite C# programą, kuri patikrintų vartotojo įvestą amžių ir išvestų tinkamą pranešimą pagal šią logiką:
            // -Jei amžius yra mažesnis nei 18, išveskite žinutę „Jums priklauso nepilnamečio akcija".
            // -Jei amžius yra tarp 18 ir 65, išveskite žinutę "Jūs esate suaugęs". (Naudodami &&)
            // -Jei amžius yra didesnis arba lygus 65, išveskite žinutę „Jums priklauso senioro akcija".


            while (true)
            {
                Console.Write("Hello! Please enter your age, to see if you can get a discount! - ");
                //int age = Convert.ToInt32(Console.ReadLine());
                string strAge = Console.ReadLine();
                if (int.TryParse(strAge, out int age))
                {
                    // insterad of IF's i'm using here a ternary operator which takes condition before ? if it is true it returns first statement if not second
                    Console.WriteLine(age < 18 ? "Hooray! You get a discount for underage person!" :
                    age < 65 ? "Mister or Miss, you're an adult..." :
                    "Dear, Sir or Madame, you are eligible for senior discount!");
                }
                else if (strAge == "q")
                {
                    navigacija();
                    break;
                }
                else { Console.WriteLine("Wrong input!"); }

            }
        }
        static void uzduotis5()
        {
            //  -Parašykite C# programą, kuri patikrintų vartotojo įvestą metų skaičių ir nustatytų, ar tai yra keliamieji metai pagal šią logiką:
            //  -Jei metų skaičius dalinasi iš 4, bet nesidalina iš 100 arba dalinasi iš 400, išveskite žinutę "Tai yra keliamieji metai".
            //  -Kitais atvejais, išveskite žinutę "Tai nėra keliamieji metai".


            while (true)
            {
                Console.Write("Hello, to check if the year is 'Leap year' please enter the year: ");

                string strYrs = Console.ReadLine();
                if (int.TryParse(strYrs, out int yrs))
                {
                    bool leapYrs = yrs % 4 == 0 && yrs % 100 != 0;

                    if (leapYrs || yrs % 400 == 0)
                    {
                        Console.WriteLine("Hooray, the entered year '" + strYrs + "' is a Leap Year!");
                    }

                    else
                    {
                        Console.WriteLine("Sadly, the entered year '" + strYrs + "' is not a Leap Year...");
                    }
                }
                else { Console.WriteLine("Wron input, not a number..."); }
            }
        }
        static void uzduotis6()
        {
            Dictionary<string, double> menu = new Dictionary<string, double>
            {
                { "1L Pieno", 1.50 },
                { "Pintine kiaushiniu", 2.00 },
                { "1kg obuoliu", 3.50 },
                { "250g Shilauogiu", 1.20 },
                { "Dedes viralo kibirukas", 4.00 },
                { "500g Surio", 2.50 },
                { "Babos tapkes", 3.00 }
            };

            List<string> basket = new List<string>();
            int tri = 0;
            double basketTotal = 0;

            Console.WriteLine("===================== E-Farm Menu =====================");
            int nr = 1;
            foreach (var v in menu)
            {
                Console.WriteLine($"{nr}. {v.Key} - ${v.Value}");
                nr++;
            }
            Console.WriteLine("=======================================================");

            while (tri < 3)
            {

                Console.Write("Which product would you like?: ");
                int slcIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                if (slcIndex < 0 || slcIndex >= menu.Count)
                {
                    Console.WriteLine("Selected product does not exist!");
                    continue;
                }

                string selectedProduct = menu.Keys.ToArray()[slcIndex];
                double selectedPrice = menu[selectedProduct];

                basketTotal += selectedPrice;
                basket.Add(selectedProduct);

                Console.WriteLine($"{selectedProduct} added to cart.");
                tri++;
            }

            bool hasLoyaltyCard = false;
            Console.Write("Do you have a loyalty card? (y/n): ");
            string loyaltyResponse = Console.ReadLine().ToLower();
            if (loyaltyResponse == "y")
            {
                hasLoyaltyCard = true;
            }

            double discountPercentage = 0;
            #region firstDiscount
            //bool tenProc = basket[0] == basket[1] || basket[0] == basket[2] || basket[1] == basket[2];
            //bool qrtProc = basket[0] == basket[1] && basket[0] == basket[2];

            //if (tenProc)
            //{
            //    discountPercentage = 0.10;
            //    if (hasLoyaltyCard)
            //    {
            //        discountPercentage += 0.10;
            //    }
            //}
            //if (qrtProc)
            //{
            //    discountPercentage = 0.15;
            //    if (hasLoyaltyCard)
            //    {
            //        discountPercentage += 0.10;
            //    }
            //}
            #endregion

            #region adittionalDiscount
            bool twoSame = basket[0] == basket[1] || basket[0] == basket[2] || basket[1] == basket[2];
            bool qrtProc = basket[0] == basket[1] && basket[0] == basket[2];
            double finalTotal = 0;

            if (twoSame)
            {
                double newPrice = 0;
                if (basket[0] == basket[1])
                {
                    newPrice = menu[basket[1]] * 0.9 * 2;
                    finalTotal += newPrice + menu[basket[2]];

                    if (hasLoyaltyCard)
                    {
                        finalTotal *= 0.9;
                    }
                }

                else if (basket[1] == basket[2])
                {
                    newPrice = menu[basket[1]] * 0.9 * 2;
                    finalTotal += newPrice + menu[basket[0]];

                    if (hasLoyaltyCard)
                    {
                        finalTotal *= 0.9;
                    }
                }

                else if (basket[0] == basket[2])
                {
                    newPrice = menu[basket[0]] * 0.9 * 2;
                    finalTotal += newPrice + menu[basket[1]];

                    if (hasLoyaltyCard)
                    {
                        finalTotal *= 0.9;
                    }
                }

            }

            if (qrtProc)
            {
                finalTotal = 0;
                discountPercentage = 0.15;
                if (hasLoyaltyCard)
                {
                    discountPercentage += 0.10;
                }
                finalTotal += menu[basket[1]] * 3 * (1 - discountPercentage);
            }
            #endregion


            double totalDiscount = basketTotal - finalTotal;

            Console.WriteLine("======================= Receipt =======================");
            Console.WriteLine($"Number of products: {basket.Count}");
            Console.WriteLine($"Basket total: ${basketTotal}");
            Console.WriteLine($"Total discount: ${totalDiscount}");
            Console.WriteLine($"Final total: ${finalTotal}");

            foreach (var a in basket)
            {
                Console.WriteLine(a);
            }
        }
        static void uzduotis7()
        {
            Console.WriteLine("nebaigta! go back to menu press 'q': ");
            string ab = Console.ReadLine();
            if (ab == "q")
            {
                navigacija();
            }
        }
        static void uzduotis8()
        {
            Console.WriteLine("nebaigta! go back to menu press 'q': ");
            string ab = Console.ReadLine();
            if (ab == "q")
            {
                navigacija();
            }
        }
        static void uzduotis9()
        {
            Console.WriteLine("nebaigta! go back to menu press 'q': ");
            string ab = Console.ReadLine();
            if (ab == "q")
            {
                navigacija();
            }
        }
        static void uzduotis10()
        {
            Console.WriteLine("nebaigta! go back to menu press 'q': ");
            string ab = Console.ReadLine();
            if (ab == "q")
            {
                navigacija();
            }
        }
        static void projektas()
        {
            Console.WriteLine("=======================SVEIKI ATVYKE I PROJEKTA=======================");
            Console.WriteLine();
            Console.WriteLine("======================================================================");

            Console.WriteLine("nebaigta! go back to menu press 'q': ");
            string ab = Console.ReadLine();
            if (ab == "q")
            {
                navigacija();
            }
        }
        #endregion
        static void uzduotis11()
        {
            while (true)
            {
                while (true)
                {
                    Console.Write("Iveskite menesio numeri skaitmenisku pavidalu (1-12) :");
                    var miau = Console.ReadLine();
                    if (miau == "q") break;
                    int miauS = int.Parse(miau);

                    var result = miauS switch
                    {
                        1 => "Sausis",
                        2 => "Vasaris",
                        3 => "Kovas",
                        4 => "Balandis",
                        5 => "Geguze",
                        6 => "Birzelis",
                        7 => "Liepa",
                        8 => "Rugpjutis",
                        9 => "Rugsejis",
                        10 => "Spalis",
                        11 => "Lapkritis",
                        12 => "Gruodis",
                        _ => "Menesis neegzistuoja"
                    };
                    Console.WriteLine(result);
                }
                var ab = Console.ReadLine();
                if (ab == "q") break;
                int xb = int.Parse(ab);

                if (xb == 1)
                {
                    while (true)
                    {
                        Console.Write("Iveskite savaites diena skaitmenisku pavidalu (1-7) :");
                        var miau = Console.ReadLine();
                        if (miau == "q") break;
                        int miauS = int.Parse(miau);

                        var result = miauS switch
                        {
                            1 => "Pirmadienis",
                            2 => "Antradienis",
                            3 => "Treciadienis",
                            4 => "Ketvirtadienis",
                            5 => "Penktadienis",
                            6 => "Sestadienis",
                            7 => "Sekmadieinis",
                            _ => "Savaites diena neegzistuoja"
                        };
                        Console.WriteLine(result);
                    }
                }

                else if (xb == 2)
                {
                    while (true)
                    {
                        Console.Write("Iveskite savo amziu skaitmenisku pavidalu :");
                        var miau = Console.ReadLine();
                        if (miau == "q") break;
                        int miauS = int.Parse(miau);

                        var result = miauS switch
                        {
                            < 1 => "Negimes",
                            < 7 => "Vaikas",
                            < 18 => "Moksleivis",
                            < 25 => "Studentas",
                            < 65 => "Darbuotojas",
                            > 66 => "Pensininkas",
                            _ => "Wrong"
                        };
                        Console.WriteLine(result);
                    }
                }

                else if (xb == 3)
                {
                    while (true)
                    {
                        Console.Write("Iveskite menesio numeri skaitmenisku pavidalu (1-12) :");
                        var miau = Console.ReadLine();
                        if (miau == "q") break;
                        int miauS = int.Parse(miau);

                        var result = miauS switch
                        {
                            1 => "Sausis",
                            2 => "Vasaris",
                            3 => "Kovas",
                            4 => "Balandis",
                            5 => "Geguze",
                            6 => "Birzelis",
                            7 => "Liepa",
                            8 => "Rugpjutis",
                            9 => "Rugsejis",
                            10 => "Spalis",
                            11 => "Lapkritis",
                            12 => "Gruodis",
                            _ => "Menesis neegzistuoja"
                        };
                        Console.WriteLine(result);
                    }
                }
            }



            //switch(miau)
            //{
            //    case "1":
            //        // do this
            //    break;
            //}
        }
        static void uzduotis12()
        {
            while (true)
            {
                Console.WriteLine("Pasirinkite kuria programa norite naudoti: ");
                Console.WriteLine("1. Geometriniu figuru programa");
                Console.WriteLine("2. Pagrindiniu elementu programa");
                Console.WriteLine("3. Universitetu specialybiu programa");
                var ab = Console.ReadLine();
                if (ab == "q") break;
                int xb = int.Parse(ab);     // reikia paparsinti taip kad pasirinkus kazka kito nei 1-3 arba 'q' mstu blogas pasirinkimas

                if (xb == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("Pasirinkite viena is keturiu geometriniu figuru, " +
                                "ivesdami pirmaja raide: \nkvadratas - k, apskritimas - a, " +
                                "trikampis - t, staciakampis - s");

                        string miau = Console.ReadLine();

                        if (miau == "q") break;

                        switch (miau)
                        {
                            case "k":
                                Console.WriteLine("Iveskite kvadrato krastine: ");
                                int krastine = int.Parse(Console.ReadLine());
                                krastine *= krastine;
                                Console.WriteLine("Pasirinkto kvadrato plotas yra: " + krastine);
                                break;

                            case "a":
                                Console.WriteLine("Iveskite apskritimo spinduli: ");
                                int spindulys = int.Parse(Console.ReadLine());
                                //spindulys = Convert.ToDouble((spindulys^2*3.141592));
                                double apskrPlot = Math.Pow(spindulys, 2) * 3.141592;
                                Console.WriteLine("Pasirinkto apskritimo plotas yra: " + apskrPlot);
                                break;

                            case "t":
                                Console.WriteLine("Iveskite trikampio aukstine: ");
                                int krastine3 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Iveskite trikampio pagrinda: ");
                                int krastine4 = int.Parse(Console.ReadLine());
                                int plotas = (krastine3 * krastine4) / 2;
                                Console.WriteLine("Pasirinkto trikampio plotas yra: " + plotas);
                                break;

                            case "s":
                                Console.WriteLine("Iveskite staciakampio ilgi: ");
                                int krastine5 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Iveskite staciakampio ploti: ");
                                int krastine6 = int.Parse(Console.ReadLine());
                                krastine5 *= krastine6;
                                Console.WriteLine("Pasirinkto staciakampio plotas yra: " + krastine5);
                                break;

                            default:
                                Console.WriteLine("Wrong input!");
                                break;
                        }
                    }
                }
                if (xb == 2)
                {
                    while (true)
                    {
                        Console.WriteLine("Pasirinkite viena is penkiu pagrindiniu elementu: ");
                        Console.Write("Ugnis - u, Vanduo - v, Oras - o, Zeme - z, Eteris - e: ");
                        var miau = Console.ReadLine();
                        if (miau == "q") break;
                        var info = miau switch
                        {
                            "u" => "Fire represents light, heat, energy, metabolism, and the power of transformation.",
                            "v" => "This element fosters modesty and sensibility. " +
                            "\nWater is associated with wisdom, stamina and endurance.",
                            "o" => "When we think of air, we often think of communication, breath, and life. " +
                            "\nLightness, motion, intelligence, knowledge, learning, thinking, imagination, " +
                            "\ncreativity, harmony, perception, and strategy also represent this element.",
                            "z" => "The Earth element represents solid matter and the structure of the universe.",
                            "e" => "Ether is cold because it lacks the warmth of the fire, " +
                            "\nit is light in weight as it lacks the heaviness of earth and water, " +
                            "\nand it is immobile as it lacks the mobility and fluid nature of air.",
                            _ => "Blogas pasirinkimas"
                        };
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine(info);
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    }
                }
                if (xb == 3)
                {
                    while (true)
                    {
                        Console.WriteLine("Atejo metas rinktis studijas! Stai jusu pasirinkimai:");
                        List<string> studijos = new List<string>() { "Taikomoji Matematika", "Informacines Technologijos", "Mechanine Biologija", "Farmacijos Chemija" };

                        for (int i = 1; i <= studijos.Count; i++) // 1 2 3 4
                        {
                            Console.WriteLine(i + ". " + studijos[i - 1]);
                        }

                        var miau = Console.ReadLine();

                        if (miau == "q") break;

                        int miauS = int.Parse(miau);

                        switch (miauS)
                        {
                            case 1:

                                Console.WriteLine("Iveskite keturiu valstybiniu egzaminu rezultatus 100 balu skaleje ir spauskite 'Enter'.");
                                Console.WriteLine("Reikalingi egzaminai norint studijuoti Taikomaja Matematika: ");

                                // klausimynas egzaminai
                                Console.WriteLine("----------------------------------------------------------------------------------------");
                                Console.Write("Matematika (0.4 balo) - ");
                                int mat = int.Parse(Console.ReadLine());

                                Console.Write("Anglu kalba (0.125 balo) - ");
                                int ang = int.Parse(Console.ReadLine());

                                Console.Write("Lietuviu kalba (0.125 balo) - ");
                                int ltu = int.Parse(Console.ReadLine());

                                Console.Write("Informatika (0.2 balo) - ");
                                int itt = int.Parse(Console.ReadLine());

                                Console.Write("Papildomas egzaminas: Fizika (+0.1 balo) - ");
                                int fiz = int.Parse(Console.ReadLine());

                                Console.Write("Ar esate baiges privalomaja karo tarnyba? (x0.1 balu) y/n : ");
                                string pow = Console.ReadLine();
                                Console.WriteLine("----------------------------------------------------------------------------------------");

                                // skaiciavimas
                                double result = mat * 0.4 + ang * 0.15 + ltu * 0.15 + itt * 0.3 + fiz * 0.1;

                                if (pow == "y")
                                {
                                    result *= 1.1;
                                    Console.WriteLine(" Jusu stojamasis balas: " + result + ". Reikalingas  balas istoti: 95");
                                    var svkn = result switch
                                    {
                                        < 94 => "Apgailestaujame, taciau jusu stojamasis balas yra per mazas... " + result + "...",
                                        < 99 => "SEIKINAME ISTOJUS I TAIKOMOSIOS MATEMATIKOS STUDIJAS!",
                                        _ => "SEIKINAME ISTOJUS I TAIKOMOSIOS MATEMATIKOS STUDIJAS!" +
                                             "Jusu balas yra daugiau nei 100! : " + result + " Sveikiname gavus PREZIDENTO STIPENDIJA!",
                                    };
                                    Console.WriteLine(svkn);
                                    Console.WriteLine("----------------------------------------------------------------------------------------");
                                }

                                else if (pow == "n")
                                {
                                    Console.WriteLine(" Jusu stojamasis balas: " + result + ". Reikalingas  balas istoti: 95");
                                    var svkn = result switch
                                    {
                                        < 94 => "Apgailestaujame, taciau jusu stojamasis balas yra per mazas... " + result + "...",
                                        < 99 => "SEIKINAME ISTOJUS I TAIKOMOSIOS MATEMATIKOS STUDIJAS!",
                                        _ => "SEIKINAME ISTOJUS I TAIKOMOSIOS MATEMATIKOS STUDIJAS!" +
                                             "\nJusu balas yra daugiau nei 100! : " + result +
                                             "\nSveikiname gavus PREZIDENTO STIPENDIJA!",
                                    };
                                    Console.WriteLine(svkn);
                                    Console.WriteLine("----------------------------------------------------------------------------------------");
                                }
                                break;

                            case 2:

                                Console.WriteLine("Iveskite keturiu valstybiniu egzaminu rezultatus 100 balu skaleje ir spauskite 'Enter'.");
                                Console.WriteLine("Reikalingi egzaminai norint studijuoti Informacines Technologijos: ");

                                // klausimynas egzaminai
                                Console.WriteLine("----------------------------------------------------------------------------------------");
                                Console.Write("Informatika (0.4 balo) - ");
                                mat = int.Parse(Console.ReadLine());

                                Console.Write("Anglu kalba (0.125 balo) - ");
                                ang = int.Parse(Console.ReadLine());

                                Console.Write("Lietuviu kalba (0.125 balo) - ");
                                ltu = int.Parse(Console.ReadLine());

                                Console.Write("Matematika (0.2 balo) - ");
                                itt = int.Parse(Console.ReadLine());

                                Console.Write("Papildomas egzaminas: Programavimas (+0.1 balo) - ");
                                fiz = int.Parse(Console.ReadLine());

                                Console.Write("Ar esate baiges privalomaja karo tarnyba? (x0.1 balu) y/n : ");
                                pow = Console.ReadLine();
                                Console.WriteLine("----------------------------------------------------------------------------------------");

                                // skaiciavimas
                                result = mat * 0.4 + ang * 0.15 + ltu * 0.15 + itt * 0.3 + fiz * 0.1;

                                if (pow == "y")
                                {
                                    result *= 1.1;
                                    Console.WriteLine(" Jusu stojamasis balas: " + result + ". Reikalingas  balas istoti: 95");
                                    var svkn = result switch
                                    {
                                        < 94 => "Apgailestaujame, taciau jusu stojamasis balas yra per mazas... " + result + "...",
                                        < 99 => "SEIKINAME ISTOJUS I IT STUDIJAS!",
                                        _ => "SEIKINAME ISTOJUS I IT STUDIJAS!" +
                                             "Jusu balas yra daugiau nei 100! : " + result + " Sveikiname gavus PREZIDENTO STIPENDIJA!",
                                    };
                                    Console.WriteLine(svkn);
                                    Console.WriteLine("----------------------------------------------------------------------------------------");
                                }

                                else if (pow == "n")
                                {
                                    Console.WriteLine(" Jusu stojamasis balas: " + result + ". Reikalingas  balas istoti: 95");
                                    var svkn = result switch
                                    {
                                        < 94 => "Apgailestaujame, taciau jusu stojamasis balas yra per mazas... " + result + "...",
                                        < 99 => "SEIKINAME ISTOJUS I IT STUDIJAS!",
                                        _ => "SEIKINAME ISTOJUS I IT STUDIJAS!" +
                                             "\nJusu balas yra daugiau nei 100! : " + result +
                                             "\nSveikiname gavus PREZIDENTO STIPENDIJA!",
                                    };
                                    Console.WriteLine(svkn);
                                    Console.WriteLine("----------------------------------------------------------------------------------------");
                                }
                                break;

                            case 3:

                                Console.WriteLine("Iveskite keturiu valstybiniu egzaminu rezultatus 100 balu skaleje ir spauskite 'Enter'.");
                                Console.WriteLine("Reikalingi egzaminai norint studijuoti Mechanine Biologija: ");

                                // klausimynas egzaminai
                                Console.WriteLine("----------------------------------------------------------------------------------------");
                                Console.Write("Biologija (0.4 balo) - ");
                                mat = int.Parse(Console.ReadLine());

                                Console.Write("Anglu kalba (0.125 balo) - ");
                                ang = int.Parse(Console.ReadLine());

                                Console.Write("Lietuviu kalba (0.125 balo) - ");
                                ltu = int.Parse(Console.ReadLine());

                                Console.Write("Chemija (0.2 balo) - ");
                                itt = int.Parse(Console.ReadLine());

                                Console.Write("Papildomas egzaminas: Informatika (+0.1 balo) - ");
                                fiz = int.Parse(Console.ReadLine());

                                Console.Write("Ar esate baiges privalomaja karo tarnyba? (x0.1 balu) y/n : ");
                                pow = Console.ReadLine();
                                Console.WriteLine("----------------------------------------------------------------------------------------");

                                // skaiciavimas
                                result = mat * 0.4 + ang * 0.15 + ltu * 0.15 + itt * 0.3 + fiz * 0.1;

                                if (pow == "y")
                                {
                                    result *= 1.1;
                                    Console.WriteLine(" Jusu stojamasis balas: " + result + ". Reikalingas  balas istoti: 95");
                                    var svkn = result switch
                                    {
                                        < 94 => "Apgailestaujame, taciau jusu stojamasis balas yra per mazas... " + result + "...",
                                        < 99 => "SEIKINAME ISTOJUS I MECHANINES BIOLOGIJOS STUDIJAS!",
                                        _ => "SEIKINAME ISTOJUS I MECHANINES BIOLOGIJOS STUDIJAS!" +
                                             "Jusu balas yra daugiau nei 100! : " + result + " Sveikiname gavus PREZIDENTO STIPENDIJA!",
                                    };
                                    Console.WriteLine(svkn);
                                    Console.WriteLine("----------------------------------------------------------------------------------------");
                                }

                                else if (pow == "n")
                                {
                                    Console.WriteLine(" Jusu stojamasis balas: " + result + ". Reikalingas  balas istoti: 95");
                                    var svkn = result switch
                                    {
                                        < 94 => "Apgailestaujame, taciau jusu stojamasis balas yra per mazas... " + result + "...",
                                        < 99 => "SEIKINAME ISTOJUS I MECHANINES BIOLOGIJOS STUDIJAS!",
                                        _ => "SEIKINAME ISTOJUS I MECHANINES BIOLOGIJOS STUDIJAS!" +
                                             "\nJusu balas yra daugiau nei 100! : " + result +
                                             "\nSveikiname gavus PREZIDENTO STIPENDIJA!",
                                    };
                                    Console.WriteLine(svkn);
                                    Console.WriteLine("----------------------------------------------------------------------------------------");
                                }
                                break;

                            case 4:

                                Console.WriteLine("Iveskite keturiu valstybiniu egzaminu rezultatus 100 balu skaleje ir spauskite 'Enter'.");
                                Console.WriteLine("Reikalingi egzaminai norint studijuoti Farmacijos Chemija: ");

                                // klausimynas egzaminai
                                Console.WriteLine("----------------------------------------------------------------------------------------");
                                Console.Write("Chemija (0.4 balo) - ");
                                mat = int.Parse(Console.ReadLine());

                                Console.Write("Biologija (0.2 balo) - ");
                                itt = int.Parse(Console.ReadLine());

                                Console.Write("Anglu kalba (0.125 balo) - ");
                                ang = int.Parse(Console.ReadLine());

                                Console.Write("Lietuviu kalba (0.125 balo) - ");
                                ltu = int.Parse(Console.ReadLine());

                                Console.Write("Papildomas egzaminas: Fizika (+0.1 balo) - ");
                                fiz = int.Parse(Console.ReadLine());

                                Console.Write("Ar esate baiges privalomaja karo tarnyba? (x0.1 balu) y/n : ");
                                pow = Console.ReadLine();
                                Console.WriteLine("----------------------------------------------------------------------------------------");

                                // skaiciavimas
                                result = mat * 0.4 + ang * 0.15 + ltu * 0.15 + itt * 0.3 + fiz * 0.1;

                                if (pow == "y")
                                {
                                    result *= 1.1;
                                    Console.WriteLine(" Jusu stojamasis balas: " + result + ". Reikalingas  balas istoti: 95");
                                    var svkn = result switch
                                    {
                                        < 94 => "Apgailestaujame, taciau jusu stojamasis balas yra per mazas... " + result + "...",
                                        < 99 => "SEIKINAME ISTOJUS I FARMACIJOS CHEMIJOS STUDIJAS!",
                                        _ => "SEIKINAME ISTOJUS I FARMACIJOS CHEMIJOS STUDIJAS!" +
                                             "Jusu balas yra daugiau nei 100! : " + result + " Sveikiname gavus PREZIDENTO STIPENDIJA!",
                                    };
                                    Console.WriteLine(svkn);
                                    Console.WriteLine("----------------------------------------------------------------------------------------");
                                }

                                else if (pow == "n")
                                {
                                    Console.WriteLine(" Jusu stojamasis balas: " + result + ". Reikalingas  balas istoti: 95");
                                    var svkn = result switch
                                    {
                                        < 94 => "Apgailestaujame, taciau jusu stojamasis balas yra per mazas... " + result + "...",
                                        < 99 => "SEIKINAME ISTOJUS I FARMACIJOS CHEMIJOS STUDIJAS!",
                                        _ => "SEIKINAME ISTOJUS I FARMACIJOS CHEMIJOS STUDIJAS!" +
                                             "\nJusu balas yra daugiau nei 100! : " + result +
                                             "\nSveikiname gavus PREZIDENTO STIPENDIJA!",
                                    };
                                    Console.WriteLine(svkn);
                                    Console.WriteLine("----------------------------------------------------------------------------------------");
                                }
                                break;
                        }
                    }
                }
                else Console.WriteLine("Wrong input!");
            }

            //string pasirinkimas = Console.ReadLine();


        }
        static void uzduotis13()
        {
            while (true)
            {
                Console.WriteLine("Pasirinkite kuria programa norite naudoti: ");
                Console.WriteLine("1. Metu sezonu programa");
                Console.WriteLine("2. Kalkulo programa");
                Console.WriteLine("3. Valiutu programa");
                var ab = Console.ReadLine();
                if (ab == "q") break;
                int xb = int.Parse(ab);

                if (xb == 1)
                {
                    while (true)
                    {
                        Console.Write("Iveskite menesio numeri (1-12) :");
                        var miau = Console.ReadLine();

                        if (miau == "q") break;

                        int miauS = int.Parse(miau);

                        var result = miauS switch
                        {
                            < 3 => "Ziema",
                            < 6 => "Pavasaris",
                            < 9 => "Vasara",
                            < 12 => "Ruduo",
                            < 13 => "Ziema",
                            _ => "Menesis neegzistuoja"
                        };
                        Console.WriteLine("Metu laikas yra - " + result);
                    }
                }
                if (xb == 2)
                {
                    while (true)
                    {
                        Console.Write("Pasirinkite viena is matematiniu veiksmu (1-6):");
                        List<string> funkcijos = new List<string>() { "Sudetis", "Atimtis", "Dalyba", "Daugyba", "Kelimas kvadratu", "Saknies traukimas" };

                        for (int i = 1; i <= funkcijos.Count; i++) // 1 2 3 4
                        {
                            Console.WriteLine(i + ". " + funkcijos[i - 1]);
                        }

                        var miau = Console.ReadLine();

                        if (miau == "q") break;

                        var a1 = Console.ReadLine();

                        if (a1 == "q") break;

                        var b1 = Console.ReadLine();

                        if (b1 == "q") break;

                        int miauS = int.Parse(miau);
                        int a2 = int.Parse(a1);
                        int b2 = int.Parse(b1);

                        switch (miauS)
                        {
                            case 1:
                                Console.WriteLine("Rezultatas: " + $"{a1} + {b1} = " + (a2 += b2).ToString());
                                break;
                            case 2:
                                Console.WriteLine("Rezultatas: " + $"{a1} - {b1} = " + (a2 -= b2).ToString());
                                break;
                            case 3:
                                Console.WriteLine("Rezultatas: " + $"{a1} / {b1} = " + (a2 /= b2).ToString());
                                break;
                            case 4:
                                Console.WriteLine("Rezultatas: " + $"{a1} x {b1} = " + (a2 *= b2).ToString());
                                break;
                            case 5:
                                Console.WriteLine("Rezultatas: " + $"{a1}^{b1} = " + (Math.Pow(a2, b2).ToString()));
                                break;
                            case 6:
                                Console.WriteLine("Rezultatas: " + $"{a1} saknis = " + (Math.Sqrt(a2).ToString()));
                                Console.WriteLine("Rezultatas: " + $"{b1} saknis = " + (Math.Sqrt(b2).ToString()));
                                break;
                        }
                    }
                }
                if (xb == 3)
                {
                    // reikia pradeti naudoti API ir rasti nemokama currency page kad padaryti dinamiska metoda su naujausiais valiutu kursais
                    while (true)
                    {
                        Console.Write("\nIveskite norima valiuta (USD, EUR, GBP, JPY) : ");
                        var valiut = Console.ReadLine();
                        if (valiut == "q") break;

                        Console.Write("Ir suma: ");
                        var miau = Console.ReadLine();
                        if (miau == "q") break;
                        double miauS = int.Parse(miau);
                        // 1eur: 163.76 JPY, 0.88 GBP, 1.11 USD
                        // 1gbp: 186.09 JPY, 1.14 EUR, 1.26 USD
                        // 1jpy: 0.0054 GBP, 0.0061 EUR, 0.0068 USD
                        // 1usd: 0.90 EUR, 0.79 GBP, 147.53 JPY
                        switch (valiut)
                        {
                            case "USD":
                                Console.WriteLine("-----------------------------------------------------------------");
                                Console.WriteLine("Pasirinkta valiuta: " + miau + " " + valiut);
                                Console.Write(miauS * 0.9 + "EUR, " + miauS * 0.79 + "GBP, " + miauS * 147.53 + "JPY\n");
                                Console.WriteLine("-----------------------------------------------------------------");
                                break;
                            case "EUR":
                                Console.WriteLine("-----------------------------------------------------------------");
                                Console.WriteLine("Pasirinkta valiuta: " + miau + " " + valiut);
                                Console.Write(miauS * 1.11 + "USD, " + miauS * 0.88 + "GBP, " + miauS * 163.76 + "JPY\n");
                                Console.WriteLine("-----------------------------------------------------------------");
                                break;
                            case "GBP":
                                Console.WriteLine("-----------------------------------------------------------------");
                                Console.WriteLine("Pasirinkta valiuta: " + miau + " " + valiut);
                                Console.Write(miauS * 1.14 + "EUR, " + miauS * 1.26 + "USD, " + miauS * 186.09 + "JPY\n");
                                Console.WriteLine("-----------------------------------------------------------------");
                                break;
                            case "JPY":
                                Console.WriteLine("-----------------------------------------------------------------");
                                Console.WriteLine("Pasirinkta valiuta: " + miau + " " + valiut);
                                Console.Write(miauS * 0.0061 + "EUR, " + miauS * 0.0054 + "GBP, " + miauS * 0.0068 + "USD\n");
                                Console.WriteLine("-----------------------------------------------------------------");
                                break;
                            default:
                                Console.WriteLine("-----------------------------------------------------------------");
                                Console.WriteLine("-------------------------WRONG-----------------------------------");
                                Console.WriteLine("-----------------------------------------------------------------");
                                break;
                        }
                    }
                }
            }
        }
        //static void pavyzdys()
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("Pasirinkite kuria programa norite naudoti: ");
        //        Console.WriteLine("1. Geometriniu figuru programa");
        //        Console.WriteLine("2. Pagrindiniu elementu programa");
        //        Console.WriteLine("3. Universitetu specialybiu programa");
        //        var ab = Console.ReadLine();
        //        if (ab == "q") break;
        //        int xb = int.Parse(ab);

        //        if (xb == 1)
        //        {
        //            while (true)
        //            {
        //                Console.Write("Iveskite kazka skaitmenisku pavidalu (1-999) :");
        //                var miau = Console.ReadLine();
        //                if (miau == "q") break;
        //                int miauS = int.Parse(miau);
        //            }
        //        }
        //        if (xb == 2)
        //        {
        //            while (true)
        //            {
        //                Console.Write("Iveskite kazka skaitmenisku pavidalu (1-999) :");
        //                var miau = Console.ReadLine();
        //                if (miau == "q") break;
        //                int miauS = int.Parse(miau);
        //            }
        //        }
        //        if (xb == 2)
        //        {
        //            while (true)
        //            {
        //                Console.Write("Iveskite kazka skaitmenisku pavidalu (1-999) :");
        //                var miau = Console.ReadLine();
        //                if (miau == "q") break;
        //                int miauS = int.Parse(miau);
        //            }
        //        }
        //    }
        //}
    }
}
