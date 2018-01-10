using BankOfSimba.Models;
using System.Collections.Generic;

namespace BankOfSimba.ViewModels
{
    public class AnimalViewModel
    {
        public List<BankAccount> AnimalsAccounts = new List<BankAccount>();

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
                AnimalType = "Lion",
                Currency = "Zebra",
                IsGood = true
            });

            AnimalsAccounts.Add(new BankAccount()
            {
                Name = "Scar",
                Balance = 666.00,
                AnimalType = "Lion",
                Currency = "Zebra",
                IsGood = false
            });

            AnimalsAccounts.Add(new BankAccount()
            {
                Name = "Mufasa",
                Balance = 1500.00,
                AnimalType = "Lion",
                Currency = "Zebra",
                IsGood = true
            });

            AnimalsAccounts.Add(new BankAccount()
            {
                Name = "Zazu",
                Balance = 3000.00,
                AnimalType = "Red Billed Hornbill",
                Currency = "Zebra",
                IsGood = true
            });

            AnimalsAccounts.Add(new BankAccount()
            {
                Name = "Timon",
                Balance = 10.00,
                AnimalType = "Meerkat",
                Currency = "Zebra",
                IsGood = true
            });
        }

    }
}
