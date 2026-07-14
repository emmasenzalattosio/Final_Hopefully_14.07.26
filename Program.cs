using System.ComponentModel.Design;

namespace Projekt_Klausur
{
    internal class Program
    {
        static string[] produkt_name = new string[20];
        static int[] produkt_anzahl = new int[20];

        static decimal[] produkt_preis = new decimal[20];
        static int produkt_count = 0;

        static void Emoji()
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
        }

        // First menü - Choosing of the user!!
        static void Login()
        {
            Emoji();
            bool first_loop = true;

            while (first_loop)
            {


                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("                    Who is tryna get in the server??\n");
                Console.ResetColor();

                Console.WriteLine("                       ==========================");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("                       ||   (M) ");
                Console.ResetColor();
                Console.WriteLine("Manager        ||   ");
                Console.WriteLine("                       ==========================");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("                       ||   (K) ");
                Console.ResetColor();
                Console.WriteLine("Kunde          ||   ");
                Console.WriteLine("                       ==========================");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("                       ||   (L) ");
                Console.ResetColor();
                Console.WriteLine("Lieferant      ||   ");
                Console.WriteLine("                       ==========================");


                char user = Console.ReadKey().KeyChar;

                Console.Clear();
                switch (user)
                {

                    case 'M':

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("                    === ACCESS PANEL ===");
                        Console.ResetColor();

                        Console.WriteLine("                 Please give your name in: ");
                        Console.WriteLine();
                        string M_name = Console.ReadLine()!;
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                  --- ACCESS GRANTED!! ---");
                        Console.ResetColor();
                        Console.WriteLine();

                        Console.Write($"                    Welcome back ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{M_name} 😘");
                        Console.WriteLine("!!");
                        Console.ResetColor();

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Enter to keep going..!!");
                        Console.ReadLine();
                        Console.Clear();

                        Auswahl_Manager();

                        break;


                    case 'K':

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("       === ACCESS PANEL ===");
                        Console.ResetColor();
                        Console.WriteLine("    Please give your name in: ");
                        Console.WriteLine();
                        string K_name = Console.ReadLine()!;
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("      --- ACCESS GRANTED!! ---");
                        Console.ResetColor();
                        Console.WriteLine();

                        Console.Write($"    Welcome back ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{K_name} 😘");
                        Console.WriteLine("!!");
                        Console.ResetColor();
                        Console.WriteLine("Pls push whatever key to keep going!!");
                        Console.ReadLine();
                        Console.Clear();

                        Auswahl_Kunde();

                        break;


                    case 'L':
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("       === ACCESS PANEL ===");
                        Console.ResetColor();
                        Console.WriteLine("    Please give your name in: ");
                        Console.WriteLine();
                        string L_name = Console.ReadLine()!;
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("      --- ACCESS GRANTED!! ---");
                        Console.ResetColor();
                        Console.WriteLine();

                        Console.Write($"    Welcome back ");

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{L_name} 😘");
                        Console.WriteLine("!!");
                        Console.ResetColor();

                        Console.WriteLine("Pls push whatever key to keep going!!");
                        Console.ReadLine();
                        Console.Clear();

                        Auswahl_Lieferant();

                        break;

                }

            }
        }


        //2nd Methode for the Manager rechte
        static void Auswahl_Manager()
        {
            Emoji();
            bool second_loop = true;
            while (second_loop)
            {


                //Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Bet, what do we wanna do today??!!\n");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("(1) ");
                Console.ResetColor();
                Console.WriteLine("Check the Produkts!!");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("(2) ");
                Console.ResetColor();
                Console.WriteLine("Add a new Produkt!!");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("(3) ");
                Console.ResetColor();
                Console.WriteLine("Delete a Produkt!!");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("(X) ");
                Console.ResetColor();
                Console.WriteLine("Exit");

                char auswahl = ' ';
                auswahl = Console.ReadKey().KeyChar;

                Console.Clear();
                switch (auswahl)
                {

                    case '1':
                        Console.WriteLine("Aight bet, here are all the produkts!!");
                        show_products();

                        break;

                    case '2':
                        Console.WriteLine("Let´s add a new produkt!!");
                        AddProduct();
                        break;

                    case '3':
                        Console.WriteLine("Let´s delete a produkt!!");
                        DeleteProduct();
                        break;

                    case 'X':
                        Console.WriteLine("Sad to see you go, please come to visit us again soon!!");
                        break;
                }
                Console.Clear();
            }

        }
        // 3rd Methode for the Kunde rechte
        // Easy switch - case for the action auswahl
        static void Auswahl_Kunde()
        {
            Emoji();
            bool third_loop = true;

            while (third_loop)
            {



                Console.WriteLine("Bet, what do we wanna do today??!!");
                Console.WriteLine("(1) Check the Produkts!!");
                Console.WriteLine("(2) Wanna order something??");
                Console.WriteLine("(3) Wanna give something back??");
                char auswahl1 = ' ';
                auswahl1 = Console.ReadKey().KeyChar;

                switch (auswahl1)
                {

                    case '1':
                        Console.WriteLine("Here are all our produkts");
                        // Calling the Produkt Methode to show the available items 
                        show_products();

                        break;
                    case '2':
                        Console.WriteLine("What produkt would you wanna have??");
                        //need to make another methode for the produkt chosen
                        break;

                    case '3':

                        Console.WriteLine("");
                        break;
                }


            }

        }
        // 4th Methode for the Lieferant rechte
        // Easy switch - case for the action auswahl

        static void Auswahl_Lieferant()
        {
            Emoji();
            bool fourth_loop = true;
            while (fourth_loop)
            {


                Console.WriteLine("Bet, what do we wanna do today??!!");
                Console.WriteLine("(1) Check the Produkts!!");

                Console.WriteLine("(2) Deliver Produkts");

                char auswahl2 = ' ';
                auswahl2 = Console.ReadKey().KeyChar;

                switch (auswahl2)
                {

                    case '1':
                        Console.WriteLine("Aight bet, here are all the produkts!!");
                        show_products();
                        break;

                    case '2':
                        AddProduct();
                        break;

                }
            }

        }
        // Methode that shows all the saved products
        static void show_products()
        {
            Emoji();
            Console.Clear();
            Console.WriteLine("=== PRODUCTS ===");
            Console.WriteLine("");

            //No products inside?? Then console ausgabe
            if (produkt_count == 0)
            {
                Console.WriteLine("No products available");
                Console.ReadLine();
                return;
            }

            //Schleife that checks the products and for every added one shows details
            for (int i = 0; i < produkt_count; i++)
            {
                Console.WriteLine();
                Console.Write($"[{i}]");
                Console.WriteLine($" {produkt_name[i]}");
                Console.Write($" -   Anzahl: ");
                Console.WriteLine(produkt_anzahl[i]);
                Console.Write($" -   Price:  ");
                Console.WriteLine($"{produkt_preis[i]} €");
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue!!");
            Console.ReadLine();
            Console.Clear();
        }


        // Adding products Methode
        static void AddProduct()
        {
            Emoji();
            Console.Clear();
            Console.WriteLine("=== ADD PRODUCT ===");
            Console.WriteLine();


            Console.WriteLine("Product name: ");
            string name = Console.ReadLine()!;


            Console.WriteLine("Amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Price: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());



            for (int i = 0; i < produkt_count; i++)
            {

                // all the new products are added to the array
                produkt_name[produkt_count] = name;
                produkt_anzahl[produkt_count] = amount;
                produkt_preis[produkt_count] = price;
            }
            produkt_count++;
            Console.WriteLine("Product added!!");
            Console.ReadLine();

        }



        static void DeleteProduct()
        {
            Emoji();
            Console.WriteLine(" === DELETE PRODUCT ===");
            Console.WriteLine();

            for (int i = 0; i < produkt_count; i++)
            {
                Console.WriteLine($"[{i}] {produkt_name[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Select product to delete: ");
            string Delete = Console.ReadLine()!;

            for (int i = 0; i < produkt_count - 1; i++)
            {
                produkt_name[i] = produkt_name[i + 1];
                produkt_anzahl[i] = produkt_anzahl[i + 1];
                produkt_preis[i] = produkt_preis[i + 1];
            }

            produkt_count--;
            Console.WriteLine("Produkt deleted!!");
        }


        static void FirstProducts()
        {
            Emoji();
            produkt_name[0] = "Laptop";
            produkt_anzahl[0] = 5;
            produkt_preis[0] = 899.99M;

            produkt_name[1] = "Mouse";
            produkt_anzahl[1] = 20;
            produkt_preis[1] = 29.99M;

            produkt_name[2] = "Keyboard";
            produkt_anzahl[2] = 15;
            produkt_preis[2] = 79.99M;

            produkt_count = 3;
        }


        static void Main(string[] args)
        {
            FirstProducts();
            Login();
        }



    }
}
