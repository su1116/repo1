using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Yidosoft.Edu.Csharp.UnitTest.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "你好，小花。";
            using (var sw=new StringWriter())
            {
                Console.SetOut(sw);
                UnitTest.Program.Main();
                var result = sw.ToString().Trim();
                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            string name = "小强";//测试数据
            string expected = $"我的名字叫{name}";//预期结果
            UnitTest.Program program = new Program();
            var result = program.GetData(name);//真实结果
            Assert.AreEqual(expected, result);//比较是否相等
        }

        [TestMethod]
        public void TestMethod3()
        {
            string str = "hello";//测试数据
            int expected = 5;//预期结果
            UnitTest.Program program = new Program();
            var result = program.GetLength(str);//真实结果
            Assert.AreEqual(expected, result);//比较是否相等
        }

        [TestMethod]
        public void TestMethod4()
        {
            string str = "";//测试数据
            string expected = "";//预期结果
            UnitTest.Program program = new Program();
            var result = str.Trim();//真实结果
            Assert.AreEqual(expected, result);//比较是否相等
        }

        [TestMethod()]
        public void MP_OrderTest()
        {
            int [] arr= new int[10] { 32, 12, 50, 7, 9, 25, 42, 100, -9, -20 };
            int [] expected = new int[10] { -20, -9, 7, 9, 12, 25, 32, 42, 50, 100 };
            UnitTest.Program program = new Program();
            int[] result = program.MP_Order(arr);
            //Assert.AreEqual(expected, result);
            Assert.IsTrue(Enumerable.SequenceEqual(expected, result));
        }
        [TestMethod()]
        public void GetSumTest()
        {
            int num = 6;
            int expected = -3;
            Program program = new Program();
            int result = program.GetSum(num);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void GetPercentTest()
        {
            double a = 752;
            double all = 754;
            string expected = "99.7%";
            Program program = new Program();
            string result = program.GetPercent(a, all);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void IntToDoubleTest()
        {
            int a = 752;
            double expected = 752;
            Program program = new Program();
            double result = program.IntToDouble(a);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void GetWeekTest()
        {
            int i = 0;
            DayOfWeek expected = DayOfWeek.Sunday;
            Program program = new Program();
            DayOfWeek result = program.GetWeek(i);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void GetCardCountTest()
        {
            int expected = 2;
            Program program = new Program();
            int result = program.GetCardCount(Convert.ToDateTime("2021-08-13"), Convert.ToDateTime("2021-08-14"),"5，6",true) ;
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void GetUnionListTest()
        {
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            List<string> expList = new List<string>();
            Program program = new Program();
            List<string> result = program.GetUnionList(list1,list2);
            Assert.AreEqual(expList.Count, result.Count);
        }
    }
}
