using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class BaseTest
    {
        [OneTimeSetUp]
        public void BeforeAllTest()
        {
            Console.WriteLine("BeforeAllTest");
        }

        [OneTimeTearDown]
        public void AfterAllTest()
        {
            Console.WriteLine("AfterAllTest");
        }

        [SetUp]
        public void BeforeEveryTest()
        {
            Console.WriteLine("BeforeEveryTest");
        }

        [TearDown]
        public void AfterEveryTest()
        {
            Console.WriteLine("AfterEveryTest");
        }
    }
}
