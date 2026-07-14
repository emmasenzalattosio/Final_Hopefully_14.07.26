using System.ComponentModel.Design;

namespace Projekt_Klausur
{
    internal class Program
    {
        static string[] produkt_name = new string[20];
        static int[] produkt_anzahl = new int[20];

        static decimal[] produkt_preis = new decimal[20];
        static int produkt_count = 0;

        // Kunde data
        static string kunde_name = "";
        static string[] kunde_bestellungen = new string[10];
        static int kunde_bestellungen_count = 0;

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

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("══════════════════════════════════════════════════════════════════════");
                Console.WriteLine("       █████╗  ██████╗ ██████╗███████╗███████╗███████╗");
                Console.WriteLine("      ██╔══██╗██╔════╝██╔════╝██╔════╝██╔════╝██╔════╝");
                Console.WriteLine("      ███████║██║     ██║     █████╗  ███████╗███████╗");
                Console.WriteLine("      ██╔══██║██║     ██║     ██╔══╝  ╚════██║╚════██║");
                Console.WriteLine("      ██║  ██║╚██████╗╚██████╗███████╗███████║███████║");
                Console.WriteLine("      ╚═╝  ╚═╝ ╚═════╝ ╚═════╝╚══════╝╚══════╝╚══════╝");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("               ◤ AUTHENTICATION TERMINAL ◢");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                 SELECT USER PROFILE\r\n");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("          ╭──────────────────────────────╮");
                Console.WriteLine("          │  [ M ]   MANAGER             │");
                Console.WriteLine("          │                              │");
                Console.WriteLine("          │  [ K ]   KUNDE               │");
                Console.WriteLine("          │                              │");
                Console.WriteLine("          │  [ L ]   LIEFERANT           │");
                Console.WriteLine("          ╰──────────────────────────────╯");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                    >>> INPUT: ");
                Console.WriteLine("══════════════════════════════════════════════════════════════════════");
                Console.ResetColor();


                char user = Console.ReadKey().KeyChar;

                Console.Clear();
                switch (user)
                {

                    case 'M':

                        access_panel();
                        Auswahl_Manager();

                        break;

                    case 'K':

                        access_panel();
                        Auswahl_Kunde();

                        break;


                    case 'L':

                        access_panel();
                        Auswahl_Lieferant();

                        break;
                }

            }
        }

        static void access_panel()
        {
            Console.WriteLine("████████████████████████████████████████████");
            Console.WriteLine();
            Console.WriteLine("          NEXUS ACCESS NODE");
            Console.WriteLine();
            Console.WriteLine("████████████████████████████████████████████");
            Console.WriteLine();
            Console.WriteLine("Loading security modules...");
            Console.WriteLine();
            Console.WriteLine("> ENTER OPERATOR NAME");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("████████████████████████████████████████████");
            Console.WriteLine();
            Console.WriteLine("          ACCESS GRANTED");
            Console.WriteLine();
            Console.WriteLine("████████████████████████████████████████████");
            Console.WriteLine();
            Console.WriteLine("Connection Status : ONLINE");
            Console.WriteLine("Firewall          : ACTIVE");
            Console.WriteLine("Encryption        : ENABLED");
            Console.WriteLine();
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine();
            Console.WriteLine("Press [ ENTER ] to continue...");
            Console.ReadLine();
            Console.Clear();


        }


        //2nd Methode for the Manager rechte
        static void Auswahl_Manager()
        {
            Emoji();
            bool second_loop = true;
            while (second_loop)
            {
                Control_Panel();

                char auswahl = ' ';
                auswahl = Console.ReadKey().KeyChar;

                Console.Clear();
                switch (auswahl)
                {

                    case '1':
                        show_products();

                        break;

                    case '2':
                        AddProduct();
                        break;

                    case '3':
                        DeleteProduct();
                        break;

                    case 'X':

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Clear();
                        Login();
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
            Kunde_Anmelden();

            bool third_loop = true;

            while (third_loop)
            {
                Kunde_Menu();

                char auswahl1 = Console.ReadKey().KeyChar;
                Console.Clear();

                switch (auswahl1)
                {
                    case '1':
                        // Calling the Produkt Methode to show the available items 
                        show_products();
                        break;

                    case '2':
                        ZeigeKundeBestellungen();
                        break;

                    case '3':
                        SimuliereKundeBestellung();
                        break;

                    case 'X':
                    case 'x':
                        third_loop = false;
                        break;
                }
            }

            Console.Clear();
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
                        show_products();
                        break;

                    case '2':
                        AddProduct();
                        break;

                }
            }

        }

        static void Control_Panel()
        {
            Console.WriteLine("══════════════════════════════════════════════════════════════════════");
            Console.WriteLine();
            Console.WriteLine("             NEXUS CONTROL PANEL");
            Console.WriteLine();
            Console.WriteLine("══════════════════════════════════════════════════════════════════════");
            Console.WriteLine();
            Console.WriteLine(" Select an operation:");
            Console.WriteLine();
            Console.WriteLine("     [1] 📦  Product Inventory");
            Console.WriteLine();
            Console.WriteLine("     [2] ➕  Register New Product");
            Console.WriteLine();
            Console.WriteLine("     [3] 🗑   Remove Product");
            Console.WriteLine();
            Console.WriteLine("     [X] ⏻  Logout");
        }

        static void Kunde_Anmelden()
        {
            Console.WriteLine("=== KUNDE LOGIN ===");
            Console.Write("Bitte gib deinen Namen ein: ");
            kunde_name = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(kunde_name))
            {
                kunde_name = "Gast";
            }

            Console.WriteLine($"Willkommen, {kunde_name}! 💖");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        static void Kunde_Menu()
        {
            Console.WriteLine($"Hey {kunde_name}, what do we wanna do today??!!");
            Console.WriteLine("(1) Check the Produkts!!");
            Console.WriteLine("(2) Show your orders");
            Console.WriteLine("(3) Add one product to your order");
            Console.WriteLine("(X) Log Out");
        }

        static void ZeigeKundeBestellungen()
        {
            Console.WriteLine("=== SHOWING YOUR BESTELLUNG ===");
            Console.WriteLine();

            if (kunde_bestellungen_count == 0)
            {
                Console.WriteLine("You don't have orders yet 😢");
            }
            else
            {
                for (int i = 0; i < kunde_bestellungen_count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {kunde_bestellungen[i]}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue!!");
            Console.ReadLine();
            Console.Clear();
        }

        static void SimuliereKundeBestellung()
        {
            Console.WriteLine("=== ADD PRODUCT TO YOUR ORDER ===");

            if (produkt_count == 0)
            {
                Console.WriteLine("No products available right now.");
                Console.ReadLine();
                Console.Clear();
                return;
            }

            for (int i = 0; i < produkt_count; i++)
            {
                Console.WriteLine($"[{i}] {produkt_name[i]} - {produkt_preis[i]} €");
            }

            Console.WriteLine();
            Console.Write("Choose product index: ");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index < 0 || index >= produkt_count)
            {
                Console.WriteLine("Invalid product index.");
            }
            else if (kunde_bestellungen_count >= kunde_bestellungen.Length)
            {
                Console.WriteLine("Order list is full boo!!");
            }
            else
            {
                kunde_bestellungen[kunde_bestellungen_count] = produkt_name[index];
                kunde_bestellungen_count++;
                Console.WriteLine($"Added '{produkt_name[index]}' to your orders ✅");
            }

            Console.WriteLine("Press Enter to Continue!!");
            Console.ReadLine();
            Console.Clear();
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

            if (produkt_count >= 20)
            {
                Console.WriteLine("Storage full boo!!");
                Console.ReadLine();
                return;
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

            if (produkt_count >= produkt_name.Length)
            {
                Console.WriteLine("Storage full boo!!");
                Console.ReadLine();
                return;
            }

            // all the new products are added to the array
            produkt_name[produkt_count] = name;
            produkt_anzahl[produkt_count] = amount;
            produkt_preis[produkt_count] = price;

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
            int Delete = Convert.ToInt32(Console.ReadLine());
            //TODO

            for (int i = Delete; i < produkt_count - 1; i++)
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

            produkt_count += 3;
        }

        static void FirstKundeBestellungen()
        {
            kunde_bestellungen[0] = "Mouse";
            kunde_bestellungen[1] = "Keyboard";
            kunde_bestellungen_count = 2;
        }


        static void Main(string[] args)
        {
            FirstProducts();
            FirstKundeBestellungen();
            Login();
        }



    }
}
