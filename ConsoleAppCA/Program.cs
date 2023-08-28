using System;
using System.Collections.Generic;
using System.Linq;

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

                Console.WriteLine("Issirinkite uzduoti nuo 1 iki 10: ");
                int slct = 0;
                try
                {
                    slct = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Wrong Selection! ");
                }

                if (slct == 1) uzduotis1();
                else if (slct == 2) uzduotis2();
                else if (slct == 3) uzduotis3();
                else if (slct == 4) uzduotis4();
                else if (slct == 5) uzduotis5();
                else if (slct == 6) uzduotis6();
                else if (slct == 7) uzduotis7();
                else if (slct == 8) uzduotis8();
                else if (slct == 9) uzduotis9();
                else if (slct == 10) uzduotis10();
                else if (slct > 10) Console.WriteLine("Wong Selection!");
            }
        }
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

        static void uzduotis6fail()
        {
            // -Sukurkite programą, kuri atspausdintų 7 produktus su jiems priskirtomis kainomis.
            //  Programa turėtų leisti į krepšelį įsidėti 3 produktus.
            // -Jei vartotojas perka 2 vienodus produktus krepšelis gauna -10 % akciją.
            //  Jei perka 3 vienodus gauna -15 % krepšelio akciją.
            // -Įsidėjus 3 produktus prieš atspausdinant čekį programa turėtų paklausti vartotojo ar jis turi lojalumo kortelę.
            //  Jei vartotojas turi lojalumo kortelę krepšelis gauna dar papildomą - 10 % akciją.

            // *Papildoma:
            //  Padarykite taip, kad perkant 2 produktus ne krepšelis gauna akciją, bet tik perkami 2 produktai.

            while (true)                                                                             // This is to repeat the code in console for debugging
            {

                // kintamieji
                int pirkiniai = 0;                                                                  // Integer to count while loop to break after three selections
                int pirkiniuKiekis = 3;                                                             // Max amount of products in shopping cart
                string p1 = "1L Pieno-5";
                //double k1 = 1.59;
                string p2 = "Pintine kiaushiniu-3";
                //double k2 = 2;
                string p3 = "1kg Obuoliu-2";
                //double k3 = 1.80;
                string p4 = "250g Shilauogiu-4";
                //double k4 = 4.5;
                string p5 = "Dedes viralo viedriux-9";
                //double k5 = 9.99;
                string p6 = "500g Surio-5";
                //double k6 = 3.25;
                string p7 = "Babos tapkes-8";
                //double k7 = 5;
                string valiuta = "Eur.";                                                            // Random for better visuality

                Console.WriteLine("===================== E-Farm Menu =====================");

                Console.WriteLine("Produktas nr.1 : " + p1 + valiuta);
                Console.WriteLine("Produktas nr.2 : " + p2 + valiuta);
                Console.WriteLine("Produktas nr.3 : " + p3 + valiuta);
                Console.WriteLine("Produktas nr.4 : " + p4 + valiuta);
                Console.WriteLine("Produktas nr.5 : " + p5 + valiuta);
                Console.WriteLine("Produktas nr.6 : " + p6 + valiuta);
                Console.WriteLine("Produktas nr.7 : " + p7 + valiuta);

                Console.WriteLine("=======================================================");

                // Read the user input of three products and discount card
                Console.Write("Pirmasis produktas: ");
                int pirkinys1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Antrasis produktas: ");
                int pirkinys2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Treciasis produktas: ");
                int pirkinys3 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ar turite nuolaidu kortele? y/n: ");
                string card = Console.ReadLine();

                bool tenProc = pirkinys1 == pirkinys2 || pirkinys1 == pirkinys3 || pirkinys2 == pirkinys3;      // ar bent du produktai yra vienodi
                bool qrtProc = pirkinys1 == pirkinys2 && pirkinys1 == pirkinys3;                                // ar visi trys vienodi
                bool disCard = false;
                int cartSum = 0;
                double sumTotal = 0;
                string dscnt = "";
                int ab = 0;

                #region nesamone
                // increase the cart sum price NESAMONE CIA YRA TIEK IF NESTINT VIENA SU KITU

                //while (pirkiniai < 3)
                //{
                //    if (pirkinys1 == 1)
                //    {
                //        cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf('-') + 1, 1));

                //        if (pirkinys2 == 1)
                //        {
                //            cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));

                //            if(pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if(pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if(pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if(pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if(pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if(pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if(pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));

                //                if(pirkinys3 == 1)
                //                {
                //                    cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 2)
                //                {
                //                    cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 3)
                //                {
                //                    cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 4)
                //                {
                //                    cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 5)
                //                {
                //                    cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 6)
                //                {
                //                    cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 7)
                //                {
                //                    cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //                }
                //            }
                //        else if (pirkinys2 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));

                //                if(pirkinys3 == 1)
                //                {
                //                    cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 2)
                //                {
                //                    cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 3)
                //                {
                //                    cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 4)
                //                {
                //                    cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 5)
                //                {
                //                    cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 6)
                //                {
                //                    cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 7)
                //                {
                //                    cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //                }
                //            }
                //        else if (pirkinys2 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));

                //                if(pirkinys3 == 1)
                //                {
                //                    cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 2)
                //                {
                //                    cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 3)
                //                {
                //                    cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 4)
                //                {
                //                    cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 5)
                //                {
                //                    cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 6)
                //                {
                //                    cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 7)
                //                {
                //                    cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //                }
                //            }
                //        else if (pirkinys2 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));

                //                if(pirkinys3 == 1)
                //                {
                //                    cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 2)
                //                {
                //                    cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 3)
                //                {
                //                    cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 4)
                //                {
                //                    cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 5)
                //                {
                //                    cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 6)
                //                {
                //                    cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 7)
                //                {
                //                    cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //                }
                //            }
                //        else if (pirkinys2 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));

                //                if(pirkinys3 == 1)
                //                {
                //                    cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 2)
                //                {
                //                    cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 3)
                //                {
                //                    cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 4)
                //                {
                //                    cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 5)
                //                {
                //                    cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 6)
                //                {
                //                    cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //                }
                //                else if(pirkinys3 == 7)
                //                {
                //                    cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //                }
                //            }
                //        else if (pirkinys2 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));

                //                if(pirkinys3 == 1)
                //                {
                //                    cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //                break;
                //                }
                //                else if(pirkinys3 == 2)
                //                {
                //                    cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //                else if(pirkinys3 == 3)
                //                {
                //                    cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //                else if(pirkinys3 == 4)
                //                {
                //                    cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //                else if(pirkinys3 == 5)
                //                {
                //                    cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //                else if(pirkinys3 == 6)
                //                {
                //                    cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //                else if(pirkinys3 == 7)
                //                {
                //                    cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            }

                //    }
                //    else if (pirkinys1 == 2)
                //    {
                //        cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));

                //        if (pirkinys2 == 1)
                //        {
                //            cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 2)
                //        {
                //            cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 3)
                //        {
                //            cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 4)
                //        {
                //            cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 5)
                //        {
                //            cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 6)
                //        {
                //            cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 7)
                //        {
                //            cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }

                //    }
                //    else if (pirkinys1 == 3)
                //    {
                //        cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));

                //        if (pirkinys2 == 1)
                //        {
                //            cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 2)
                //        {
                //            cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 3)
                //        {
                //            cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 4)
                //        {
                //            cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 5)
                //        {
                //            cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 6)
                //        {
                //            cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 7)
                //        {
                //            cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }

                //    }
                //    else if (pirkinys1 == 4)
                //    {
                //        cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));

                //        if (pirkinys2 == 1)
                //        {
                //            cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 2)
                //        {
                //            cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 3)
                //        {
                //            cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 4)
                //        {
                //            cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 5)
                //        {
                //            cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 6)
                //        {
                //            cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 7)
                //        {
                //            cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }

                //    }
                //    else if (pirkinys1 == 5)
                //    {
                //        cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));

                //        if (pirkinys2 == 1)
                //        {
                //            cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 2)
                //        {
                //            cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 3)
                //        {
                //            cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 4)
                //        {
                //            cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 5)
                //        {
                //            cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 6)
                //        {
                //            cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 7)
                //        {
                //            cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }

                //    }
                //    else if (pirkinys1 == 6)
                //    {
                //        cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));

                //        if (pirkinys2 == 1)
                //        {
                //            cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 2)
                //        {
                //            cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 3)
                //        {
                //            cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 4)
                //        {
                //            cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 5)
                //        {
                //            cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 6)
                //        {
                //            cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }
                //        else if (pirkinys2 == 7)
                //        {
                //            cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //            }
                //        }

                //    }
                //    else if (pirkinys1 == 7)
                //    {
                //        cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));

                //        if (pirkinys2 == 1)
                //        {
                //            cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //        }
                //        else if (pirkinys2 == 2)
                //        {
                //            cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //        }
                //        else if (pirkinys2 == 3)
                //        {
                //            cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //        }
                //        else if (pirkinys2 == 4)
                //        {
                //            cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //        }
                //        else if (pirkinys2 == 5)
                //        {
                //            cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //        }
                //        else if (pirkinys2 == 6)
                //        {
                //            cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //        }
                //        else if (pirkinys2 == 7)
                //        {
                //            cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));

                //            if (pirkinys3 == 1)
                //            {
                //                cartSum += Convert.ToInt32(p1.Substring(p1.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 2)
                //            {
                //                cartSum += Convert.ToInt32(p2.Substring(p2.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 3)
                //            {
                //                cartSum += Convert.ToInt32(p3.Substring(p3.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 4)
                //            {
                //                cartSum += Convert.ToInt32(p4.Substring(p4.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 5)
                //            {
                //                cartSum += Convert.ToInt32(p5.Substring(p5.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 6)
                //            {
                //                cartSum += Convert.ToInt32(p6.Substring(p6.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //            else if (pirkinys3 == 7)
                //            {
                //                cartSum += Convert.ToInt32(p7.Substring(p7.IndexOf("-") + 1, 1));
                //                break;
                //            }
                //        }

                //    }

                //    pirkiniai++;
                //}
                #endregion

                //bool state = true;
                //int ab = 0;
                //while (state)
                //{
                //    if (pirkinys1 == ab)
                //    {
                //        cartSum += 
                //    }
                //    else if (pirkinys1 != ab)
                //    {
                //        ab++;
                //    }
                //}
                //cartSum += Convert.ToInt32(pirkinys1.Substring(8, 1));

                ////cartSum += Convert.ToInt32(pirkinys1.Substring(pirkinys1.IndexOf('-'), 1));
                //cartSum += Convert.ToInt32(pirkinys2.Substring(pirkinys2.IndexOf("-") + 1, 1));
                //cartSum += Convert.ToInt32(pirkinys3.Substring(pirkinys3.IndexOf("-") + 1, 1));

                if (card == "y")
                {
                    disCard = true;
                }
                if (tenProc)
                {
                    sumTotal = cartSum * 0.9;
                    dscnt = "10 Proc.";

                    if (disCard)
                    {
                        // give adittional 10 proc discount to cart / sum of products
                        sumTotal *= 0.9;
                        dscnt = "20 Proc.";
                    }
                }

                if (qrtProc)
                {
                    // give 15 proc discount to the cart / sum of products
                    sumTotal = cartSum * 0.85;
                    dscnt = "15 Proc.";
                    if (disCard)
                    {
                        // give adittional 10 proc discount to cart / sum of products
                        sumTotal *= 0.9;
                        dscnt = "25 Proc.";
                    }
                }

                Console.WriteLine("Is viso suma: " + cartSum);
                Console.WriteLine("Nuolaida: " + dscnt);
                Console.WriteLine("Galutine kaina: " + sumTotal);
            }

            // TRY TO COMPLICATE THE CODE
            // Either i should enter the products into a multidim array or a dictionary to place an product and it's price as one object somehow

            //Console.WriteLine("Issirinkite produktus atskirtus kableliu (,) ir spauskite enter!");
            //Console.Write(" (pvz.: 1,1,7,3,2,6,6,5): ");

            //string pirkiniai = Console.ReadLine();

            //Console.WriteLine("Jusu sarasas: " + pirkiniai);

            //while (true)        // a while cycle to continue shopping
            //{
            //    Console.Write("Isirinkus produkto numeri spauskite enter (pvz 5), norint baigti apsipirkima rasykite: 'baigta' ");
            //    string pirkinys1 = Console.ReadLine();
            //    string pirkinys2 = Console.ReadLine();
            //    string pirkinys3 = Console.ReadLine();

            //    // to finish shopping
            //    if (Console.ReadLine() == "baigta")
            //    {
            //        break;
            //    }
            //}
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
            bool dalus3 = if()
        }
        static void uzduotis8()
        {

        }
        static void uzduotis9()
        {

        }
        static void uzduotis10()
        {

        }
    }
}
