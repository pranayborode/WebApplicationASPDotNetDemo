using System.ComponentModel.DataAnnotations;

namespace WebApplicationASPDotNetDemo.Models
{
	public class Student
	{
		[Required(ErrorMessage ="RollNo is Required...")]
		public int RollNo { get; set; }

		[Required(ErrorMessage = "Name is Required...")]
		[Display(Name="Enter Student Name")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Age is Required...")]
		[Range(minimum:18,maximum:30,ErrorMessage ="Age must be between 18-30...")]
		[Display(Name = "Enter Student Age")]
		public int Age { get; set; }

		[Required(ErrorMessage = "Email is Required...")]
		[DataType(DataType.EmailAddress)]
		[RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Password is Required...")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Required(ErrorMessage = "Confirm Password is Required...")]
		[Compare("Password",ErrorMessage ="Password does not match...")]
		[DataType(DataType.Password)]
		public string ConfirmPassword { get; set; }
	}
}
