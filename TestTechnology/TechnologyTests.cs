using Technology;

namespace TestTechnology
{
    [TestClass]
    public class ComputerTests
    {
        Computer computer_test;
        Computer computer_test2;
        [TestInitialize]
        public void CreateComputerObject()
        {
            computer_test = new Computer(2, 3, true);
            computer_test2 = new Computer(2, 3, false);
        }
        [TestMethod]
        public void ComputerConstructor_WithParameters_SetsNewComputerObject()
        {
            Assert.AreEqual(2, computer_test.Ram);
            Assert.AreEqual(3, computer_test.Storage);
            Assert.IsTrue(computer_test.FullyCharged);
        }

        [TestMethod]
        public void IncreaseRam_AddsNewRamToOldRam_ReturnsMoreRam()
        {
            //computer_test.IncreaseRam(3);

            Assert.AreEqual(2, computer_test.Ram);

            computer_test.IncreaseRam(3);

            Assert.AreEqual(5, computer_test.Ram);
        }

        [TestMethod]
        public void IncreaseStorage_WithNewStorage_AddsToExistingStorage()
        {
            computer_test.IncreaseStorage(3);
            Assert.AreEqual(6, computer_test.Storage);
        }

        [TestMethod]
        public void IncreaseToFullyCharged_ReturnsTrue()
        {
            Assert.IsFalse(computer_test2.FullyCharged);
            computer_test2.IncreaseToFullyCharged();
            Assert.IsTrue(computer_test2.FullyCharged);
        }
    }
    [TestClass]
    public class LaptopTests
    {
        Laptop laptop1;
        Laptop laptop2;
        [TestInitialize]
        public void CreateLaptopObject()
        {
            laptop1 = new Laptop(3, 4, true, 8);
            laptop2 = new Laptop(3, 4, true, 3);
        }
        [TestMethod]
        public void Laptop_Constructor_SetsValues()
        {
            Assert.AreEqual(3, laptop1.Ram);
            Assert.AreEqual(4, laptop1.Storage);
            Assert.IsTrue(laptop1.FullyCharged);
            Assert.AreEqual(8, laptop1.Weight);
            Assert.AreEqual(2, laptop2.Id);
            Assert.AreEqual(1, laptop1.Id);
        }
        [TestMethod]
        public void IsHeavy_WithWeight_ReturnsBoolean()
        {
            Assert.IsTrue(laptop1.IsHeavy());
            Assert.IsFalse(laptop2.IsHeavy());
        }

    }
    [TestClass]
    public class SmartPhonetests
    {

    }
    [TestClass]
    public class AbstractEntityTest
    {
        private Computer computer1;
        private Computer computer2;
        private Laptop laptop;

        [TestInitialize]
        public void CreateComputerObject()
        {
            computer1 = new Computer(4, 5, false);
            computer2 = new Computer(4, 5, true);
            laptop = new Laptop(4, 5, false, 5);
        }

        [TestMethod]
        public void SubClasses_Inherit_BaseClassID()
        {
            Assert.AreEqual(1, computer1.Id);
            Assert.AreEqual(2, computer2.Id);
            Assert.AreEqual(3, laptop.Id);
        }
    }
}