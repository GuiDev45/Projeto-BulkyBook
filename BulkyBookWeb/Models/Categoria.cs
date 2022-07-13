using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Categoria
    {
        //Anotação chave primária
        [Key]
        public int Id { get; set; }
        //Anotação que obriga a entrada de dados
        [Required]
        public string Nome { get; set; }

        [DisplayName("Ordem Exibição")]
        [Range(1,100,ErrorMessage = "A ordem de exibição deve estar entre 1 e 100 apenas")]
        public int OrdemExibicao { get; set; }
        public DateTime HoraCriada { get; set; } = DateTime.Now;
    }
}
