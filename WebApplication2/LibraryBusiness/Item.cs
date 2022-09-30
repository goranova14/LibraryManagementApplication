using System.Data;
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
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LibraryBusiness
{
    public abstract class Item
    {
        public Item()
        {

        }
        public Item(DataRow dataRow)
        {

            Id = (Guid)dataRow["ID"];
            Author = (String)dataRow["Author"];
            Title = (String)dataRow["Title"];
            Publisher = (String)dataRow["Publisher"];
            Description = (String)dataRow["Description"];
            Genre = (String)dataRow["Genre"];
            Image = (byte[])dataRow["Image"];
        }
        public Guid Id { get; private set; }
        [Required(ErrorMessage = "Please enter Author")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Please enter AuthTitle")]

        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter Publisher")]

        public string Publisher { get; set; }
        [Required(ErrorMessage = "Please enter Description")]

        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter Genre")]
        public string Genre { get; set; }

        public byte[] Image { get; set; } = new byte[8];

        //public virtual List<Item> GetByGenre(string genre)
        //{

        //}
        public List<Review> GetReviews()
        {
            List<Review> reviews = new List<Review>();
            return reviews;
        }
        public bool CreateNewBook(Book newBook)
        {
            return DatabaseInstance.Instance.InsertNewItem(newBook);
        }
        public virtual string ToString()
        {
            return Title + Author + Publisher.ToString();
        }
    }
}
