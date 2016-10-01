using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using lab_1;

namespace Test
{
    public class Class1
    {
        [Test]
        public void Sum_3Plus6_9Returned()
        {
            Calc calc = new Calc();
            double res = calc.sum(3, 6);
            Assert.AreEqual(9, res);
        }

        [Test]
        public void Sum_Neg3Plus6_3Returned()
        {
            Calc calc = new Calc();
            double res = calc.sum(-3, 6);
            Assert.AreEqual(3, res);
        }

        [Test]
        public void Sum_Neg3PlusNeg6_Neg9Returned()
        {
            Calc calc = new Calc();
            double res = calc.sum(-3, -6);
            Assert.AreEqual(-9, res);
        }

        [Test]
        public void Sub_3Minus6_Neg3Returned()
        {
            Calc calc = new Calc();
            double res = calc.sub(3, 6);
            Assert.AreEqual(-3, res);
        }

        [Test]
        public void Sub_Neg3Minus6_Neg9Returned()
        {
            Calc calc = new Calc();
            double res = calc.sub(-3, 6);
            Assert.AreEqual(-9, res);
        }

        [Test]
        public void Sub_Neg3MinusNeg6_3Returned()
        {
            Calc calc = new Calc();
            double res = calc.sub(-3, -6);
            Assert.AreEqual(3, res);
        }

        [Test]
        public void Mul_3Multiply6_18Returned()
        {
            Calc calc = new Calc();
            double res = calc.mul(3, 6);
            Assert.AreEqual(18, res);
        }

        [Test]
        public void Mul_Neg3Multiply6_Neg18Returned()
        {
            Calc calc = new Calc();
            double res = calc.mul(-3, 6);
            Assert.AreEqual(-18, res);
        }

        [Test]
        public void Mul_Neg3MultiplyNeg6_18Returned()
        {
            Calc calc = new Calc();
            double res = calc.mul(-3, -6);
            Assert.AreEqual(18, res);
        }

        [Test]
        public void Div_3Divided6_AHulfReturned()
        {
            Calc calc = new Calc();
            double res = calc.div(3, 6);
            Assert.AreEqual(0.5, res);
        }

        [Test]
        public void Div_Neg3Divided6_NegAHulfReturned()
        {
            Calc calc = new Calc();
            double res = calc.div(-3, 6);
            Assert.AreEqual(-0.5, res);
        }

        [Test]
        public void Div_Neg3DividedNeg6_AHulfReturned()
        {
            Calc calc = new Calc();
            double res = calc.div(-3, -6);
            Assert.AreEqual(0.5, res);
        }
    }
}
