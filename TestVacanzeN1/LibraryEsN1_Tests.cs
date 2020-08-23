using Microsoft.VisualStudio.TestTools.UnitTesting;
using Es_n1_Vacanze;

namespace TestVacanzeN1
{
    [TestClass]
    public class LibraryEsN1_Tests
    {
        [TestMethod]
        public void TestMassimo()
        {
            int a = 5;
            int b = 2;
            int ris = LibraryEsN1.Massimo(a, b);
            int ris_aspettato = 5;
            Assert.AreEqual(ris_aspettato, ris);
        }
        [TestMethod]
        public void TestMinimo()
        {
            int a = 5;
            int b = 2;
            int ris = LibraryEsN1.Minimo(a, b);
            int ris_aspettato = 2;
            Assert.AreEqual(ris_aspettato, ris);
        }
        [TestMethod]
        public void Testmedia()
        {
            double a = 5;
            double b = 2;
            double ris = LibraryEsN1.Media(a, b);
            double ris_aspettato = 3.5;
            Assert.AreEqual(ris_aspettato, ris);
        }
        [TestMethod]
        public void TestMassimo2()
        {
            int a = 3;
            int b = 4;
            int ris = LibraryEsN1.Massimo(a, b);
            int ris_asp = 4;
            Assert.AreEqual(ris_asp, ris);
        }
        [TestMethod]
        public void TestMinimo2()
        {
            int a = 3;
            int b = 4;
            int ris = LibraryEsN1.Minimo(a, b);
            int ris_asp = 3;
            Assert.AreEqual(ris_asp, ris);
        }
        [TestMethod]
        public void TestMedia2()
        {
            double a = 3;
            double b = 4;
            double ris = LibraryEsN1.Media(a, b);
            double ris_asp = 3.5;
            Assert.AreEqual(ris_asp, ris);
        }
        [TestMethod]
        public void TestMassimo3()
        {
            int a = 7;
            int b = 7;
            int ris = LibraryEsN1.Massimo(a, b);
            int ris_asp = 7;
            Assert.AreEqual(ris_asp, ris);
        }
        [TestMethod]
        public void TestMinimo3()
        {
            int a = 7;
            int b = 7;
            int ris = LibraryEsN1.Minimo(a, b);
            int ris_asp = 7;
            Assert.AreEqual(ris_asp, ris);
        }
        [TestMethod]
        public void TestMedia3()
        {
            double a = 7;
            double b = 7;
            double ris = LibraryEsN1.Media(a, b);
            double ris_asp = 7;
            Assert.AreEqual(ris_asp, ris);
        }
    }
}
