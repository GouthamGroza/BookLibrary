﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.Models
{
    public class CustomerDetails
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }

    }
}
