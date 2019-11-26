namespace ErpAnt.ApplicationCore.Models
{
    public class Order
    {
        public Guid CustomerId { get; set; }
        // EF Relacionamento
        public Cliente Cliente { get; set; }

        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataCriacao { get; set; }

       
    }
}