using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{

    public class Student
    {
        
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Programe { get; set; }
        public DateTime Date { get; set; }
    }


    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
