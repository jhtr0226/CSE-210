public class writingAssignment : Assignment
{

    private string _title;

    public writingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string getWritingInfo()
    {

        //needed to check it in this line:
        string studentName = getStudentName();
        return $"{_title} by {studentName}";
    }
}