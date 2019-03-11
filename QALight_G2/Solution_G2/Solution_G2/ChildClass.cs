using System;

namespace Solution_G2
{
    class ChildClass : ParrentClass
    {
        public int childInt = 67;

        public override void TestMethod()
        {
            Console.WriteLine("Child class");
        }
    }
}
