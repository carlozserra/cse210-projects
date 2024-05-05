using System;

public class Job
{
    public string _jobCompany;
    public string _jobTitle;
    public int _jobStartYear;
    public int _jobEndYear;

    
public void Display()
    {
        Console.WriteLine($" ({_jobCompany}) {_jobTitle} {_jobStartYear}-{_jobEndYear}");
    }
}