using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    public class ContactNode
    {
        public int ContactID;
        public ContactNode Left;
        public ContactNode Right;

        public ContactNode(int id)
        {
            ContactID = id;
            Left = null;
            Right = null;
        }
    }
}
