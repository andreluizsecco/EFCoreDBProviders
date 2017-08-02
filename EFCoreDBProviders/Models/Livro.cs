using System.ComponentModel.DataAnnotations;

namespace EFCoreDBProviders.Models
{
    public class Livro
    {
        [Required(ErrorMessage = "O Código é obrigatório!")]
        public int ID { get; set; }
        [Required(ErrorMessage = "O Título é obrigatório!")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O Autor é obrigatório!")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "O Ano é obrigatório!")]
        [RegularExpression(@"[0-9]{4}", ErrorMessage = "O Ano deve possuir 4 números!")]
        public int AnoPublicacao { get; set; }
    }
}