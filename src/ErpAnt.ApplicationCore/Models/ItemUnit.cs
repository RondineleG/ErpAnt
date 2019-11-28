using System.ComponentModel.DataAnnotations.Schema;

namespace ErpAnt.ApplicationCore.Models
{

    [ Table ( "Customer" )]
    public class ItemUnit : ModelBase
    {
        public string Name { get; set; }

    }
}