using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WineSys
{
    class Program
    {
        // Metode der beder brugeren om at logge ind.
        // Returnerer true, hvis brugeren via login har adgang til systemet
        static bool Login(Winesys p_sys)
        {
            bool success = false;
            Console.Write("Username: ");
            string m_username = Console.ReadLine();
            Console.Write("Password: ");
            string m_password = Helpers.ReadPassword();
            foreach (User m_user in p_sys.Users.User)
                if ((m_user.Name == m_username) && (m_user.Password == m_password))
                    success = true;
            return success;
        }

        // Denne metode udskriver en liste over produkter i p_sys
        static void ProductList(Winesys p_sys)
        {
            Console.WriteLine("Product-list");
            Console.WriteLine("".PadLeft(120, '-'));
            Console.Write("ProductID");
            Console.SetCursorPosition(16, Console.CursorTop);
            Console.Write("Locat.");
            Console.SetCursorPosition(24, Console.CursorTop);
            Console.Write("Shelf");
            Console.SetCursorPosition(32, Console.CursorTop);
            Console.Write("Productname");
            Console.WriteLine();
            Console.WriteLine("".PadLeft(120, '-'));

            foreach (Product m_product in p_sys.Products.Product)
            {
                Console.Write(m_product.Pid);
                Console.SetCursorPosition(16, Console.CursorTop);
                Console.Write(m_product.Location);
                Console.SetCursorPosition(24, Console.CursorTop);
                Console.Write(m_product.Shelf);
                Console.SetCursorPosition(32, Console.CursorTop);
                Console.Write(m_product.Name);
                Console.WriteLine();
            }
            Console.WriteLine("".PadLeft(120, '-'));
            Console.WriteLine("Number of products: " + p_sys.Products.Product.Count.ToString());
            Console.WriteLine("".PadLeft(120, '-'));
        }

        static String NewOrderExample(Winesys p_sys)
        {
            Order m_order = new Order();
            m_order.Date = "2018-11-06";
            m_order.Oid = p_sys.nextOid();
            p_sys.Orders.Order.Add(m_order);
            m_order.Orderline = new List<Orderline>();
            Orderline m_orderline = new Orderline();
            m_orderline.Olid = "1";
            m_orderline.Quantity = "2";
            m_orderline.Pid = "FincaN2014";
            m_order.Orderline.Add(m_orderline);
            p_sys.setParents();
            return m_order.Oid;
        }

        static void ProduktStatistik(Winesys p_sys)
        {
            Console.WriteLine("Dansk Vin Import                               L A G E R - S T A T I S T I K");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                           |                                2 0 1 8                                |");
            Console.WriteLine("Produkt            | Primo | Jan | Feb | Mar | Apr | Maj | Jun | Jul | Aug | Sep | Okt | Nov | Dec | Lager |");
            Console.WriteLine("-------------------|-------|-----|-----|-----|-----|-----|-----|-----|-----|-----|-----|-----|-----|-------|");

            int[] m_quantities = new int[14];
            foreach(Product m_product in p_sys.Products.Product)
            {
                for (int i = 0; i < 14; i++)
                    m_quantities[i] = 0;
                foreach (Order m_order in p_sys.Orders.Order)
                {
                    DateTime m_date = DateTime.Parse(m_order.Date);
                    int m_qindex = 0;
                    if (m_date.Year == 2018)
                        m_qindex = m_date.Month;
                    if (m_date.Year > 2018)
                        m_qindex = 13;
                    foreach (Orderline m_line in m_order.Orderline)
                    {
                        if (m_line.Pid == m_product.Pid)
                        {
                            m_quantities[m_qindex] = m_quantities[m_qindex] - int.Parse(m_line.Quantity);
                        }
                    }
                }
                foreach (Delivery m_delivery in p_sys.Deliveries.Delivery)
                {
                    DateTime m_date = DateTime.Parse(m_delivery.Date);
                    int m_qindex = 0;
                    if (m_date.Year == 2018)
                        m_qindex = m_date.Month;
                    if (m_date.Year > 2018)
                        m_qindex = 13;
                    foreach (Deliveryline m_line in m_delivery.Deliveryline)
                    {
                        if (m_line.Pid == m_product.Pid)
                        {
                            m_quantities[m_qindex] = m_quantities[m_qindex] + int.Parse(m_line.Quantity);
                        }
                    }
                }
                Console.Write(m_product.Pid);
                Console.CursorLeft = 19;
                Console.Write("|");
                Console.Write(m_quantities[0].ToString().PadLeft(7));

                for (int i = 1; i < 13; i++)
                {
                    Console.CursorLeft = 21 + (i * 6);
                    Console.Write("|");
                    Console.Write(m_quantities[i].ToString().PadLeft(5));
                }

                //Console.CursorLeft = 99;
                //Console.Write("|");
                //for (int i )
                //Console.Write(m_quantities[13].ToString().PadLeft(7));
                //Console.Write("|");

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Winesys m_sys = Winesys.WinesysFromXML("..\\..\\WineSys_Data.xml");

            if (Login(m_sys))
            {
                do
                {
                    Console.Clear();
                    ProduktStatistik(m_sys);
                    //ProductList(m_sys);
                    //String m_ordernumber = NewOrderExample(m_sys);
                    //Console.WriteLine(m_ordernumber);
                    Console.WriteLine("Press any key to continue (ESC to quit).");
                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
                m_sys.Save(); // Gem data tilbage i xml-fil
            }
            else
            {
                Console.WriteLine("Username or password incorrect!");
                Console.ReadKey(true);
            }
        }
    }
}
