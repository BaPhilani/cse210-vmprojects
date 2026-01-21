using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        // Create two job instances
        Job job1 = new Job("Acme Corp", "Software Developer", 2019, 2022);
        Job job2 = new Job("Tech Solutions", "Senior Developer", 2022, 2024);

        // Create a resume instance
        Resume myResume = new Resume("John Smith");

        // Add jobs to the resume
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        // Display the resume
        myResume.Display();
    }
}