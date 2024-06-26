﻿using System.ComponentModel.DataAnnotations.Schema;

namespace store.Models
{
    public class PhotoProduit
    {
        public int PhotoProduitId { get; set; }
        public String UrlImage { get; set; }
        public Product? Produit { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
    }
}
