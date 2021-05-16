using System;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Moq;
using Moq.Language.Flow;
using Microsoft.EntityFrameworkCore;
using Appweb1.Models;
using Xunit;
using Apiweb1.Controllers;

namespace Testweb
{
  public class CategoriasControllerTest
  {
    private readonly Mock<DbSet<Categoria>> _mockSet;
    private readonly Mock<Context> _mockContext;
    private readonly Categoria _categoria;

    public CategoriasControllerTest()
    {
      _mockSet = new Mock<DbSet<Categoria>>();
      _mockContext = new Mock<Context>();
      _categoria = new Categoria { Id = 1, Descricao = "Teste de Categoria" };

      _mockContext.Setup(m => m.Categorias).Returns(_mockSet.Object);

      _mockContext.Setup(m => m.Categorias.FindAsync(1)).ReturnsAsync(_categoria);
    }

    [Fact]
    public async Task Get_Categoria()
    {
      var service = new CategoriasController(_mockContext.Object);

      await service.GetCategoria(1);

      _mockSet.Verify(m => m.FindAsync(1), Times.Once());

    }
  }
}