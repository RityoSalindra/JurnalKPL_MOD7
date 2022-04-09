using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_1302204014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankTransferConfig();

            string lang;

            Console.WriteLine("language (en/id): ", lang);
            lang = "id";
            if (lang != "id")
            {
                int a = Console.WriteLine("Please insert the amount of money to transfer:", CONFIG1);
                string[] CONFIG5 = new string[4] { "RTO(real-time", "SKN", "RTGS", "BI FAST" };
                int CONFIG3 = 6500;
                int CONFIG4 = 15000;
                int CONFIG2 = 25000000;
                string CONFIG7 = "ya";
                if (a <= CONFIG2)
                {
                    Console.WriteLine(CONFIG3);
                    Console.WriteLine("Transfer fee :", CONFIG3 + a);
                }
                else
                {
                    Console.WriteLine(CONFIG4);
                    Console.WriteLine("Transfer fee :", CONFIG4 + a);
                }
                Console.WriteLine("Select transfer method: ", CONFIG5);
                Console.WriteLine("Please type", CONFIG7, "to confirm the transaction");
                Console.WriteLine("The transfer is complete");


            }
            else
            {

                int b = Console.WriteLine("Masukan jumlah uang yang akan di transfer: ", CONFIG1);
                string[] CONFIG5 = new string[4] { "RTO(real-time", "SKN", "RTGS", "BI FAST" };
                int CONFIG2 = 25000000;
                int CONFIG3 = 6500;
                int CONFIG4 = 15000;
                string CONFIG6 = "yes";
                if (b <= CONFIG2)
                {
                    Console.WriteLine(CONFIG3);
                    Console.WriteLine("Total Biaya :", CONFIG3 + b);
                }
                else
                {
                    Console.WriteLine(CONFIG4);
                    Console.WriteLine("Total Biaya", CONFIG4 + b);
                }
                Console.WriteLine("Pilih metode transfer: ", CONFIG5);
                Console.WriteLine("ketik", CONFIG6, "untuk mengkonfirmasi transaksi");
                Console.WriteLine("Proses transfer berhasil");
            }

        }

        public class BankTransferConfig
        {
            string CONFIG1 = "en";
            int CONFIG2 = 25000000;
            int CONFIG3 = 6500;
            int CONFIG4 = 15000;
            string[] CONFIG5 = new string[4] { "RTO(real-time", "SKN", "RTGS", "BI FAST" };
            string CONFIG6 = "yes";
            string CONFIG7 = "ya";




        }
    }
}