using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
        public int Salary { get; set; }

    }
}