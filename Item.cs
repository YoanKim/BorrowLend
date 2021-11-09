using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BorrowLend.Models
{
    public class Item
    {
        private int id;
        private string itemName;
        private string borrower;
        private string lender;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public string Borrower
        {
            get { return borrower; }
            set { borrower = value; }
        }

        public string Lender
        {
            get { return lender; }
            set { lender = value; }
        }
    }
}
