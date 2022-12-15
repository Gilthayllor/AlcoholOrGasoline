namespace AlcoholOrGasoline.Tests
{
    [TestClass]
    public class AlcoholOrGasolineExtensionsTests
    {
        [TestMethod]
        public void ShouldReturnsGasoline()
        {
            var alcOrGas = AlcoholOrGasolineExtensions.Calculate(2.90M, 4.0M);
            
            Assert.AreEqual(AlcoholOrGasolineExtensions.AlcoholOrGasolineEnum.Gasoline,alcOrGas);
        }

        [TestMethod]
        public void ShouldReturnsAlcohol()
        {
            var alcOrGas = AlcoholOrGasolineExtensions.Calculate(2.79M, 4.0M);
            
            Assert.AreEqual(AlcoholOrGasolineExtensions.AlcoholOrGasolineEnum.Alcohol, alcOrGas);
        }
    }
}