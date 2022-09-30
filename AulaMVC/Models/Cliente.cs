using System.ComponentModel.DataAnnotations;

namespace AulaMVC.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage="O nome é obrigatório")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "A nota é obrigatório")]
        [Range(0,10,ErrorMessage ="A nota deve estar entre 0 e 10")]
        public int Nota { get; set; }

        [Required(ErrorMessage = "O Comentario é obrigatório")]
        public string? Comentario { get; set; }

        [EmailAddress(ErrorMessage ="O email inserido é inválido")]
        public string? Email { get; set; }
    }
}
