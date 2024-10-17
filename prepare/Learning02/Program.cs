using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new job instance named job1
        Job job1 = new Job();
    
        //  Set the member variables using the dot notation
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2010;
        job1._endYear = 2015;

        // New instance: job2
        Job job2 = new Job();

        // job2 member variables
        job2._jobTitle = "Network Engineer";
        job2._company = "Google";
        job2._startYear = 2015;
        job2._endYear = 2018;

        // job1.DisplayJobInfo();
        // job2.DisplayJobInfo();


        Resume myResume = new Resume();

        // New instance: Resume class
        // Resume resume = new Resume();
        myResume._personName = "July Johnson";

        myResume._jobList.Add(job1);
        myResume._jobList.Add(job2);

        myResume.DisplayResume();

        // resume._jobs[0]._jobTitle;
        // Console.WriteLine(resume._jobList[0]._jobTitle);

        

    }
}