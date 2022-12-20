// See https://aka.ms/new-console-template for more information

using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Entities.Customer {DateOfBirth = new DateTime(2000,2,10),FirstName="Kadir",LastName="Halı",NationalityId="11111111111" });
        }
    }
}

