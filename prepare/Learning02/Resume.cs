using System;

public class Resume
{

    // these two are both member variables
    public string _personName;
    public List<Job> _jobList = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs:");
        // Console.WriteLine(DisplayJobInfo());
            
        foreach (Job job in _jobList)
        {
            job.DisplayJobInfo();
        }   
    }
}