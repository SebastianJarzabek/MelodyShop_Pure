using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MelodyShop.Controllers;

namespace MelodyShop.Tests.Controllers
{
  [TestClass]
  public class ProductControllerTest
  {
    [TestMethod]
    public void Create()
    {
      // Arrange
      var ProductController = new ProductController();

      // Act
      ViewResult result = ProductController.Create() as ViewResult;

      // Assert
      Assert.IsNotNull(result);
    } 

    [TestMethod]
    public void Index()
    {
      // Arrange
      var ProductController = new ProductController();

      // Act
      ViewResult result = ProductController.Index() as ViewResult;

      // Assert
      Assert.IsNull(result);
    }



    [TestMethod]
    public void Delete()
    {
      // Arrange
      var ProductController = new ProductController();

      // Act
      ViewResult result = ProductController.Delete(1) as ViewResult;

      // Assert
      Assert.IsNotNull(result);
    }

    [TestMethod]
    public void DeleteConfirmed()
    {
      // Arrange
      var ProductController = new ProductController();

      // Act
      ViewResult result = ProductController.DeleteConfirmed(1) as ViewResult;

      // Assert
      Assert.IsNotNull(result);
    }

    [TestMethod]
    public void Details()
    {
      // Arrange
      var ProductController = new ProductController();

      // Act
      ViewResult result = ProductController.Details(1) as ViewResult;

      // Assert
      Assert.IsNotNull(result);
    }

    [TestMethod]
    public void Edit()
    {
      // Arrange
      var ProductController = new ProductController();

      // Act
      ViewResult result = ProductController.Edit(1) as ViewResult;

      // Assert
      Assert.IsNotNull(result);
    }
  }
}
