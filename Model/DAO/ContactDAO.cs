using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class ContactDAO
    {
        GuitarShopDbContext db = null;

        public ContactDAO()
        {
            db = new GuitarShopDbContext();
        }
        public int Insert(MESSAGE contact)
        {
            db.MESSAGE.Add(contact);
            db.SaveChanges();
            return contact.Id;
        }
    }
}
