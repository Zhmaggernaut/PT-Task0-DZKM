using System;

class Program
{
    static void Main(string[] args)
    {
        var logicLayer = new BusinessLogic();
        
        string result = logicLayer.ProcessData("Sample input");
        
        Console.WriteLine(result);
    }
}

public class BusinessLogic
{
    private readonly DataAccess _dataAccess;
    
    public BusinessLogic()
    {
        _dataAccess = new DataAccess();
    }
    
    public string ProcessData(string input)
    {
        string data = _dataAccess.GetData();
        
        return $"Processed: {input} with {data}";
    }
}

public class DataAccess
{
    public string GetData()
    {
        //in a real application, this might get data from a database
        return "sample data";
    }
}
