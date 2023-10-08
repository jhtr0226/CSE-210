public class Entry
{
    public string _todayDate;
    public string _answer;
    public string _prompt;

    public void entriesEntered()
    {
        Console.WriteLine($"Date: {_todayDate} - Prompt: {_prompt}\n{_answer}");
    }

}