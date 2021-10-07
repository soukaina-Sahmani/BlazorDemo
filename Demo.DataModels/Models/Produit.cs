using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.DataModels.Models
{
    public partial class Produit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }
    }
}
