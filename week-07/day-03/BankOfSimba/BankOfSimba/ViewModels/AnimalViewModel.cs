using BankOfSimba.Models;
using System.Collections.Generic;

namespace BankOfSimba.ViewModels
{
    public class AnimalViewModel
    {
        public List<BankAccount> AnimalsAccounts { get; set; } = new List<BankAccount>();

        public AnimalViewModel()
        {
            InitAnimalsAccounts();
        }

        public void InitAnimalsAccounts()
        {
            AnimalsAccounts.Add(new BankAccount()
            {
                Name = "Simba",
                Balance = 2000.00,
                AnimalType = "Animal.Lion",
                Currency = "Zebra"
            });

            AnimalsAccounts.Add(new BankAccount()
            {
                Name = "Scar",
                Balance = 666.00,
                AnimalType = "Animal.Lion",
                Currency = "Zebra"
            });

            AnimalsAccounts.Add(new BankAccount()
            {
                Name = "Mufasa",
                Balance = 1500.00,
                AnimalType = "Animal.Lion",
                Currency = "Zebra"
            });

            AnimalsAccounts.Add(new BankAccount()
            {
                Name = "Zazu",
                Balance = 3000.00,
                AnimalType = "Animal.RedBilledHornbill",
                Currency = "Zebra"
            });

            AnimalsAccounts.Add(new BankAccount()
            {
                Name = "Timon",
                Balance = 10.00,
                AnimalType = "Animal.Meerkat",
                Currency = "Zebra"
            });
        }

    }
}
