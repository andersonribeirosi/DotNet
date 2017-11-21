using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDotNetUnidade2.MVC.DDD.ViewModels
{
    public class ClienteViewModel
    {

        [Key]
        public int ClienteID { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um email válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }


        [ScaffoldColumn(false)] // O campo DataCadastro não será criado
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }
        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}