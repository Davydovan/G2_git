
namespace University
{
    abstract class BaseClass
    {
        public string firstName;
        public string lastName;
        public string specialization;


        public BaseClass(string firstName, string lastName, string specialization)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.specialization = specialization;
        }
    }
}
