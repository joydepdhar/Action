﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class TopSearchSelleingproduct
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(15)]
        public string TopProductName { get; set; }
        [Required]
        public int Count { get; set; }
        public DateTime Time { get; set; }
    }
}
