using System;

interface Employee
{
    int Salary { get; set; }
    int Hours { get; set; }
    int Pay { get; }
}

class Waiter : Employee
{
    private int salary;
    private int hours;
    public int Salary
    {
        get { return salary; }
        set { salary = value; }
    }
    public int Hours
    {
        get { return hours; }
        set { hours = value; }
    }
    public int Pay
    {
        get { return hours * salary; }
    }
    private string[] waiters = new string[100];
    public string this[int i]
    {
        get { return waiters[i]; }
        set { waiters[i] = value; }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Waiter waiter = new Waiter();
        waiter.Salary = 16;
        waiter.Hours = 8;
        waiter[0] = "Beth";
        waiter[1] = "John";
        waiter[2] = "Joe";

        Console.WriteLine(waiter.Salary);
        Console.WriteLine(waiter.Hours);
        Console.WriteLine(waiter.Pay);
        Console.WriteLine(waiter[0]);
        Console.WriteLine(waiter[1]);
        Console.WriteLine(waiter[2]);
    }
}
