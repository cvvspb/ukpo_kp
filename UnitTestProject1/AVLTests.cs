using Microsoft.VisualStudio.TestTools.UnitTesting;
using KP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP.UnitTestProject1
{
    [TestClass()]
    public class AVLTests
    {
        [TestMethod()]
        public void Test1()
        {
            AVL avl = new AVL();
            Assert.AreEqual(String.Empty, avl.PrintTree());
        }

        [TestMethod()]
        public void Test2()
        {
            AVL avl = new AVL();
            avl.Add(5);
            Assert.AreEqual("(5)", avl.PrintTree());
        }

        [TestMethod()]
        public void Test3()
        {
            // Малое правое вращение
            AVL avl = new AVL();
            avl.Add(5);
            avl.Add(3);
            avl.Add(4);
            Assert.AreEqual("(3)(4)(5)", avl.PrintTree());
        }

        [TestMethod()]
        public void Test4()
        {
            // Малое левое вращение
            AVL avl = new AVL();
            avl.Add(3);
            avl.Add(5);
            avl.Add(4);
            Assert.AreEqual("(3)(4)(5)", avl.PrintTree());
        }

        [TestMethod()]
        public void Test5()
        {
            // Большое левое вращение
            AVL avl = new AVL();
            avl.Add(1);
            avl.Add(2);
            avl.Add(5);
            avl.Add(4);
            avl.Add(6);
            avl.Add(3);
            Assert.AreEqual("(1)(2)(3)(4)(5)(6)", avl.PrintTree());
        }

        [TestMethod()]
        public void Test6()
        {
            // Большое правое вращение
            AVL avl = new AVL();
            avl.Add(5);
            avl.Add(6);
            avl.Add(3);
            avl.Add(4);
            avl.Add(2);
            avl.Add(1);
            Assert.AreEqual("(1)(2)(3)(4)(5)(6)", avl.PrintTree());
        }

        [TestMethod()]
        public void Test7()
        {
            AVL avl = new AVL();
            avl.Add(1);
            avl.Add(2);
            avl.Add(3);
            avl.Delete(2);
            Assert.AreEqual("(1)(3)", avl.PrintTree());
        }

        [TestMethod()]
        public void Test8()
        {
            AVL avl = new AVL();
            avl.Add(1);
            avl.Add(2);
            avl.Add(3);
            avl.Delete(1);
            Assert.AreEqual("(2)(3)", avl.PrintTree());
        }

        [TestMethod()]
        public void Test9()
        {
            AVL avl = new AVL();
            avl.Add(1);
            avl.Add(2);
            avl.Add(3);
            avl.Delete(3);
            Assert.AreEqual("(1)(2)", avl.PrintTree());
        }

        [TestMethod()]
        public void Test10()
        {
            AVL avl = new AVL();
            avl.Delete(1);
            Assert.AreEqual(String.Empty, avl.PrintTree());
        }

        [TestMethod()]
        public void Test11()
        {
            AVL avl = new AVL();
            avl.Add(1);
            avl.Add(2);
            avl.Add(3);
            Assert.AreEqual("(2)", avl.Find(2));
        }
        [TestMethod()]
        public void Test12()
        {
            AVL avl = new AVL();
            avl.Add(1);
            avl.Add(2);
            avl.Add(3);
            Assert.AreEqual("(1)", avl.Find(1));
        }
        [TestMethod()]
        public void Test13()
        {
            AVL avl = new AVL();
            avl.Add(1);
            avl.Add(2);
            avl.Add(3);
            Assert.AreEqual("(3)", avl.Find(3));
        }
        [TestMethod()]
        public void Test14()
        {
            AVL avl = new AVL();
            avl.Add(1);
            avl.Add(2);
            avl.Add(3);
            Assert.AreEqual(String.Empty, avl.Find(10));
        }

        /// <summary>
        /// Дополнительные тесты
        /// </summary>

        [TestMethod()]
        public void Test15()
        {
            AVL avl = new AVL();
            avl.Add(4);
            avl.Add(2);
            avl.Add(5);
            avl.Add(1);
            avl.Add(3);
            avl.Delete(5);
            Assert.AreEqual("(1)(2)(3)(4)", avl.PrintTree());
        }

        [TestMethod()]
        public void Test16()
        {
            AVL avl = new AVL();
            avl.Add(1);
            avl.Add(2);
            avl.Add(4);
            avl.Add(3);
            avl.Add(5);
            avl.Delete(1);
            Assert.AreEqual("(2)(3)(4)(5)", avl.PrintTree());
        }

        [TestMethod()]
        public void Test17()
        {
            AVL avl = new AVL();
            avl.Add(1);
            avl.Add(2);
            avl.Add(4);
            avl.Add(3);
            avl.Delete(1);
            Assert.AreEqual("(2)(3)(4)", avl.PrintTree());
        }

        [TestMethod()]
        public void Test18()
        {
            AVL avl = new AVL();
            avl.Add(3);
            avl.Add(1);
            avl.Add(4);
            avl.Add(2);
            avl.Delete(4);
            Assert.AreEqual("(1)(2)(3)", avl.PrintTree());
        }

        [TestMethod()]
        public void Test19()
        {
            AVL avl = new AVL();
            avl.Add(1);
            avl.Add(2);
            avl.Add(4);
            avl.Add(3);
            avl.Delete(2);
            Assert.AreEqual("(1)(3)(4)", avl.PrintTree());
        }

        [TestMethod()]
        public void Test20()
        {
            AVL avl = new AVL();
            avl.Add(3);
            avl.Add(2);
            avl.Add(4);
            avl.Add(1);
            avl.Delete(3);
            Assert.AreEqual("(1)(2)(4)", avl.PrintTree());
        }

        [TestMethod()]
        public void Test21()
        {
            AVL avl = new AVL();
            avl.Add(3);
            avl.Add(1);
            avl.Add(4);
            avl.Add(2);
            avl.Delete(3);
            Assert.AreEqual("(1)(2)(4)", avl.PrintTree());
        }

        [TestMethod()]
        public void Test22()
        {
            AVL avl = new AVL();
            avl.Add(1);
            Assert.AreEqual(String.Empty, avl.Find(10));
        }

        [TestMethod()]
        public void Test23()
        {
            AVL avl = new AVL();
            avl.Add(10);
            Assert.AreEqual(String.Empty, avl.Find(1));
        }
    }
}