namespace ErpAnt.ApplicationCore.Models 
{
    public class Cliente : ModelBase
    {
        public Cliente()
        {
            
        }
        public string Nome { get; set; }

        public string Telefone { get; set; }         

        public string Email { get; set; }

         
    }
}