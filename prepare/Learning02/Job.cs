using System;
public class Job
{
    // create Member Variables
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // Constructor
    // Method to display job details
    public void DisplayJobInfo()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");

    }
}