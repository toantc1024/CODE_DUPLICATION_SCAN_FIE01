using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    public class ContactBST
    {
        public ContactNode Root;

        public ContactBST()
        {
            Root = null;
        }

        public void Insert(int contactID)
        {
            Root = InsertRec(Root, contactID);
        }

        private ContactNode InsertRec(ContactNode root, int contactID) // recursively
        {
            if (root == null)
            {
                root = new ContactNode(contactID);
                return root;
            }

            if (contactID < root.ContactID)
                root.Left = InsertRec(root.Left, contactID);
            else if (contactID > root.ContactID)
                root.Right = InsertRec(root.Right, contactID);

            return root;
        }

        public bool Search(int contactID)
        {
            return SearchRec(Root, contactID);
        }

        private bool SearchRec(ContactNode root, int contactID)
        {
            if (root == null)
                return false;

            if (root.ContactID == contactID)
                return true;

            return contactID < root.ContactID
                ? SearchRec(root.Left, contactID)
                : SearchRec(root.Right, contactID);
        }

        public List<int> GetSortedContacts()
        {
            List<int> result = new List<int>();
            InOrderRec(Root, result);
            return result;
        }

        private void InOrderRec(ContactNode root, List<int> result)
        {
            if (root != null)
            {
                InOrderRec(root.Left, result);
                result.Add(root.ContactID);
                InOrderRec(root.Right, result);
            }
        }
    }
}
