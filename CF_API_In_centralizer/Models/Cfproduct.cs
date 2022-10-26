using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace CF_API_In_centralizer.Models
{
    public partial class Cfproduct 
    {
        public int Id { get; set; }
        public string Produto { get; set; } = null!;
        public double? Preco { get; set; }
        public DateTime DataOcorrencia { get; set; }
        public string Supermercado { get; set; } = null!;
    }
}
