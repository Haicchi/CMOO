
namespace studenti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = Creator.RandomStudent();
            Console.WriteLine(student1.ToString());
            Student student2 = Creator.RandomStudent();
            Console.WriteLine(student2.ToString());
            Student[] studs = {student1, student2};
            Student[] studs2 = null;
            Factory.GroupCreation(studs);
            Console.WriteLine("Students that passed to the group");
            Factory.Show();
           
        }
    }
}
