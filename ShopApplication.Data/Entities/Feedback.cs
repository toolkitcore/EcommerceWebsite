﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ShopApplication.Data.Enums;
using ShopApplication.Data.Interfaces;
using ShopApplication.Infrastructure.SharedKernels;

namespace ShopApplication.Data.Entities
{
    [Table("Feedbacks")]
    public class Feedback : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public Feedback() { }

        public Feedback(int id, string name, string email, string message, Status status)
        {
            Id = id;
            Name = name;
            Email = email;
            Message = message;
            Status = status;
        }
        [StringLength(250)]
        [Required]
        public string Name { set; get; }

        [StringLength(250)]
        public string Email { set; get; }

        [StringLength(500)]
        public string Message { set; get; }

        public Status Status { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
    }
}
