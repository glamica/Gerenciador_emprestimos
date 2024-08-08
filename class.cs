// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
public class MySqlInterface {
    private object MySQL
    public MySqlInterface(
        string host = "localhost",
        int port = 3306,
        string usuario = "root",
        string senha = "")
    {
        Console.WriteLine($"MySQL.Socket(host <- '{host}'; port <- {port}; user <- '{user}'; password <- '{senha}')")
        MySQL = new object(){Host=host,Port=port,User=usuario,Password=senha}
    }
}
public class Work
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Try programiz.pro");
    }
}