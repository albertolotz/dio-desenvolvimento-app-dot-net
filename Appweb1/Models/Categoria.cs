using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Appweb1.Models

{
  public class Categoria
  {
    public int Id { get; set; }
    [Display(Name = "Descrição")]
    [Required(ErrorMessage = "Descrição é Obrigatória")]
    public string Descricao { get; set; }


    //public List<Produto> produtos { get; set; }
    //linha removida por causa da API 

  }
}