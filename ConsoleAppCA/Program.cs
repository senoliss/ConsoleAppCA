using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Channels;
using System.Net.Http;
using System.Runtime.Intrinsics.X86;

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
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=TEMOS=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("1. System.String");
                Console.WriteLine("2. Conditionals - If");
                Console.WriteLine("3. Switch Case");
                Console.WriteLine("4. String Manipuliacija");
                Console.WriteLine("5. Ciklai - While");
                Console.WriteLine("6. ...");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                string slct = Console.ReadLine();

                switch (slct)
                {
                    case "1":
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=NERA!=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        navigacija();
                        break;

                    case "2":
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=UZDUOTYS=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("PASIRINKITE UZDUOTI NUO 1 IKI 10 ARBA PROJEKTAS");
                        slct = Console.ReadLine();
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
                            default:
                                Console.WriteLine("blogas pasirinkimas");
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=UZDUOTYS=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("PASIRINKITE UZDUOTI NUO 11 IKI 13 ARBA PROJEKTAS");
                        slct = Console.ReadLine();
                        switch (slct)
                        {
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
                        break;
                    case "4":
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=UZDUOTYS=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("PASIRINKITE UZDUOTI NUO 14 IKI 19 ARBA PROJEKTAS");
                        slct = Console.ReadLine();
                        switch (slct)
                        {
                            case "14":
                                uzduotis14();
                                break;
                            case "15":
                                uzduotis15();
                                break;
                            case "16":
                                uzduotis16();
                                break;
                            case "17":
                                uzduotis17();
                                break;
                            case "18":
                                uzduotis18();
                                break;
                            case "19":
                                uzduotis19();
                                break;
                            case "projektas":
                                projektasSM();
                                break;
                            default:
                                Console.WriteLine("blogas pasirinkimas");
                                break;
                        }
                        break;
                    case "5":
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=UZDUOTYS=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("PASIRINKITE UZDUOTI NUO 20 IKI 24 ARBA PROJEKTAS");
                        slct = Console.ReadLine();
                        switch (slct)
                        {
                            case "20":
                                uzduotis20();
                                break;
                            case "21":
                                uzduotis21();
                                break;
                            case "22":
                                uzduotis22();
                                break;
                            case "23":
                                uzduotis23();
                                break;
                            case "24":
                                uzduotis24();
                                break;
                            case "projektas":
                                projektasWhile();
                                break;
                            default:
                                Console.WriteLine("blogas pasirinkimas");
                                break;
                        }
                        break;
                    case "6":
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=NERA!=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        navigacija();
                        break;
                    case "7":
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=NERA!=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        navigacija();
                        break;
                    case "8":
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=NERA!=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        navigacija();
                        break;
                    default:
                        Console.WriteLine("blogas pasirinkimas");
                        break;
                }
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
        #region SwitchUzduotys
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
        #endregion
        #region StringManipuliacijosUzduotys
        static void uzduotis14()
        {
            Console.WriteLine("Iveskite betkoki teksta: ");
            string slct = Console.ReadLine();
            char[] slct2 = slct.ToCharArray();

            string raide = slct2[0].ToString().ToUpper();
            slct = slct.Replace(slct[0], raide[0]);
            Console.WriteLine(slct);
        }
        static void uzduotis15()
        {
            while (true)
            {
                Console.WriteLine("Pasirinkite kuria programa norite naudoti: ");
                Console.WriteLine("1. Sakinio programa");
                Console.WriteLine("2. Zodziu keitimo programa");
                Console.WriteLine("3. Iki 90-ies programa");
                var ab = Console.ReadLine();
                if (ab == "q") break;
                int xb = int.Parse(ab);

                if (xb == 1)
                {
                    while (true)
                    {
                        Console.Write("Iveskite pora sakiniu: ");
                        string slct = Console.ReadLine();
                        if (slct == "q") break;

                        //slct.Replace('a', 'u'+'o');
                        //char[] slct2 = slct.ToCharArray();
                        string slct2 = "";
                        slct2 = slct.Replace("a", "uo").Replace("i", "e");
                        Console.WriteLine(slct2);
                        //foreach (char c in slct)
                        //{
                        //    if (c == 'a')
                        //    {
                        //        slct2 += "uo";
                        //    }
                        //    else if (c.Equals('i'))
                        //    {
                        //        slct2 += "e";
                        //    }
                        //    else
                        //    {
                        //        slct2 += c;
                        //    }
                        //}

                        Console.WriteLine($"Old sentence: {slct}");
                        Console.WriteLine($"New sentence: {slct2}");
                    }
                }

                if (xb == 2)
                {
                    while (true)
                    {
                        Console.WriteLine("---------------------------------------------------------------------------");
                        Console.WriteLine("Iveskite eilerasti ar dainos zodzius: ");
                        string slct = Console.ReadLine();

                        if (slct == "q") break;

                        Console.WriteLine("---------------------------------------------------------------------------");
                        Console.WriteLine("Koki zodi noretumete pakeisti kitu zodziu?");

                        Console.Write("Zodis is teksto: ");
                        string a1 = Console.ReadLine();

                        Console.Write("Zodis kuriuo keisime: ");
                        string a2 = Console.ReadLine();

                        Console.WriteLine("---------------------------------------------------------------------------");
                        Console.WriteLine(slct.Replace(a1, a2));
                        Console.WriteLine("---------------------------------------------------------------------------");
                    }
                }

                if (xb == 3)
                {
                    while (true)
                    {
                        Console.WriteLine("Iveskite savo gimimo data (YYYY-MM-DD): ");
                        string gimt = Console.ReadLine();
                        Console.WriteLine("Iveskite savo amziu (XX): ");
                        string metai = Console.ReadLine();
                        Console.WriteLine("Iveskite siandienos data (YYYY-MM-DD): ");
                        string snd = Console.ReadLine();

                        int yrs = 90;
                        int months = yrs * 12;
                        int weeks = yrs * 52;
                        int days = Convert.ToInt32(yrs * 365.25);

                        int gimtY = Convert.ToInt32(gimt.Split("-")[0]);
                        int gimtM = Convert.ToInt32(gimt.Split("-")[1]);
                        int gimtD = Convert.ToInt32(gimt.Split("-")[2]);

                        int sndY = Convert.ToInt32(snd.Split("-")[0]);
                        int sndM = Convert.ToInt32(snd.Split("-")[1]);
                        int sndD = Convert.ToInt32(snd.Split("-")[2]);

                        int yrs1 = yrs - int.Parse(metai);
                        int months1 = (yrs * 12) - (int.Parse(metai) * 12);
                        int weeks1 = (yrs * 52) - (int.Parse(metai) * 12);
                        int days1 = 365 - ((sndM * 30 + sndD) - (gimtM * 30 + gimtD)); // it calculates days untill next birthay at todays date 08-30 || (365 - ((8 * 30 + 30) - (7 * 30 + 6)) = 365 - (270 - 216) = 365 - 54 = 311days

                        Console.WriteLine("---------------------------------------------------------------------------");
                        Console.WriteLine($"Iki 90-ies metu jums liko gyventi: {yrs1} metu arba {months1} menesiu arba {weeks1} savaiciu arba {days1} dienu");
                        Console.WriteLine("---------------------------------------------------------------------------");
                        #region TryingToCalculateLeftTime
                        //int remainingYears = yrs - int.Parse(metai); // 90 - 24 = 66
                        int leftM = 0;
                        int leftW = 0;
                        int leftD = 0;

                        while (yrs1 > 0)                        // 66
                        {
                            if (yrs1 >= 1)
                            {
                                yrs1--;                         //65
                            }
                            else if (leftM >= 12)
                            {
                                yrs1++;
                                leftM -= 12;
                            }
                            else if (leftW >= 52)
                            {
                                leftM++;
                                leftW -= 52;
                            }
                            else
                            {
                                leftW++;
                                leftD -= 7;
                            }
                        }

                        Console.WriteLine($"You have approximately {yrs1} years, {leftM} months, {leftW} weeks, and {leftD} days until you're 90 years old.");
                        #endregion
                    }
                }

            }
        }
        static void uzduotis16()
        {
            while (true)
            {
                Console.WriteLine("Choose which program you'd like to use: ");
                Console.WriteLine("1. Word check program");
                Console.WriteLine("2. Symbol check program");
                Console.WriteLine("3. 'labas' check program");
                var ab = Console.ReadLine();
                if (ab == "q") break;
                int xb = int.Parse(ab);

                if (xb == 1)
                {
                    while (true)
                    {
                        Console.Write("Type a word:");
                        string word = Console.ReadLine();
                        if (word == "q") break;

                        char bl = word[0];
                        bool isUpper = Char.IsUpper(bl);
                        bool isLetter = Char.IsLetter(bl);
                        string newWordL = word.Replace(word[0], Char.ToUpper(word[0]));
                        string newWordU = word.ToUpper();

                        if (isUpper && isLetter)
                        {
                            Console.WriteLine("---------------------------------------------------------------------------");
                            Console.WriteLine($"Word: {word} started with first uppercase letter, so it is changed to: {newWordU}");
                            Console.WriteLine("---------------------------------------------------------------------------");
                        }
                        else if (!isUpper && isLetter)
                        {
                            Console.WriteLine("---------------------------------------------------------------------------");
                            Console.WriteLine($"Word: {word} started with first lowercase letter, so it is changed to: {newWordL}");
                            Console.WriteLine("---------------------------------------------------------------------------");
                        }
                        else
                        {
                            Console.WriteLine("---------------------------------------------------------------------------");
                            Console.WriteLine($"First char: {bl} of a word: {word}, was not a letter! ERROR!");
                            Console.WriteLine("---------------------------------------------------------------------------");
                        }

                    }
                }
                if (xb == 2)
                {
                    while (true)
                    {
                        Console.Write("Type a word:");
                        string miau = Console.ReadLine();
                        if (miau == "q") break;

                        Console.Write("Select a char:");
                        char boo = char.Parse(Console.ReadLine());
                        if (boo == 'q') break;

                        bool exists = miau.Contains(boo);
                        int times = 0;

                        string indexes = "";

                        if (exists)
                        {
                            if (miau.Count(o => o == boo) > 1)
                            {
                                for (int i = 0; i < miau.Length; i++)
                                {
                                    if (miau[i] == boo)
                                    {
                                        times++;
                                        indexes += $"{i}, ";
                                    }
                                }
                                //indexes = indexes.Remove(indexes[indexes.LastIndexOf(',')]);
                                indexes = indexes.Trim().Trim(',') + ".";
                                Console.WriteLine("---------------------------------------------------------------------------");
                                Console.WriteLine($"Word: {miau} contains characters '{boo}' and their indexes are: {indexes}");
                                Console.WriteLine("---------------------------------------------------------------------------");
                            }

                            if (miau.Count(o => o == 'a') < 2)
                            {
                                Console.WriteLine("---------------------------------------------------------------------------");
                                Console.WriteLine($"Word: {miau} contains character '{boo}' and it's index is: {miau.IndexOf('a')}");
                                Console.WriteLine("---------------------------------------------------------------------------");
                            }
                        }
                        else
                        {
                            Console.WriteLine("---------------------------------------------------------------------------");
                            Console.WriteLine($"Word: {miau}  does not contain character '{boo}'!");
                            Console.WriteLine("---------------------------------------------------------------------------");
                        }
                    }
                }
                if (xb == 3)
                {
                    while (true)
                    {
                        Console.Write("Type a greeting in any language: ");
                        string miau = Console.ReadLine();
                        if (miau == "q") break;

                        bool ltu = (miau == "labas");
                        char[] ble = miau.ToCharArray();
                        string aba = new string(miau.Reverse().ToArray());
                        if (!ltu) Console.WriteLine($"{miau}, back to you!");
                        if (ltu) Console.WriteLine($"Great, you know a bit Lithuanian! Here's a reversed greeting to you as a bonus: '{aba}'");

                        /* Galima butu gauti paskutini char indexa ir pati char to zodzio, tada prideti prie pradzios ta char paskutini ir nuimti nuo galo, ir sukti while loop iki kol paskutinis char bus lygus*/
                    }
                }
            }
        }
        static void uzduotis17()
        {
            while (true)
            {
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("------------------------Welcome to SUBWAY!---------------------------------");
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("Here's the recipe for greatest subway sandwich!: ");
                Console.WriteLine("1. Bread");
                Console.WriteLine("2. Meat");
                Console.WriteLine("3. Cheese");
                Console.WriteLine("4. Mini veggies");
                Console.WriteLine("5. Veggies");
                Console.WriteLine("6. Spiciness");
                Console.WriteLine("7. Sauce");
                Console.WriteLine("8. Size");
                Console.WriteLine("---------------------------------------------------------------------------");

                string ab1;
                int ab2;
                // 1 pasirinkimas
                Console.WriteLine("Choose the bread: ");

                Console.WriteLine("1. Grainy");
                Console.WriteLine("2. With cheese");
                Console.WriteLine("3. Plain");

                ab1 = Console.ReadLine();
                if (ab1 == "q") break;
                ab2 = int.Parse(ab1);
                string[] bread = ab2 switch
                {
                    1 => new[] { "Grainy", "2" },
                    2 => new[] { "Cheesy", "2.2" },
                    3 => new[] { "Plain", "1.5" },
                    _ => new[] { "Wrong!", "0" }
                };
                // 2 pasirinkimas
                Console.WriteLine("Choose the Meat: ");

                Console.WriteLine("1. Saliami");
                Console.WriteLine("2. Bacon");
                Console.WriteLine("3. No meat");

                ab1 = Console.ReadLine();
                if (ab1 == "q") break;
                ab2 = int.Parse(ab1);
                string[] meat = ab2 switch
                {
                    1 => new[] { "Saliami", "2" },
                    2 => new[] { "Bacon", "2.2" },
                    3 => new[] { "No meat", "0" },
                    _ => new[] { "Wrong!", "0" }
                };
                // 3 pasirinkimas
                Console.WriteLine("Choose the Cheese: ");

                Console.WriteLine("1. Feta");
                Console.WriteLine("2. Parmezan");
                Console.WriteLine("3. No cheese");

                ab1 = Console.ReadLine();
                if (ab1 == "q") break;
                ab2 = int.Parse(ab1);
                string[] cheese = ab2 switch
                {
                    1 => new[] { "Feta", "2" },
                    2 => new[] { "Parmezan", "2.2" },
                    3 => new[] { "No cheese", "0" },
                    _ => new[] { "Wrong!", "0" }
                };
                // 4 pasirinkimas
                Console.WriteLine("Choose the Mini veggies: ");

                Console.WriteLine("1. Corn");
                Console.WriteLine("2. Pea");
                Console.WriteLine("3. Nothing");

                ab1 = Console.ReadLine();
                if (ab1 == "q") break;
                ab2 = int.Parse(ab1);
                string[] veggies = ab2 switch
                {
                    1 => new[] { "Corn", "2" },
                    2 => new[] { "Pea", "2.2" },
                    3 => new[] { "Nothing", "0" },
                    _ => new[] { "Wrong!", "0" }
                };
                // 5 pasirinkimas
                Console.WriteLine("Choose the Veggies: ");

                Console.WriteLine("1. Tomato");
                Console.WriteLine("2. Pickle");
                Console.WriteLine("3. Both");

                ab1 = Console.ReadLine();
                if (ab1 == "q") break;
                ab2 = int.Parse(ab1);
                string[] veg = ab2 switch
                {
                    1 => new[] { "Tomato", "2" },
                    2 => new[] { "Pickle", "2.2" },
                    3 => new[] { "Both", "4" },
                    _ => new[] { "Wrong!", "0" }
                };
                // 6 pasirinkimas
                Console.WriteLine("Choose the Spiciness: ");

                Console.WriteLine("1. *");
                Console.WriteLine("2. **");
                Console.WriteLine("3. Not Spicy");

                ab1 = Console.ReadLine();
                if (ab1 == "q") break;
                ab2 = int.Parse(ab1);
                string[] spicy = ab2 switch
                {
                    1 => new[] { "*", "2" },
                    2 => new[] { "**", "2.2" },
                    3 => new[] { "Not Spicy", "0" },
                    _ => new[] { "Wrong!", "0" }
                };
                // 7 pasirinkimas
                Console.WriteLine("Choose the Sauce: ");

                Console.WriteLine("1. Burger");
                Console.WriteLine("2. Garlic");
                Console.WriteLine("3. No sauce");

                ab1 = Console.ReadLine();
                if (ab1 == "q") break;
                ab2 = int.Parse(ab1);
                string[] sauce = ab2 switch
                {
                    1 => new[] { "Burger", "2" },
                    2 => new[] { "Garlic", "2.2" },
                    3 => new[] { "No sauce", "0" },
                    _ => new[] { "Wrong!", "0" }
                };
                // 8 pasirinkimas
                Console.WriteLine("Choose the Size: ");

                Console.WriteLine("1. Medium");
                Console.WriteLine("2. Large");
                Console.WriteLine("3. Extra Large");

                ab1 = Console.ReadLine();
                if (ab1 == "q") break;
                ab2 = int.Parse(ab1);
                string[] size = ab2 switch
                {
                    1 => new[] { "Medium", "1" },
                    2 => new[] { "Large", "1.5" },
                    3 => new[] { "Extra Large", "2.5" },
                    _ => new[] { "Wrong", "0" }
                };

                Console.WriteLine($"Your choice: {bread[0]} {bread[1]}$, {meat[0]} {meat[1]}$, {cheese[0]} {cheese[1]}$, {veggies[0]} {veggies[1]}$, {veg[0]} {veg[1]}$, {spicy[0]} {spicy[1]}$, {sauce[0]} {sauce[1]}$, {size[0]} {size[1]}$.");
                double total = double.Parse(bread[1]) + double.Parse(meat[1]) + double.Parse(cheese[1]) + double.Parse(veggies[1]) + double.Parse(veg[1]) + double.Parse(spicy[1]) + double.Parse(sauce[1]) + double.Parse(size[1]);
                Console.WriteLine("Total for you awesombazinga SUBWWAY sandwich: " + total + " shillings! Enjoy your long burgir!");
                Console.Read();
            }
        }

        static void uzduotis18()
        {
            while (true)
            {
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("------------------------TELEPHONE COST APP---------------------------------");
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("Choose country to preselect the code: ");
                Console.Write("\"LT\", \"LV\", \"EE\", \"DK\", \"DE\", \"UK\", \"USA\", \"NO\", \"FI\", \"FR\", \"AL\", \"MD\", \"JPN\", \"PL\", \"SYR\" :");
                string miau = Console.ReadLine().ToUpper();
                if (miau == "Q") break;

                string[] code = miau switch
                {
                    "LT" => new[] { "+370", "Lithuania" },
                    "LV" => new[] { "+371", "Latvia" },
                    "EE" => new[] { "+372", "Estonia" },
                    "DK" => new[] { "+49", "Denamrk" },
                    "DE" => new[] { "+45", "Germany" },
                    "UK" => new[] { "+44", "United Kingdom" },
                    "USA" => new[] { "+1", "Shtatai" },
                    "NO" => new[] { "+47", "Norway" },
                    "FI" => new[] { "+358", "Finland" },
                    "FR" => new[] { "+33", "France" },
                    "AL" => new[] { "+355", "Albania" },
                    "MD" => new[] { "+373", "Moldova" },
                    "JPN" => new[] { "+81", "Japan" },
                    "PL" => new[] { "+48", "Poland" },
                    "SYR" => new[] { "+963", "Syria" },
                    _ => new[] { "Wrong!", "Country!" }
                };

                Console.Write("How many minutes you're going to talk?: ");
                int min = int.Parse(Console.ReadLine());
                Console.Write("Enter your selected country number: " + code[1] + " " + code[0]);
                string phone = Console.ReadLine().ToString().Split('+')[0];

                phone = code[0] + phone;
                double kaina = 0.08;
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("Bite");
                Console.WriteLine("Telefono numeris: " + phone);
                Console.WriteLine("Skambucio laikas: " + kaina + "/min");
                Console.WriteLine("Galutine skambucio kaina: " + (kaina * min));
                Console.WriteLine("---------------------------------------------------------------------------");


            }
        }
        static void uzduotis19()
        {
            while (true)
            {
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("------------------------TIKROJI MEILES SISTEMA-----------------------------");
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("Noredami suzinoti dvieju zmoniu tinkamuma vienas ktiam iveskite du vardus:");
                string v1 = Console.ReadLine().ToLower();
                if (v1 == "q") break;
                string v2 = Console.ReadLine().ToLower();
                if (v2 == "q") break;

                int v11 = 0;
                int v22 = 0;
                string txt = "tikros meiles sistema";

                for (int i = 0; i <= v1.Length - 1; i++)
                {
                    if (txt.Contains(v1[i]))
                    {
                        //Console.WriteLine(v1[i]);
                        v11 += txt.Count(o => o == v1[i]);
                    }
                }

                for (int i = 0; i <= v2.Length - 1; i++)
                {
                    if (txt.Contains(v2[i]))
                    {
                        v22 += txt.Count(o => o == v2[i]);
                    }
                }
                string tinkamumas = v11.ToString() + v22.ToString();
                string kiekTink = int.Parse(tinkamumas) switch
                {
                    < 55 => "Vienas kitam tinkate.",
                    < 89 => "Vienas kitam puikiai tinkate!",
                    > 90 => "Idealu!",
                    _ => "Neapskaiciuota.."
                };
                v1 = v1.Replace(v1[0], Char.ToUpper(v1[0]));
                v2 = v2.Replace(v2[0], Char.ToUpper(v2[0]));
                Console.WriteLine($"Tekste '{txt}' vardu raides kartojasi: {v1} - {v11} ir {v2} - {v22}, jusu tinkamumas: " + tinkamumas + ", " + kiekTink);
            }
        }
        static void projektasSM()
        {

        }
        static void uzduotis20()
        {
            while (true)
            {
                Console.WriteLine("Pasirinkite kuria programa norite naudoti: ");
                Console.WriteLine("1. First while cycle task");
                Console.WriteLine("2. Second while cycle task");
                Console.WriteLine("3. Third while cycle task");
                var ab = Console.ReadLine();
                if (ab == "q") break;
                int xb = int.Parse(ab);

                int a = 1;
                int b = 5;

                if (xb == 1)
                {
                    while (a != 6)
                    {
                        Console.Write(a + " - ");
                        a++;
                    }
                    a--;
                    Console.WriteLine();
                    while (a >= 1)
                    {
                        Console.Write(a + " - ");
                        a--;
                    }
                    Console.WriteLine();
                }

                if (xb == 2)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Lyginiu ciklas: ");
                    while (a != 11)
                    {
                        if (a % 2 == 0)
                        {
                            Console.Write(a + ", ");
                        }
                        a++;
                    }
                    Console.WriteLine("\n----------------------------------------");
                    Console.WriteLine("Nelyginiu ciklas: ");
                    a = 1;
                    while (a != 10)
                    {
                        if (a % 2 != 0)
                        {
                            Console.Write(a + ", ");
                        }
                        a++;
                    }
                    Console.WriteLine("\n----------------------------------------");
                }

                if (xb == 3)
                {
                    Console.Write("Iveskite skaiciu:");
                    int s = int.Parse(Console.ReadLine());
                    while (s < 100)
                    {
                        Console.WriteLine("Skaicius neteisingas! ");
                        Console.Write("Iveskite skaiciu vel:");
                        s = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine($"Congratz, you've entered correct number! Equal or more than 100 : '{s}'");
                    Console.Write("On to the next loop! Enter anotha numba: ");
                    s = int.Parse(Console.ReadLine());
                    while (s % 2 != 0)
                    {
                        Console.WriteLine("Bad number! ");
                        Console.Write("Type another one:");
                        s = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine($"Congratz, you've entered correct number! Number dividable by two: '{s}'");
                }
            }
        }

        static void uzduotis21()
        {
            while (true)
            {
                Console.WriteLine("Choose an app: ");
                Console.WriteLine("1. Factorial program");                  // i don't get it how to do tas 2.1 https://codeacademylt.sharepoint.com/:p:/r/sites/NETUA2/_layouts/15/Doc.aspx?sourcedoc=%7BDE28CB40-BE61-4AEB-9554-1986E003339E%7D&file=06.%20While.pptx&action=edit&mobileredirect=true
                Console.WriteLine("2. Number splitter program");
                Console.WriteLine("3. Fancy 'half of a xmas tree' program");
                var ab = Console.ReadLine();
                if (ab == "q") break;
                int xb = int.Parse(ab);

                if (xb == 1)
                {
                    Console.Write("\nChoose a number to see it's factortial function: ");
                    var miau = Console.ReadLine();
                    if (miau == "q") break;
                    int miauS = int.Parse(miau);
                    int b = miauS;

                    while (miauS > 0)
                    {
                        while (b > 1)
                        {
                            Console.Write(miauS + " - ");
                            b--;
                            miauS *= b;
                        }
                        Console.Write("\nChoose a number to see it's factortial function: ");
                        miau = Console.ReadLine();
                        if (miau == "q") break;
                        miauS = int.Parse(miau);
                    }
                }
                if (xb == 2)
                {
                    while (true)
                    {
                        Console.Write("Iveskite kazka skaitmenisku pavidalu (1-999) :");
                        var miau = Console.ReadLine();
                        if (miau == "q") break;
                        int miauS = int.Parse(miau);
                    }
                }
                if (xb == 2)
                {
                    while (true)
                    {
                        Console.Write("Iveskite kazka skaitmenisku pavidalu (1-999) :");
                        var miau = Console.ReadLine();
                        if (miau == "q") break;
                        int miauS = int.Parse(miau);
                    }
                }
            }
        }
        static void uzduotis22()
        {

        }
        static void uzduotis23()
        {

        }
        static void uzduotis24()
        {

        }
        static void projektasWhile()
        {

        }
    }
}
#endregion
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


