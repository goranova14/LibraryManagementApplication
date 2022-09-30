using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.Intrinsics.Arm;
using BCrypt.Net;
using System.ComponentModel.DataAnnotations;
using System.Data;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LibraryBusiness
{
    public class Person
    {

        public Person()
        {

        }

        public Person(DataRow dataRow)
        {
            ID = (Guid)dataRow[nameof(ID)];
            Name =(String)dataRow[nameof(Name)];
            Username = (String)dataRow[nameof(Username)];
            SurName = (String)dataRow[nameof(SurName)];
            Address = (String)dataRow[nameof(Address)];
            //Role = (Guid)dataRow[nameof(ID)];
            // maybe make this an enum value?
            Role = DatabaseInstance.Instance.GetRoleByID((Guid)dataRow["RoleID"]);
        }

        public Guid ID { get; private set; }
        [ValidateNever]
        public Role Role { get; set; }
        [Required(ErrorMessage = "Please enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter Last name")]

        public string SurName { get; set; }
        [Required(ErrorMessage = "Please enter Address")]

        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter Password")]
        public string Password { get;set; }

        public override string ToString()
        {
            return $"{Name} {SurName} with {Address}({Username}.ToString()";
        }

    }
}
