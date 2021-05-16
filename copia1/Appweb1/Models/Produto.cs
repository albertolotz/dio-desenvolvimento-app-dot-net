using System;
using System.ComponentModel.DataAnnotations;

namespace Appweb1.Models
{
  public class Produto
  {
    public int Id { get; set; }
    [Display(Name = "Descrição")]
    [Required(ErrorMessage = "Descrição é Obrigatória")]
    public string descricao { get; set; }

    [Display(Name = "Quantidade")]
    [Required(ErrorMessage = "Quantidade é Obrigatória")]
    public int quantidade { get; set; }

    [Display(Name = "Categoria")]
    [Required(ErrorMessage = "Categoria é Obrigatória")]
    public int CategoriaId { get; set; }
    public Categoria Categoria { get; set; }

  }
}