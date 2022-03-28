using NUnit.Framework;
using TestLibrary;

namespace TestsToLibrary
{
    public class Tests
    {
        class Help { }

        [Test]
        public void TestFalse()
        {
            Assert.IsFalse(1 == 2);
        }

        [Test]
        public void TestSum()
        {
            Help a = new Help();
            Help b = new Help();

            Assert.AreEqual(Mathematics.Add<int>(15, 23), 38);
            Assert.AreEqual(Mathematics.Add<float>(15.5f, 23f), 38.5f);
            Assert.AreEqual(Mathematics.Add<char>('d', 'b'), '\u0000');
            Assert.Null(Mathematics.Add<Help>(a, b));
        }

        [Test]
        public void TestSub()
        {
            Help a = new Help();
            Help b = new Help();

            Assert.AreEqual(Mathematics.Subtract<int>(15, 23), -8);
            Assert.AreEqual(Mathematics.Subtract<float>(15.5f, 23f), -7.5f);
            Assert.AreEqual(Mathematics.Subtract<char>('d', 'b'), '\u0000');
            Assert.Null(Mathematics.Subtract<Help>(a, b));
        }

        [Test]
        public void TestMul()
        {
            Help a = new Help();
            Help b = new Help();

            Assert.AreEqual(Mathematics.Multiply<int>(5, 2), 10);
            Assert.AreEqual(Mathematics.Multiply<float>(5.5f, 2f), 11f);
            Assert.AreEqual(Mathematics.Multiply<char>('d', 'b'), '\u0000');
            Assert.Null(Mathematics.Multiply<Help>(a, b));
        }

        [Test]
        public void TestDiv()
        {
            Help a = new Help();
            Help b = new Help();

            Assert.AreEqual(Mathematics.Divide<int>(5, 2), 2);
            Assert.AreEqual(Mathematics.Divide<float>(5.5f, 2f), 2.75f);
            Assert.AreEqual(Mathematics.Divide<double>(12.6, 0), double.PositiveInfinity);
            Assert.AreEqual(Mathematics.Divide<double>(-42.324, 0), double.NegativeInfinity);
            Assert.AreEqual(Mathematics.Divide<char>('d', 'b'), '\u0000');
            Assert.Null(Mathematics.Divide<Help>(a, b));
        }
    }
}