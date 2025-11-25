using System;

namespace CodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var student = new Student() { StudentName = "Mohamad Ahamad" };
                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Student Mohamad Ahamad added successfully!");
            }

            Console.ReadLine();
        }
    }
}
