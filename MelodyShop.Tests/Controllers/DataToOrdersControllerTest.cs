using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MelodyShop.Controllers;

namespace MelodyShop.Tests.Controllers
{
  [TestClass]
  public class DataToOrdersControllerTest
  {
    [TestMethod]
    public void Index()
    {
      // Arrange
      var dataToOrdersController = new DataToOrdersController();

      // Act
      ViewResult result = dataToOrdersController.Index() as ViewResult;

      // Assert
      Assert.IsNotNull(result);
    }

    [TestMethod]
    public void Create()
    {
      // Arrange
      var dataToOrdersController = new DataToOrdersController();

      // Act
      ViewResult result = dataToOrdersController.Create() as ViewResult;

      // Assert
      Assert.IsNotNull(result);
    }

    [TestMethod]
    public void Delete()
    {
      // Arrange
      var dataToOrdersController = new DataToOrdersController();

      // Act
      ViewResult result = dataToOrdersController.Delete(1) as ViewResult;

      // Assert
      Assert.IsNotNull(result);
    }

    [TestMethod]
    public void DeleteConfirmed()
    {
      // Arrange
      var dataToOrdersController = new DataToOrdersController();

      // Act
      ViewResult result = dataToOrdersController.DeleteConfirmed(1) as ViewResult;

      // Assert
      Assert.IsNotNull(result);
    }

    [TestMethod]
    public void Details()
    {
      // Arrange
      var dataToOrdersController = new DataToOrdersController();

      // Act
      ViewResult result = dataToOrdersController.Details(1) as ViewResult;

      // Assert
      Assert.IsNotNull(result);
    }

    [TestMethod]
    public void Edit()
    {
      // Arrange
      var dataToOrdersController = new DataToOrdersController();

      // Act
      ViewResult result = dataToOrdersController.Edit(1) as ViewResult;

      // Assert
      Assert.IsNotNull(result);
    }
  }
}
