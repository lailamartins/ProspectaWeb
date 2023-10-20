using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProspectaWeb.Models
{

    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nascimento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Empresa { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int Produto { get; set; }

    }
}
