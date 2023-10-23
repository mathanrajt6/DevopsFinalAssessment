using DemeDotNet;

namespace DemoDotNetTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestProduct_ShouldReturnProductOfNumbers()
        {
            Product product = new Product();            
            Assert.AreEqual(2, product.GetProduct(1, 2));
        }
    }
}