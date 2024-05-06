using System.ComponentModel.DataAnnotations.Schema;

namespace Task1.Models
{
	public class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }

		[Column("Title")]
        public string title { get; set; }

        public int Age { get; set; }
    }
}
