// set up the inheritance relationship
using System;
namespace Homework
{
internal class WritingAssignment : BaseAssignment
{
    public WritingAssignment(string studentName, string topic, int grade)
        : base(studentName, topic, grade)
    {
        // Base constructor handles initialization
    }
        //Add the GetWritingInformation() method// ...existing code...
        public string GetWritingInformation() => $"{GetStudentName()} - {GetTopic()}";
        //getters for base class private members
        private string GetStudentName() => (string)typeof(BaseAssignment)
                .GetField("_studentName", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .GetValue(this);
        private string GetTopic() => (string)typeof(BaseAssignment)
                .GetField("_topic", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .GetValue(this);
    }
}