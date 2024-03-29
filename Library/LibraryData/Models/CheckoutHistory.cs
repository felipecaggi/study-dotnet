﻿using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryData.Models
{
    public class CheckoutHistory
    {
        public int Id { get; set; }

        [Required]
        public LibraryAsset LibraryAsset { get; set; }

        [Required]
        public LibraryCard LibraryCard { get; set; }

        [Required]
        public DateTime CheckoutOut { get; set; }

        public DateTime? CheckoutIn { get; set; }
    }
}
