using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDotNetUnidade2.MVC.DDD.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoID { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Valor { get; set; }

        [DisplayName("Disponível?")]
        public bool Disponivel { get; set; }

        public int ClienteID { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }

    }
}