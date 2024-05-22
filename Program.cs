// See https://aka.ms/new-console-template for more information
using ConsoleApp_KlocworkTest;

Console.WriteLine("Hello, World!");

if (null == Service.TestInstance)
{
    return;
}
List<string> testList = null;
Console.WriteLine($"testListLength: {testList.Count}");
Object myObj = null;
string s = (myObj ?? String.Empty).ToString();
Console.WriteLine("Time"+ Service.TestInstance.ToString());