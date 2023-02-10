using System;

interface Employee
{
    string name { get; set; };
    int salary { get; set; };
    int hours { get; set; };
}

class Waiter: Employee
{
    public string name;
    public int salary;
    public int hours;
    public string Name
    {
        get { return name; };
        set { name = value; };
    }
    public string Salary
    {
        get { return salary; };
        set { salary = value; };
    }
    public string Hours
    {
        get { return hours; };
        set { hours = value; };
    }

    private string[] waiters = new string[100];
    public string this[int i]
    {
        get { return waiters[i]; }
        set { waiters[i] = value; }
    }

}

namespace MyConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Waiter John = new Waiter();
        }
    }
}