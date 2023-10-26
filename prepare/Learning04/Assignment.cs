public class Assignment
{

    private string _studentName = "";
    private string _topic = "";


    //constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string getSummary()
    {
        return $"{_studentName} - {_topic}";
    }
    public string getStudentName()
    {
        return _studentName;
    }









}
