
namespace Constructors
{
    class BaseClass
    {
        public static int staticInt = 7;
        public int instanceInt = 21;

        protected int testInt;
        private string testString;

        public BaseClass(int testInt, string testString)
        {
            this.testInt = testInt;
            this.testString = testString;
        }
    }
}
