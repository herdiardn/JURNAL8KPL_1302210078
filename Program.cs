using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Program
{
    public static void Main(string[] args)
    {
        BankTransferConfig bankConfig = new BankTransferConfig();
        int transfer;
        string method;
        string confirmation;

        for (int i = 0; i < 2; i++)
        {
            if (bankConfig.config.lang == "en")
            {
                Console.Write("Please insert the amount of money to transfer : ");
                transfer = Convert.ToInt32(Console.ReadLine());
                if (transfer <= bankConfig.config.transfer.threshold)
                {
                    Console.WriteLine("Transfer fee = " + bankConfig.config.transfer.low_fee);
                    Console.WriteLine("Total amount = " + (transfer + bankConfig.config.transfer.low_fee));
                }
                else if (transfer > bankConfig.config.transfer.threshold)
                {
                    Console.WriteLine("Transfer fee = " + bankConfig.config.transfer.high_fee);
                    Console.WriteLine("Total amount = " + (transfer + bankConfig.config.transfer.high_fee));
                }

                Console.WriteLine("\nSelect transfer method : ");
                Console.WriteLine("1. " + bankConfig.config.methods[0]);
                Console.WriteLine("2. " + bankConfig.config.methods[1]);
                Console.WriteLine("3. " + bankConfig.config.methods[2]);
                Console.WriteLine("4. " + bankConfig.config.methods[3]);
                Console.WriteLine();
                method = Console.ReadLine();

                Console.Write("\nPlease type yes to confirm the transaction : ");
                confirmation = Console.ReadLine();
                Console.WriteLine();
                if (confirmation == "yes")
                {
                    Console.WriteLine("The transfer is completed");
                }
                else
                {
                    Console.WriteLine("Transfer is cancelled");
                }
            }
            else if (bankConfig.config.lang == "id")
            {
                Console.Write("Masukkan jumlah uang yang akan di-transfer : ");
                transfer = Convert.ToInt32(Console.ReadLine());
                if (transfer <= bankConfig.config.transfer.threshold)
                {
                    Console.WriteLine("Biaya transfer = " + bankConfig.config.transfer.low_fee);
                    Console.WriteLine("Total biaya = " + (transfer + bankConfig.config.transfer.low_fee));
                }
                else if (transfer > bankConfig.config.transfer.threshold)
                {
                    Console.WriteLine("Biaya transfer = " + bankConfig.config.transfer.high_fee);
                    Console.WriteLine("Total biaya = " + (transfer + bankConfig.config.transfer.high_fee));
                }

                Console.WriteLine("\nPilih metode transfer : ");
                Console.WriteLine("1. " + bankConfig.config.methods[0]);
                Console.WriteLine("2. " + bankConfig.config.methods[1]);
                Console.WriteLine("3. " + bankConfig.config.methods[2]);
                Console.WriteLine("4. " + bankConfig.config.methods[3]);
                Console.WriteLine();
                method = Console.ReadLine();

                Console.Write("\nKetik ya untuk mengkonfirmasi transaksi : ");
                confirmation = Console.ReadLine();
                Console.WriteLine();
                if (confirmation == "ya")
                {
                    Console.WriteLine("Proses transfer berhasil");
                }
                else
                {
                    Console.WriteLine("Transfer dibatalkan");
                }
            }
            Console.WriteLine();
            bankConfig.UbahBahasa();

        }
    }
}