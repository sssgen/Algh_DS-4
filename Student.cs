public class Student
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Group { get; set; }
    public string City { get; set; }
    public string Region { get; set; }

    public Student(string lastName, string firstName, string group, string city, string region)
    {
        LastName = lastName;
        FirstName = firstName;
        Group = group;
        City = city;
        Region = region;
    }

    public override string ToString()
    {
        return $"{LastName,-15} {FirstName,-10} {Group,-6} {City,-15} {Region,-15}";
    }
}
