using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BorrowLend.Models
{
    public class ExtenseType
    {
        private int id;
        private string extenseTypeText;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string ExtenseTypeText
        {
            get { return extenseTypeText; }
            set { extenseTypeText = value; }
        }
    }
}
