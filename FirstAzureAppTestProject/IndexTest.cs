using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstAzureWebApp.Pages;

namespace TestProjectMSSEDevops
{
    [TestClass]
    public class IndexTest
    {
        private readonly IndexModel _indexModel;

        public IndexTest()
        {
            _indexModel = new IndexModel(null);
            Authenticate();
        }

        [TestMethod]
        public void Authenticate()
        {
            // Assert.Fail();
            string user = "test";
            string password = "passcode";
            var result = _indexModel.Authenticate(user, password);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Add()
        {
            int a = 4;
            int b = 5;
            var result = _indexModel.Add(a, b);
            Assert.AreEqual(9, result);
        }
    }
}