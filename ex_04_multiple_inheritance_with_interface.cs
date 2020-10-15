using System; 
interface stud { 
	void PersonalDetails(); 
	void DispDetails();
	} 
class Personal : stud { 
	String name,gender;
	int age;
	public void PersonalDetails() 
	{ 
		Console.WriteLine("Enter Your Name :");
		name=Console.ReadLine();
		Console.WriteLine("Enter Your Age :");
		age=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Your Gender :");
		gender=Console.ReadLine();
	}
	public void DispDetails()
	{
		Console.WriteLine("Student Personal Information ..."); 
		Console.WriteLine("Student's Name :"+name);
		Console.WriteLine("Student's Age :"+age);
		Console.WriteLine("Student's Gender :"+gender);
	} 
} 
interface stud1 { 
	void ProfessionalDetails(); 
	void DispDetails1();
} 
class Educational : stud1 { 
	string dept_name;
	int year,c_sharp,python,datamining,cloud,optional,tot,avg;
	public void ProfessionalDetails() 
	{ 
		Console.WriteLine("Enter Your Department Name :");
		dept_name=Console.ReadLine();
		Console.WriteLine("Enter Your Year of Studying :");
		year=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Your Mark in C# :");
		c_sharp=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Your Mark in Python :");
		python=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Your Mark in Data Mining :");
		datamining=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Your Mark in Cloud Computing :");
		cloud=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Your Mark in Optional-Web Services :");
		optional=Convert.ToInt32(Console.ReadLine());
		tot=c_sharp+python+datamining+cloud+optional;
		avg=tot/5;
	}
	public void DispDetails1()
	{
		Console.WriteLine("");
		Console.WriteLine("Student Professional Information ...");
		Console.WriteLine("Student's Department Name :"+dept_name);
		Console.WriteLine("Student's Year of Studying :"+year);
		Console.WriteLine("Student's Mark in C# Programming :"+c_sharp);
		Console.WriteLine("Student's Mark in Python Programming :"+python);
		Console.WriteLine("Student's Mark in Data Mining :"+datamining);
		Console.WriteLine("Student's Mark in Cloud Computing :"+cloud);
		Console.WriteLine("Student's Mark in Optional-Web Services :"+optional);
		Console.WriteLine("Student's Total Mark :"+tot);
		Console.WriteLine("Student's Average Mark :"+avg);
	} 
} 
class empDetails : stud,stud1 { 
	Personal obj1 = new Personal(); 
	Educational obj2 = new Educational(); 
	public void PersonalDetails() 
	{ 
		obj1.PersonalDetails(); 
	} 
	public void DispDetails() 
	{ 
		obj1.DispDetails(); 
	} 
	public void ProfessionalDetails() 
	{ 
		obj2.ProfessionalDetails(); 
	} 
	public void DispDetails1() 
	{ 
		obj2.DispDetails1(); 
	} 
} 
public class EmployeeMain { 
	static public void Main() 
	{ 
		Console.WriteLine("Student Information Using Multiple Inheritance ..."); 
		empDetails obj = new empDetails(); 
		obj.PersonalDetails(); 
		obj.ProfessionalDetails(); 
		obj.DispDetails();
		obj.DispDetails1(); 

	} 
} 
