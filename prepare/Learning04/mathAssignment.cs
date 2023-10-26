public class mathAssignment : Assignment
{
    private string _section;
    private string _problems;

    public mathAssignment(string studentName, string topic, string section, string problems)
        //this :base wasn't in the material... was it?
        : base(studentName, topic)
    {
        _section = section;
        _problems = problems;
    }

    public string getHomeWork()
    {

        return $"Section {_section} Problems {_problems}";
    }


}