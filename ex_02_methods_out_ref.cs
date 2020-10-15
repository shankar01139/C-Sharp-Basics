using System;
class MethodParams {
    static int age;
    public static void mul(int a,out int b){
        b = 50;
    }
    public static void sendGreet(ref int age) {
        if(age>=18) {
            Console.WriteLine("Hi There! You are Eligible to Vote ....!");
       } 
    }
    public static string getFullName(string firstName = "firstName",string lastName = "lastName")
    {
        return "Your Fullname is "+firstName+" "+lastName + ".";
    }
    public static void Main() {
        int a =30;
        int b;
        mul(a,out b);
        Console.WriteLine("Multiplication of a and b is: {0}",a*b);
        int age=Convert.ToInt32(Console.ReadLine());
        sendGreet(ref age);
        Console.WriteLine(getFullName("Shankar", "Krishna"));
        }
}
