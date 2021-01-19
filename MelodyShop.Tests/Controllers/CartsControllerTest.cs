using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MelodyShop.Controllers;

namespace MelodyShop.Tests.Controllers
{
  [TestClass]
  public class CartsControllerTest
  {
    [TestMethod]
    public void Index()
    {
      // Arrange
      var cart = new CartsController();

      // Act
      ViewResult result = cart.Index() as ViewResult;

      // Assert
      Assert.IsNotNull(result);
    }

    [TestMethod]
    public void Create()
    {
      // Arrange
      var cart = new CartsController();

      // Act
      ViewResult result = cart.Create() as ViewResult;

      // Assert
      Assert.IsNotNull(result);
    }

    [TestMethod]
    public void Delete()
    {
      // Arrange
      var cart = new CartsController();

      // Act
      ViewResult result = cart.Delete(1) as ViewResult;

      // Assert
      Assert.IsNotNull(result);
    }

    [TestMethod]
    public void DeleteConfirmed()
    {
      // Arrange
      var cart = new CartsController();

      // Act
      ViewResult result = cart.DeleteConfirmed(1) as ViewResult;

      // Assert
      Assert.IsNotNull(result);
    }

    [TestMethod]
    public void Details()
    {
      // Arrange
      var cart = new CartsController();

      // Act
      ViewResult result = cart.Details(1) as ViewResult;

      // Assert
      Assert.IsNotNull(result);
    }

    [TestMethod]
    public void Edit()
    {
      // Arrange
      var cart = new CartsController();

      // Act
      ViewResult result = cart.Edit(1) as ViewResult;

      // Assert
      Assert.IsNotNull(result);
    }
  }
}
