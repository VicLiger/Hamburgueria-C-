using System.ComponentModel.DataAnnotations;

namespace Hamburgueria.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId {  get; set; }

        [Required(ErrorMessage ="É nescessario adicionar um nome")]
        [Display(Name ="Nome da categoria")]
        [MinLength(1, ErrorMessage ="A categoria deve ter no minimo {1} caracteres")]
        [MaxLength(50, ErrorMessage ="A categoria deve ter no maximo {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="É nescessario adicionar uma breve descrição sobre a categoria")]
        [Display(Name ="Descrição")]
        [MinLength(20, ErrorMessage ="A descrição deve ter mais que {1} caracteres")]
        [MaxLength(100, ErrorMessage ="A descrição deve ter menos que {1} caracteres")]
        public string Descricao { get; set; }
        public List<Lanche> Lanches { get; set; }
    }
}
