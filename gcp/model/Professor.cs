//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace gcp.model
{
    public partial class Professor
    {
        public Professor()
        {
            this.Turma = new HashSet<Turma>();
        }
    
        public int id_funcionario { get; set; }
        public int id_turma { get; set; }
    
        public virtual Funcionario Funcionario { get; set; }
        public virtual ICollection<Turma> Turma { get; set; }
    }
    
}