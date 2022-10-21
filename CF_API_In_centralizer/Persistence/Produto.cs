using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CF_API_In_centralizer.Persistence
{
    [Table("CFPRODUCTS")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(300)]
        public string? PRODUTO { get; set; }
        [Column("PRECO")]
        public double Preco { get; set; }
        [Column("DATA_OCORRENCIA")]
        public DateTime Data_Ocorrencia { get; set; }
        [Required]
        [StringLength(100)]
        public string SUPERMERCADO { get; set; }
    }
}
