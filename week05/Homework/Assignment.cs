// inheritance in programming
//add attributes to assignment class
// it inherits from the base Assignment class.
// The Assignment class has three attributes: _studentName, _topic, and _grade.
//create new member variables for the ones you inherited from the base class.
using System;
namespace Homework
{
    internal class Assignment
    {
        private string _studentName;
        private string _topic;
        private int _grade;

        public Assignment(string studentName, string topic, int grade)
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

