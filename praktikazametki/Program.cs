namespace praktikazametki;

class Program
{
    static void Main(string[] args)
    {
    }
}

public class Notes
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public bool State { get; set; }
    public Users Owner { get; set; }
}

public class Users
{
    public string Name { get; set; }
    public DateTime RegistrationDate { get; set; }
    public List<Notes> Notes { get; set; }
}