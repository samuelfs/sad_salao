//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SadCabelereiro.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Atendimento
    {
        public Atendimento()
        {
            this.Item_atendimento = new HashSet<Item_atendimento>();
        }
    
        public int pk_id_atendimento { get; set; }
        public Nullable<decimal> valor { get; set; }
        public Nullable<System.DateTime> data_created { get; set; }
        public Nullable<System.DateTime> data { get; set; }
        public Nullable<System.TimeSpan> hora { get; set; }
        public Nullable<int> fk_id_cliente { get; set; }
        public Nullable<int> fk_id_funcionario { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public virtual ICollection<Item_atendimento> Item_atendimento { get; set; }
    }
}
