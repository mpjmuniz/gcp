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
    public partial class Funcionario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string sexo { get; set; }
        public Nullable<System.DateTime> data_ingresso { get; set; }
        public Nullable<System.DateTime> data_nascimento { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string titulo { get; set; }
        public string carteira_de_trabalho { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public Nullable<int> instrucao { get; set; }
    
        public virtual Instrucao Instrucao1 { get; set; }
        public virtual Sexo Sexo1 { get; set; }
        public virtual Professor Professor { get; set; }
        public virtual Turma Turma { get; set; }
    }
    
}
