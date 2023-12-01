using System.Data.SqlTypes;
using System.Reflection.Metadata;

public class Appointment
{
    //whenever you see an "a", stands for appointment
    protected int _aId;
    protected string _dateNtime;
    protected string _patientDetails;
    protected string _docDetails;
    protected string _reason;
    protected string _status;


    public Appointment(int aId, string dateNtime, string reason, string status)
    {
        _aId = aId;
        _dateNtime = dateNtime;
        _reason = reason;
        _status = status;

        Person person = new Person();
        _docDetails = person.getDoc();
    }



    public virtual void CreateAppointment()
    {
        Console.Write("Patient's date of birth: ");
        Console.ReadLine();
    }
}

