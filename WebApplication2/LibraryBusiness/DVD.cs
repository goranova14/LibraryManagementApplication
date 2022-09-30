using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusiness
{
    [Table("DVD")]
    public class DVD : Item
    {
        public string Studio { get; set; }
        public string Director { get; set; }
        public DVD()
        {

        }
        public override string ToString()
        {
            return Studio + " "+ Director.ToString();
        }
        //internal override bool Add(Item item)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
