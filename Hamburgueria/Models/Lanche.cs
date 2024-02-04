using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hamburgueria.Models
{
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "É nescessario adicionar um nome")]
        [Display(Name = "Nome do Lanche")]
        [MinLength(5, ErrorMessage = "O lanche deve ter no minimo {1} caracteres")]
        [MaxLength(50, ErrorMessage = "A lanche deve ter no maximo {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É nescessario adicionar uma breve descrição sobre o Lanche")]
        [Display(Name = "Descrição Curta")]
        [MinLength(5, ErrorMessage = "A descrição deve ter mais que {1} caracteres")]
        [MaxLength(20, ErrorMessage = "A descrição deve ter menos que {1} caracteres")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "É nescessario adicionar uma breve descrição sobre o Lanche")]
        [Display(Name = "Descrição Detalhada")]
        [MinLength(30, ErrorMessage = "A descrição deve ter mais que {1} caracteres")]
        [MaxLength(200, ErrorMessage = "A descrição deve ter menos que {1} caracteres")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "É nescessario informar o preço do lanche")]
        [Display(Name = "Preço do lanche")]
        [Column(TypeName="decimal(10,2")]
        [Range(1,999.99, ErrorMessage ="O preço deve estar entre 1 e 999,99 reais")]
        public decimal Preco { get; set; }

        [Display(Name ="Caminho imagem normal")]
        [StringLength(200, ErrorMessage ="O {0} deve ter no máximo {1} caracteres")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho imagem miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name ="Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name ="Estoque")]
        public bool EmEstoque {  get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }

    }
}
