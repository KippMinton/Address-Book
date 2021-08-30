using System;
using System.Collections.Generic;

namespace AddressBook
{
  public class AddressBook
  {
    public Dictionary<string, Contact> Contacts { get; set; }

    public AddressBook()
    {
      Contacts = new Dictionary<string, Contact>();
    }

    public void AddContact(Contact contact)
    {
      try
      {
        Contacts.Add(contact.Email, contact);
      }
      catch
      {
        Console.WriteLine("----------------------------");
        Console.WriteLine($"Contact {contact.Email} already exists!");
      }
    }

    public Contact GetByEmail(String email)
    {
      return Contacts[email];
    }
  }
}