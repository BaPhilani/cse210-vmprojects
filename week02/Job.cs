class Job
{
//Create member variables in the class for each element that this class should contain. By convention these member variables should begin with an underscore and a lowercase letter such as _jobTitle
    private string _jobTitle;
    private string _company;
    private int _startYear;
    private int _endYear;

    //Create a constructor method for the class that accepts the necessary parameters to populate the member variables.
    public Job(string jobTitle, string company, int startYear, int endYear)
    {
        _jobTitle = jobTitle;
        _company = company;
        _startYear = startYear;
        _endYear = endYear;
    }

    //Create a method called DisplayJobDetails that displays the job information in the format: "Job Title at Company (Start Year - End Year)"
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} at {_company} ({_startYear} - {_endYear})");
    }
}