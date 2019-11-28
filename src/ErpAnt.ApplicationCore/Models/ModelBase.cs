using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ErpAnt.ApplicationCore.Models
{
    [ Table ( "ModelBase" )]
    public abstract class ModelBase
    {
        protected ModelBase()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}