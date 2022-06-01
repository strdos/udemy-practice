using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerablePractice
{
    internal class Phonebook : IEnumerable<Contact>
    {
        public List<Contact> Contacts;
        public Phonebook()
        {
            Contacts = new List<Contact>{
            new Contact("Andre", "435797087"),
            new Contact("Lisa", "435611258"),
            new Contact("Dine", "546786452"),
            new Contact("Sofi", "956328412")
            };
        }

        IEnumerator<Contact> IEnumerable<Contact>.GetEnumerator()
        {
            return Contacts.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
