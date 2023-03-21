namespace HW_3_3_lINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contacts = new List<Contact>()
        {
            new Contact() { Id = 1, FirstName = "John", LastName = "Doe", Age = 25 },
            new Contact() { Id = 2, FirstName = "Jane", LastName = "Doe",  Age = 30 },
            new Contact() { Id = 3, FirstName = "Bob", LastName = "Smith", Age = 40 },
            new Contact() { Id = 4, FirstName = "Alice", LastName = "Johnson",  Age = 20 },
            new Contact() { Id = 5, FirstName = "David", LastName = "Lee",  Age = 35 }
        };
            //First or default
            var contact = contacts.FirstOrDefault(x => x.Id == 2);
            Console.WriteLine(contact.FirstName + " " + contact.LastName);
            // Where
            var olderContacts = contacts.Where(x => x.Age > 30);
            foreach (var x in olderContacts)
            {
                Console.WriteLine(x.FirstName + " " + x);
            }
            //Select
            IEnumerable<string> contactNames = contacts.Select(x => x.FirstName);
            foreach (string name in contactNames)
            {
                Console.WriteLine($"Contact name: {name}");
            }
            // order by 
            IEnumerable<Contact> orderedContacts = contacts.OrderBy(x => x.FirstName);
            foreach (Contact names in orderedContacts)
            {
                Console.WriteLine($"Ordered contact: {contact.FirstName}");
            }
            IEnumerable<Contact> OrderedContacts = contacts.OrderBy(x => x.Age).Skip(2).OrderByDescending(x => x.Age);
            foreach (Contact contact1 in OrderedContacts)
            {
                Console.WriteLine($"Ordered by Age: {contact1.FirstName}");
            }


        }
    }
}