namespace _4_EF_IEnumarableIQuaryable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student() {StudentName="Fatih",StudentAge=25},
                new Student() {StudentName="Sefa",StudentAge=15},
                new Student() {StudentName="Naime",StudentAge=35},
                new Student() {StudentName="Furkan",StudentAge=21},
            };

            IEnumerable<Student> students1=students.Where(s=>s.StudentAge>20);
            IQueryable<Student> students2=students.AsQueryable().Where(s=>s.StudentAge>20);
        }
    }
    public class Student
    {
        public string StudentName { get; set; }
        public int StudentAge { get; set; }
    }
}