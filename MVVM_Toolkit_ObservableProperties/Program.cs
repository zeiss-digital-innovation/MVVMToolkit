
namespace Observable_Properties;

public class Program
{
	public static void Main(string[] args)
	{
		User user = new User();
		Console.WriteLine("Full name: " + user.FullName);

		user.FirstName = "Test_First_Name";
		user.LastName = "Test_Last_Name";

		Console.WriteLine("Full name: " + user.FullName);
	}

	private static void MyPrivateMethod(int param1, string param2)
	{
		// Your code here
	}
}