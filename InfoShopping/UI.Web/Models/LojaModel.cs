﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UI.Web.Models
{
    public class LojaModel
    {
        [Required]
        [Key]
        public int LojaId { get; set; }
        public string OwnerId { get; set; }
        public String Nome { get; set; }
        public long cnpj { get; set; }
        public String NomeFantasia { get; set; }

        public int ShoppingId { get; set; }
        public ShoppingModel Shopping { get; set; }
    }
}