public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    public Resume()
    {

    }
    public void DisplayJobsList()
    {
        Console.WriteLine($"Name: {_name}");
        foreach (Job j in _jobs)
        {
            Console.
        }
    }
}