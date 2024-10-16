// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    static string username = "";
    static string password = "";
    static void Sign_up()
    {
        Console.WriteLine("========Sign Up========");
        Console.Write("Enter your username: ");
        username = Console.ReadLine();
        Console.Write("Enter password for "+username+" account: ");
        password = Console.ReadLine();
        Console.Write("Enter your password again :");
        string sec_password = Console.ReadLine();
        while (password != sec_password)
            {
                Console.Write("Your Password was WRONG.Try again: ");
                sec_password = Console.ReadLine();
            }
        Console.Write("Your account has been created seccussfully.");
        Console.Write("Press Enter to exit.");
        Console.ReadLine();
        Login();
        
    }
    static void Login()
    {
        Console.WriteLine("========Sign in========");
        Console.Write("Enter your username: ");
        string login_user = Console.ReadLine();
        while (login_user != username) 
            {
                Console.Write("The user ("+login_user+") dose NOT exist. Try again: ");
                login_user = Console.ReadLine();
            }
        Console.Write("Enter your password: ");
        string login_pass = Console.ReadLine();
        while (login_pass != password) 
            {
                Console.Write("Your password was WRONG . Try again: ");
                login_pass = Console.ReadLine();
            }
        Console.Write("You have logged in seccuessfully.\nUsername : "+username+"\nPassword : "+password);
        Console.ReadLine();
    }
    public static void Main(string[] args)
    {
        bool loged_in = false;
        Sign_up();
    }
        
    
}
