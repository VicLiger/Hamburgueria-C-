using System.ComponentModel.DataAnnotations;

namespace Hamburgueria.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId {  get; set; }

        [Required(ErrorMessage ="É nescessario adicionar um nome")]
        [Display(Name ="Nome da categoria")]
        [MinLength(5, ErrorMessage ="A categoria deve ter no minimo 5 caracteres")]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public List<Lanche> Lanches { get; set; }
    }
}
