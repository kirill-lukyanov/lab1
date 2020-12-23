using System;
using System.IO;
using System.Collections.Generic;

namespace Lab11
{
    class Client
    {
        public string id, LastName, FirstName, email;
        public double Plus, Minus;
        public string Credit_card;
        public double tax;

        public Client(string line)
        {
            string[] e = line.Split(',');
            id = e[0].Trim();
            LastName = e[1].Trim();
            FirstName = e[2].Trim();
            email = e[3].Trim();
            Plus = Convert.ToDouble(e[4].TrimStart('$').Replace('.', ','));
            Minus = Convert.ToDouble(e[5].TrimStart('$').Replace('.', ','));
            Credit_card = e[6].Trim();
            tax = Convert.ToDouble(e[7].TrimStart('$').Replace('.', ','));
        }

        public string Client_Card
        {
            get
            {
                return
                    "**********************************************\n" +
                    $"ID: {id}\n Last Name: {LastName}\n First Name: {FirstName}\n e-mail: {email}\n Credit Cart: {Credit_card}\n" +
                    "**********************************************\n";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("lr11_10.csv");

            List<Client> clients = new List<Client>();

            string line = sr.ReadLine();
            while ((line = sr.ReadLine()) != null)
            {
                clients.Add(new Client(line));
            }

            ////// Задание №1 ///////

            int CountWithNeg = 0;
            foreach(Client client in clients)
            {
                if (client.Plus < client.Minus)
                    CountWithNeg++;
            }
            Console.WriteLine($"*** Задание №1 ***");
            Console.WriteLine($"{CountWithNeg} клиентов имеют отрицательный баланс счета\n");

            ////// Задание №2 ///////

            double TaxSum = 0;
            double AverageTaxSum;

            foreach (Client client in clients)
            {
                TaxSum += client.tax;
            }
            AverageTaxSum = TaxSum / clients.Count;
            Console.WriteLine($"*** Задание №2 ***");
            Console.WriteLine($"{Math.Round(AverageTaxSum,4)}$ - средняя сумма налогов по счетам\n");

            ////// Задание №3 ///////

            double MaxSpend = Double.NegativeInfinity;
            Client clientMaxSpend = null;
            foreach (Client client in clients)
            {
                if (client.Minus > MaxSpend)
                {
                    MaxSpend = client.Minus;
                    clientMaxSpend = client;
                }
            }
            Console.WriteLine($"*** Задание №3 ***");
            Console.WriteLine($"Клиент с максимальными расходами - {clientMaxSpend.Minus}$:");
            if (clientMaxSpend != null)
                Console.WriteLine(clientMaxSpend.Client_Card);

            ////// Задание №4 ///////

            double PlusSum = 0;
            double AveragePlusSum;

            foreach (Client client in clients)
            {
                if (client.email == "")
                    PlusSum += client.tax;
            }
            AveragePlusSum = PlusSum / clients.Count;

            Console.WriteLine($"*** Задание №4 ***");
            Console.WriteLine($"{Math.Round(AveragePlusSum,4)}$ - средний доход по счету для клиентов без e-mail\n");

            Console.ReadKey();
        }
    }
}
