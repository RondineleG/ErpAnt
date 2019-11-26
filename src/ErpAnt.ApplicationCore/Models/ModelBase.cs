using System;

namespace ErpAnt.ApplicationCore.Models
{
    public abstract class ModelBase
    {
        protected ModelBase()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}