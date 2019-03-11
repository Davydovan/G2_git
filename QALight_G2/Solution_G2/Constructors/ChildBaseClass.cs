
namespace Constructors
{
    class ChildBaseClass : BaseClass
    {
        private char myChar;

        public ChildBaseClass(int a, string b, char c) : base(a, b)
        {
            myChar = c;
            
        }
    }
}
