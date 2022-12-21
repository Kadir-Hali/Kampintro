// See https://aka.ms/new-console-template for more information

using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Entities.Customer {DateOfBirth = new DateTime(2000,2,10),FirstName="Abdulkadir",LastName="Halı",NationalityId="18869820608" });
            Console.ReadLine();
        }
    }
}

