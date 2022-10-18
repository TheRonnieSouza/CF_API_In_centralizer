namespace CF_API_In_centralizer.Models
{
    public class Produto
    {
        public int ProdutoId {get; set;} 

        public string? NameProduct {get; set;}
        public double Price { get; set;}

        public DateTime RegistrationDate { get; set;}

        public string Supermarket { get; set; }       
    }
}
