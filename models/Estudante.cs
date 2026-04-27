using System.ComponentModel.DataAnnotations;

namespace CadastroEstudanteApi.models
{
    public class Estudante
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "O campo Nome do estudante é obrigatório.")]
        public required string Nome { get; set; }
       
    }
}