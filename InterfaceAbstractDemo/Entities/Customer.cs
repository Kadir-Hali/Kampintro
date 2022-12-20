// See https://aka.ms/new-console-template for more information
using InterfaceAbstractDemo.Abstract;

namespace InterfaceAbstractDemo.Entities
{
    public class Customer : IEntitiy
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}