public class User : IUser
{
    public User(string id, string name, int age, UserEmploymentStatus employmentStatus, string email, string jobTitle)
    {
        Id = id;
        Name = name;
        Age = age;
        EmploymentStatus = employmentStatus;
        Email = email;
        JobTitle = jobTitle;
    }

    public string Id { get; init; }
    public string Name { get; init; }
    public int Age { get; init; }
    public UserEmploymentStatus EmploymentStatus { get; init; }
    public string Email { get; init; }
    public string JobTitle { get; init; }

    override public string ToString() => $@"Id: {Id}, Name: {Name}";
}