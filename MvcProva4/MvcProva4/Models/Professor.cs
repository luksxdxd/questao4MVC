using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcProva4.Models
{
    public class Professor
    {
        [Display(Name = "ID:")]
        public int id { get; set; }

        [Display(Name = "Nome:")]
        [Required(ErrorMessage = "Informe o nome")]
        public String Nome { get; set; }

        [Display(Name = "Endereço:")]
        public String Endereco { get; set; }

        [Display(Name = "Telefone:")]
        public int Telefone { get; set; }

        [Display(Name = "E-mail:")]
        [EmailAddress(ErrorMessage = "E-mail Inválido")]
        public String Email { get; set; }

        [Display(Name = "Disciplina:")]
        [Required(ErrorMessage ="Informe as Disciplinas")]
        public String Disciplina { get; set; }
    }
}