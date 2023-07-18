using NUnit.Framework;

namespace M3S03_UnitTest_First
{
    public class Tests
    {
        int chamadasSetup;
        int chamadasContrutor;
        public Tests()
        {
            chamadasContrutor++;
        }

        [SetUp]
        public void Setup()
        {
            chamadasSetup++;
        }

        [TearDown]
        public void TearDown()
        {
            chamadasSetup++;
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(chamadasSetup, 1);
        }
        [Test]
        public void Test2()
        {
            Assert.Pass();
        }
    }
}