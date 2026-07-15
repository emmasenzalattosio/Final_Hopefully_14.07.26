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
        static string[] kunde_name = new string[20];
        static string[] kunde_bestellungen = new string[20];
        static int[] kunde_bestellmenge = new int[20];
        static int bestellungen_count = 0;

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

                //Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("══════════════════════════════════════════════════════════════════════");
                Console.WriteLine("          █████╗  ██████╗ ██████╗███████╗███████╗███████╗");
                Console.WriteLine("         ██╔══██╗██╔════╝██╔════╝██╔════╝██╔════╝██╔════╝");
                Console.WriteLine("         ███████║██║     ██║     █████╗  ███████╗███████╗");
                Console.WriteLine("         ██╔══██║██║     ██║     ██╔══╝  ╚════██║╚════██║");
                Console.WriteLine("         ██║  ██║╚██████╗╚██████╗███████╗███████║███████║");
                Console.WriteLine("         ╚═╝  ╚═╝ ╚═════╝ ╚═════╝╚══════╝╚══════╝╚══════╝");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("               ◤ AUTHENTICATION TERMINAL ◢");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                   SELECT USER PROFILE");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("             ╭──────────────────────────────╮");
                Console.WriteLine("             │  [ M ]   MANAGER             │");
                Console.WriteLine("             │                              │");
                Console.WriteLine("             │  [ K ]   KUNDE               │");
                Console.WriteLine("             │                              │");
                Console.WriteLine("             │  [ L ]   LIEFERANT           │");
                Console.WriteLine("             ╰──────────────────────────────╯");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                      >>> INPUT: ");
                Console.WriteLine("══════════════════════════════════════════════════════════════════════");
                Console.ResetColor();


                char user = Console.ReadKey().KeyChar;

                Console.Clear();
                switch (char.ToUpper(user))
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






        //2nd Methode for the Manager rechte
        static void Auswahl_Manager()
        {
            Emoji();
            bool second_loop = true;

            while (second_loop)
            {
                Manager_Menu();

                char auswahl = ' ';
                auswahl = Console.ReadKey().KeyChar;

                Console.Clear();
                switch (char.ToUpper(auswahl))
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
                        second_loop = false;
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
                Kunde_Menu();

                char auswahl1 = Console.ReadKey().KeyChar;
                Console.Clear();

                switch (char.ToUpper(auswahl1))
                {
                    case '1':
                        // Calling the Produkt Methode to show the available items 
                        show_products();
                        break;

                    case '2':
                        ShowKundeBestellung();
                        break;

                    case '3':
                        Kunde_Active_Bestellung();
                        break;

                    case 'X':
                        Console.WriteLine();
                        Console.WriteLine();

                        third_loop = false;
                        break;
                }
            }

            Console.Clear();
        }
        // 4th Methode for the Lieferant rechte
        // Easy switch - case for the action 


        //To do - Change the add function
        static void Auswahl_Lieferant()
        {
            Emoji();
            bool fourth_loop = true;
            while (fourth_loop)
            {
                Stock_Notification();
                lieferant_menu();

                char auswahl2 = ' ';
                auswahl2 = Console.ReadKey().KeyChar;
                Console.Clear();

                switch (char.ToUpper(auswahl2))
                {

                    case '1':
                        show_products();
                        break;

                    case '2':
                        produkt_lieferung();
                        break;

                    case 'X':

                        Console.WriteLine();
                        Console.WriteLine();
                        fourth_loop = false;
                        break;

                }
            }

        }


        static void Stock_Notification()
        {
            Console.WriteLine();
            Console.WriteLine("STOCK NOTIFICATION");


            for (int i = 0; i < produkt_count; i++)
            {
                if (produkt_anzahl[i] < 5)
                {

                    Console.WriteLine($"RESTOCK NEEDED: {produkt_name[i]} - LEFT PIECES: {produkt_anzahl[i]}");
                }
            }
        }



        //Methoden for the Kunde rechte
        static void ShowKundeBestellung()
        {
            Console.WriteLine("══════════════════════════════════════════════════════");
            Console.WriteLine("                  ACCESS TERMINAL");
            Console.WriteLine("══════════════════════════════════════════════════════");
            Console.WriteLine();
            Console.WriteLine("                  ▼ YOUR ORDERS ▼");
            Console.WriteLine();

            for (int i = 0; i < bestellungen_count; i++)
            {
                decimal kunde_price = 0;

                for (int x = 0; x < produkt_name.Length; x++)
                {
                    if (produkt_name[x] == kunde_bestellungen[i])
                    {
                        kunde_price = produkt_preis[x];
                    }
                }

                int menge = kunde_bestellmenge[i];
                decimal gesamt = kunde_price * menge;

                Console.WriteLine(" ┌─────────────────────────────────────┐");
                Console.WriteLine($" │ ORDER: {i,-28} |");
                Console.WriteLine(" |                                     |");
                Console.WriteLine($" │ PRODUCT: {kunde_bestellungen[i],-18}         |");
                Console.WriteLine(" |                                     |");
                Console.WriteLine($" | PRICE: {kunde_price,-18}           |");
                Console.WriteLine($" │ TOTAL: {gesamt,-27}|");
                Console.WriteLine(" └─────────────────────────────────────┘");
            }


            Console.WriteLine();
            Console.WriteLine(">>> PRESS ENTER TO CONTINUE...");
            Console.ReadLine();
            Console.Clear();
        }

        static void Kunde_Active_Bestellung()
        {
            Console.WriteLine("══════════════════════════════════════════════════════");
            Console.WriteLine("                  ACCESS TERMINAL");
            Console.WriteLine("══════════════════════════════════════════════════════");

            for (int i = 0; i < produkt_count; i++)
            {
                Console.WriteLine(" ┌─────────────────────────────────────┐");
                Console.WriteLine($" │ ORDER: {i,-28} |");
                Console.WriteLine(" |                                     |");
                Console.WriteLine($" │ PRODUCT: {produkt_name[i],-18}         |");
                Console.WriteLine(" |                                     |");
                Console.WriteLine($" | PRICE: {produkt_preis[i],-18}           |");
                Console.WriteLine(" └─────────────────────────────────────┘");
            }

            Console.WriteLine();
            Console.Write(">>> PRODUCT TO ADD: ");
            int product_add = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(">>> PRODUCT QUANTITY: ");
            int product_menge = Convert.ToInt32(Console.ReadLine());

            //Saving the order - Here the user eingabe is saved in the array at the count position
            kunde_bestellungen[bestellungen_count] = produkt_name[product_add];
            kunde_bestellmenge[bestellungen_count] = product_menge;
            bestellungen_count++;

            //Update of the amount in the list = to the ordered amount (subtraction)
            produkt_anzahl[product_add] -= product_menge;

            Console.WriteLine(">>> PRESS ENTER TO CONTINUE...");
            Console.ReadLine();
            Console.Clear();
        }


        // Methode that shows all the saved products
        static void show_products()
        {
            Emoji();
            Console.Clear();
            Console.WriteLine("██████╗ ██████╗  ██████╗ ██████╗ ██╗   ██╗ ██████╗████████╗███████╗");
            Console.WriteLine("██╔══██╗██╔══██╗██╔═══██╗██╔══██╗██║   ██║██╔════╝╚══██╔══╝██╔════╝");
            Console.WriteLine("██████╔╝██████╔╝██║   ██║██║  ██║██║   ██║██║        ██║   ███████╗");
            Console.WriteLine("██╔═══╝ ██╔══██╗██║   ██║██║  ██║██║   ██║██║        ██║   ╚════██║");
            Console.WriteLine("██║     ██║  ██║╚██████╔╝██████╔╝╚██████╔╝╚██████╗   ██║   ███████║");
            Console.WriteLine("╚═╝     ╚═╝  ╚═╝ ╚═════╝ ╚═════╝  ╚═════╝ ╚═════╝   ╚═╝   ╚══════╝ ");
            Console.WriteLine();
            Console.WriteLine("               ◢ PRODUCT INVENTORY TERMINAL ◣");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("     ┌────┬────────────────┬─────────┬─────────────┐");
            Console.WriteLine("     │ ID │ PRODUCT        │ STOCK   │ PRICE       │");
            Console.WriteLine("     ├────┼────────────────┼─────────┼─────────────┤");

            //Schleife that checks the products and for every added one shows details
            for (int i = 0; i < produkt_count; i++)
            {

                Console.WriteLine($"     | {i}  | {produkt_name[i],-12}   | {produkt_anzahl[i],-7} | {produkt_preis[i],-11} | ");
            }
            Console.WriteLine("     └────┴────────────────┴─────────┴─────────────┘");

            if (produkt_count >= produkt_name.Length)
            {
                Console.WriteLine(">>> STORAGE FULL!");
                Console.ReadLine();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("PRESS ENTER TO CONTINUE...");
            Console.ReadLine();
            Console.Clear();
        }

        // TO DO
        static void produkt_lieferung()
        {

            {


                Emoji();
                Console.Clear();
                Console.WriteLine(" ██╗     ██╗███████╗███████╗██████╗ ██╗   ██╗███╗   ██╗███╗   ██╗ ██████╗ ");
                Console.WriteLine(" ██║     ██║██╔════╝██╔════╝██╔══██╗██║   ██║████╗  ██║████╗  ██║██╔════╝ ");
                Console.WriteLine(" ██║     ██║█████╗  █████╗  ██████╔╝██║   ██║██╔██╗ ██║██╔██╗ ██║██║  ███╗");
                Console.WriteLine(" ██║     ██║██╔══╝  ██╔══╝  ██╔══██╗██║   ██║██║╚██╗██║██║╚██╗██║██║   ██║");
                Console.WriteLine(" ███████╗██║██║     ███████╗██║  ██║╚██████╔╝██║ ╚████║██║ ╚████║╚██████╔╝");
                Console.WriteLine(" ╚══════╝╚═╝╚═╝     ╚══════╝╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝  ╚═══╝ ╚═════╝ ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("    ██████╗ ██████╗  ██████╗ ██████╗ ██╗   ██╗ ██████╗████████╗███████╗");
                Console.WriteLine("    ██╔══██╗██╔══██╗██╔═══██╗██╔══██╗██║   ██║██╔════╝╚══██╔══╝██╔════╝");
                Console.WriteLine("    ██████╔╝██████╔╝██║   ██║██║  ██║██║   ██║██║        ██║   ███████╗");
                Console.WriteLine("    ██╔═══╝ ██╔══██╗██║   ██║██║  ██║██║   ██║██║        ██║   ╚════██║");
                Console.WriteLine("    ██║     ██║  ██║╚██████╔╝██████╔╝╚██████╔╝╚██████╗   ██║   ███████║");
                Console.WriteLine("    ╚═╝     ╚═╝  ╚═╝ ╚═════╝ ╚═════╝  ╚═════╝  ╚═════╝   ╚═╝   ╚══════╝");
                Console.WriteLine();

                for (int i = 0; i < produkt_count; i++)
                {
                    Console.WriteLine($"[{i}] {produkt_name[i]} {produkt_anzahl[i]} {produkt_preis[i]}");
                }

                Console.WriteLine("SELECT A PRODUCT TO STOCK UP: ");
                int stock = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("INSERT THE AMOUNT HERE");
                int stock_amount = Convert.ToInt32(Console.ReadLine());

                produkt_anzahl[stock] += stock_amount;

                Console.WriteLine("LIEFERUNG COMPLETE!");
                Console.ReadLine();
                Console.Clear();

            }
        }


        // Adding products Methode
        static void AddProduct()
        {
            Emoji();
            Console.Clear();
            Console.WriteLine("                     █████╗ ██████╗ ██████╗ ");
            Console.WriteLine("                    ██╔══██╗██╔══██╗██╔══██╗");
            Console.WriteLine("                    ███████║██║  ██║██║  ██║");
            Console.WriteLine("                    ██╔══██║██║  ██║██║  ██║");
            Console.WriteLine("                    ██║  ██║██████╔╝██████╔╝");
            Console.WriteLine("                    ╚═╝  ╚═╝╚═════╝ ╚═════╝ ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("    ██████╗ ██████╗  ██████╗ ██████╗ ██╗   ██╗ ██████╗████████╗███████╗");
            Console.WriteLine("    ██╔══██╗██╔══██╗██╔═══██╗██╔══██╗██║   ██║██╔════╝╚══██╔══╝██╔════╝");
            Console.WriteLine("    ██████╔╝██████╔╝██║   ██║██║  ██║██║   ██║██║        ██║   ███████╗");
            Console.WriteLine("    ██╔═══╝ ██╔══██╗██║   ██║██║  ██║██║   ██║██║        ██║   ╚════██║");
            Console.WriteLine("    ██║     ██║  ██║╚██████╔╝██████╔╝╚██████╔╝╚██████╗   ██║   ███████║");
            Console.WriteLine("    ╚═╝     ╚═╝  ╚═╝ ╚═════╝ ╚═════╝  ╚═════╝  ╚═════╝   ╚═╝   ╚══════╝");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine(">>PRODUCT NAME: ");
            string name = Console.ReadLine()!;

            Console.WriteLine(">>AMOUNT: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(">>PRICE: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            // all the new products are added to the array
            produkt_name[produkt_count] = name;
            produkt_anzahl[produkt_count] = amount;
            produkt_preis[produkt_count] = price;

            produkt_count++;
            Console.WriteLine("Product added!!");
            Console.ReadLine();

        }

        // deleting products Methode
        static void DeleteProduct()
        {
            Emoji();
            Console.WriteLine("    ██████╗ ███████╗██╗     ███████╗████████╗███████╗ ");
            Console.WriteLine("    ██╔══██╗██╔════╝██║     ██╔════╝╚══██╔══╝██╔════╝ ");
            Console.WriteLine("    ██║  ██║█████╗  ██║     █████╗     ██║   █████╗   ");
            Console.WriteLine("    ██║  ██║██╔══╝  ██║     ██╔══╝     ██║   ██╔══╝   ");
            Console.WriteLine("    ██████╔╝███████╗███████╗███████╗   ██║   ███████╗ ");
            Console.WriteLine("    ╚═════╝ ╚══════╝╚══════╝╚══════╝   ╚═╝   ╚══════╝ ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("    ██████╗ ██████╗  ██████╗ ██████╗ ██╗   ██╗ ██████╗████████╗███████╗");
            Console.WriteLine("    ██╔══██╗██╔══██╗██╔═══██╗██╔══██╗██║   ██║██╔════╝╚══██╔══╝██╔════╝");
            Console.WriteLine("    ██████╔╝██████╔╝██║   ██║██║  ██║██║   ██║██║        ██║   ███████╗");
            Console.WriteLine("    ██╔═══╝ ██╔══██╗██║   ██║██║  ██║██║   ██║██║        ██║   ╚════██║");
            Console.WriteLine("    ██║     ██║  ██║╚██████╔╝██████╔╝╚██████╔╝╚██████╗   ██║   ███████║");
            Console.WriteLine("    ╚═╝     ╚═╝  ╚═╝ ╚═════╝ ╚═════╝  ╚═════╝  ╚═════╝   ╚═╝   ╚══════╝");
            Console.WriteLine();

            for (int i = 0; i < produkt_count; i++)
            {
                Console.WriteLine($"[{i}] {produkt_name[i]}");
            }

            Console.WriteLine();
            Console.WriteLine(">>SELECT PRODUCT TO DELETE: ");
            int Delete = Convert.ToInt32(Console.ReadLine());
            //TODO

            for (int i = Delete; i < produkt_count - 1; i++)
            {
                produkt_name[i] = produkt_name[i + 1];
                produkt_anzahl[i] = produkt_anzahl[i + 1];
                produkt_preis[i] = produkt_preis[i + 1];
            }

            produkt_count--;
            Console.WriteLine("PRODUCT DELETED!!");
        }






        // arrays full of the festgelegte produkte
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

        static void FirstKundeBestellung()
        {
            kunde_bestellungen[0] = "Laptop";
            kunde_bestellmenge[0] = 1;

            kunde_bestellungen[1] = "Mouse";
            kunde_bestellmenge[1] = 1;

            bestellungen_count += 2;
        }






        // Styling choices for: Login - different menus
        static void access_panel()
        {
            Console.WriteLine("     ████████████████████████████████████████████");
            Console.WriteLine();
            Console.WriteLine("                  NEXUS ACCESS NODE");
            Console.WriteLine();
            Console.WriteLine("     ████████████████████████████████████████████");
            Console.WriteLine();
            Console.WriteLine("              Loading security modules...");
            Console.WriteLine();
            Console.WriteLine("> ENTER OPERATOR NAME");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("     ████████████████████████████████████████████");
            Console.WriteLine();
            Console.WriteLine("                   ACCESS GRANTED");
            Console.WriteLine();
            Console.WriteLine("     ████████████████████████████████████████████");
            Console.WriteLine();
            Console.WriteLine("             Connection Status : ONLINE");
            Console.WriteLine("             Firewall          : ACTIVE");
            Console.WriteLine("             Encryption        : ENABLED");
            Console.WriteLine();
            Console.WriteLine("     ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine();
            Console.WriteLine("Press [ ENTER ] to continue...");
            Console.ReadLine();
            Console.Clear();


        }

        static void Manager_Menu()
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

        static void Kunde_Menu()
        {
            Console.WriteLine("═══════════════════════════════════════════════════════");
            Console.WriteLine();
            Console.WriteLine("                NEXUS TERMINAL");
            Console.WriteLine("              CLIENT INTERFACE v3.2");
            Console.WriteLine();
            Console.WriteLine("═══════════════════════════════════════════════════════");
            Console.WriteLine();
            Console.WriteLine(">> USER DETECTED");
            Console.WriteLine($"   ID : {kunde_name}");
            Console.WriteLine();
            Console.WriteLine("───────────────────────────────────────────────────────");
            Console.WriteLine();
            Console.WriteLine(" Select an operation:");
            Console.WriteLine();
            Console.WriteLine(" [1] 📦  Browse Products");
            Console.WriteLine();
            Console.WriteLine(" [2] 📄  View Orders");
            Console.WriteLine();
            Console.WriteLine(" [3] ➕  Place New Order");
            Console.WriteLine();
            Console.WriteLine(" [X] \u23fb  Disconnect");
            Console.WriteLine();
            Console.WriteLine("───────────────────────────────────────────────────────");
            Console.WriteLine(" Awaiting input...");
        }

        static void lieferant_menu()
        {
            //Console.Clear();
            Console.WriteLine("═══════════════════════════════════════════════════════");
            Console.WriteLine();
            Console.WriteLine("                NEXUS TERMINAL");
            Console.WriteLine("              CLIENT INTERFACE v3.2");
            Console.WriteLine();
            Console.WriteLine("═══════════════════════════════════════════════════════");
            Console.WriteLine();
            Console.WriteLine(">> USER DETECTED");
            Console.WriteLine($"   ID : ");
            Console.WriteLine();
            Console.WriteLine("───────────────────────────────────────────────────────");
            Console.WriteLine();
            Console.WriteLine(" Select an operation:");
            Console.WriteLine();
            Console.WriteLine(" [1] 📦  Browse Products");
            Console.WriteLine();
            Console.WriteLine(" [2] ➕  Deliever Products");
            Console.WriteLine();
            Console.WriteLine(" [X] \u23fb  Disconnect");
            Console.WriteLine();
            Console.WriteLine("───────────────────────────────────────────────────────");
            Console.WriteLine(" Awaiting input...");
        }





        static void Main(string[] args)
        {
            FirstProducts();
            FirstKundeBestellung();
            Login();
        }



    }
}
