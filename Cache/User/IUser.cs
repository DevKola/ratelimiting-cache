public interface IUser
{
    string Id { get; init; }
    string Name { get; init; }
    int Age { get; init; }
    UserEmploymentStatus EmploymentStatus { get; init; }
    string Email { get; init; }
    string JobTitle { get; init; }
}