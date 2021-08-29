using System;

namespace AddressBook
{
  public class Contact
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }

    public Contact(string first, string last, string email, string address)
    {
      FirstName = first;
      LastName = last;
      Email = email;
      Address = address;
    }
  }
}



// Contact bob = new Contact() {
//             FirstName = "Bob", LastName = "Smith",
//             Email = "bob.smith@email.com",
//             Address = "100 Some Ln, Testville, TN 11111"
//         };