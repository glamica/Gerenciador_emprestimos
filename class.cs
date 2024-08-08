// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
public class MySqlInterface {
    private object MySQL;
    public MySqlInterface(
        string host = "localhost",
        int port = 3306,
        string usuario = "root",
        string senha = "")
    {
        Console.WriteLine($"MySQL.Socket(host <- '{host}'; port <- {port}; user <- '{usuario}'; password <- '{senha}')");
        MySQL = new {Host=host,Port=port,User=usuario,Password=senha};
    }
    public List<List<string>> Query(string query) {
        Console.WriteLine($"query executada: {query}");
        List<List<string>> resultSet = new List<List<string>>();
        List<string> e = new List<string>();
        for (int c = 0;c <= 90; c++) {
            for (int r = 0; r <= 12; r++) e.Add($"string({c}) -> {r}");
            resultSet.Add(e);
            resultSet.Clear();
        }
        return e;
    }
}
public class Work
{
    public static void Main(string[] args)
    {
        MySqlInterface e = new MySqlInterface();
    }
}