﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Marketplace.Models
{
    public class Ad
    {
      
            public Ad()
            {

            }

            public Ad(int approved, string authorId, string title, string content,decimal price, int categoryId, int townId, DateTime DateCreated)
            {
                this.Approved = approved;
                this.AuthorId = authorId;
                this.Title = title;
                this.Content = content;
                this.Price = price;
                this.CategoryId = categoryId;
                this.TownId = townId;
                this.DateCreated = DateTime.Now;
        }

            [Key]

            public int Id { get; set; }

            public int Approved { get; set; }

            [Required]
            [StringLength(255)]
            public string Title { get; set; }

            public string Content { get; set; }

            public decimal Price { get; set; }

            [ForeignKey("Author")]
            public string AuthorId { get; set; }

            public virtual ApplicationUser Author { get; set; }

            public bool IsAuthor(string name)
            {
                return this.Author.UserName.Equals(name);
            }

            [ForeignKey("Category")]
            public int CategoryId { get; set; }
            public virtual Category Category { get; set; }

             [ForeignKey("Town")]
             public int TownId { get; set; }
             public virtual Town Town { get; set; }


            
            public DateTime DateCreated { get; set; }



    }
}