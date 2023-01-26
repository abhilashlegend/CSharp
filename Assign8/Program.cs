using System.Collections;

namespace Assign8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PhoneBook MyPhoneBook = new PhoneBook();

            foreach (Contact contact in MyPhoneBook)
            {
                contact.Call();
            }
        }
    }

    public class Contact
    {
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public Contact(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public void Call()
        {
            Console.WriteLine("Calling to {0}. Phone number is {1}", Name, PhoneNumber);
        }
    }

    public class PhoneBook : IEnumerable
    {
        public List<Contact> Contacts = new List<Contact> {
                new Contact("Andre", "435797087"),
                new Contact("Lisa", "435677087"),
                new Contact("Dine", "3457697087"),
                new Contact("Sofi", "4367697087")
        };

        public IEnumerator GetEnumerator()
        {
           return Contacts.GetEnumerator();
        }
    }
}