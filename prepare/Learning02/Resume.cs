public class Resume
    {
    public Resume()
        {
        }

    public string _member;

    public List<Job> _jobs = new List<Job>();

    public void Display()
        {
            foreach ( Job i in _jobs)
                {
                    i.DisplayJobDetails();
                }
        }
}