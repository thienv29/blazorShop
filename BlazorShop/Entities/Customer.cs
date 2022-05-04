﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace BlazorShop.Entities
{
    public class Customer
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        

         public string AccountId { get; set; }

        [ForeignKey("AccountId")]
        public Account Account { get; set; }

        public ICollection<Bill> Bill { get; set; }
    }   
}
