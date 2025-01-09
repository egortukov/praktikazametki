namespace praktikazametki;

class Program
{
    static void Main(string[] args)
    {
    }
}

public class Notes
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public DateTime Date { get; private set; }
    public bool State { get; private set; }
    public Users Owner { get; private set; }
}

public class Users
{
    public string Name { get; private set; }
    public DateTime RegistrationDate { get; private set; }
    public List<Notes> Notes { get; private set; }
}