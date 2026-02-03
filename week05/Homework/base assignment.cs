//Add the attributes as private member variables.
//Create a constructor for this class that receives a student name and topic and sets the member variables.
//Add the method for GetSummary() to return the student's name and the topic.
// call the method to get the summary, and then display it to the screen.
using System;
namespace Homework
{
    internal class BaseAssignment
    {
        private string _studentName;
        private string _topic;
        private int _grade;

        public BaseAssignment(string studentName, string topic, int grade)
        {
            _studentName = studentName;
            _topic = topic;
            _grade = grade;
        }

        public string GetSummary()
        {
            return $"Student: {_studentName}, Topic: {_topic}, Grade: {_grade}";
        }
    }
}