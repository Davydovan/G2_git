
namespace University
{
    class Student : BaseClass
    {
        public string course;

        public Student(string firstName, string lastName, string specialization) : base(firstName, lastName, specialization)
        {
        }

        public Student(string firstName, string lastName, string specialization, string course) : base(firstName, lastName, specialization)
        {
            this.course = course;
        }

    }
}
