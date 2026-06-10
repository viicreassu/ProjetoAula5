using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoMVC.Models
{
    public class Aluno
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O RA é obrigatório.")]
        [StringLength(20)]
        public string RA { get; set; }

        [Required(ErrorMessage = "O curso é obrigatório.")]
        [StringLength(100)]
        public string Curso { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
    }
}
