using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusiness
{
    public class Book : Item
    {
        public int Pages { get; set; }
        public Book()
        {

        }
        public override string ToString()
        {
            return base.ToString()+Pages.ToString(); 
        }
    }
}
