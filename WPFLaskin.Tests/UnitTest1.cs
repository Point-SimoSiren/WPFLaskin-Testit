namespace WPFLaskin.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Laskenta laskenta = new Laskenta();
            double tulos = laskenta.YhteenLasku(23.34, 10.00);

            Assert.AreEqual(33.34, tulos);

        }

        [TestMethod]
        public void TestMethod2()
        {
            Laskenta laskenta = new Laskenta();
            double tulos = laskenta.YhteenLasku(-100, 100);

            Assert.AreEqual(0, tulos);

        }
    }
}