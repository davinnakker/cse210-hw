public class Job
{
    public string _company;
    public string _jobTitle;
    public int _yearStart;
    public int _yearEnd;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_yearStart}-{_yearEnd}");
    }
}
    
