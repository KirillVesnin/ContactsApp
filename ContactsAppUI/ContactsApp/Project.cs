using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class Project
    {
        public List<Contact> ContactList { private set; get; }

        public Project(List<Contact> ContactList)
        {
            if (ContactList == null)
            {
                throw new ArgumentNullException("Список контактов не может быть null");
            }
            else
            {
                this.ContactList = ContactList;
            }

        }

        public Project()
        {
            this.ContactList = new List<Contact>();
        }
    }
}   
