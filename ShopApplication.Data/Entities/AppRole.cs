﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace ShopApplication.Data.Entities
{
    [Table("AppRoles")]
    public class AppRole : IdentityRole<Guid>
    {
        public AppRole() : base()
        {

        }
        public AppRole(string name, string description) : base(name)
        {
           
            this.Description = description;
        }

        [StringLength(250)]
        public string Description { get; set; }
    }
}
