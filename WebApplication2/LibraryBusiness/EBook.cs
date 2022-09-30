using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusiness
{
    public class EBook : Book
    {
        public int DPI { get; set; }

        public EBook()
        {

        }
        public override string ToString()
        {
            return base.ToString() + DPI.ToString();
        }

        //internal override bool Add(EBook item)
        //{
        //    return base.Add(item);
        //}
    }
}
