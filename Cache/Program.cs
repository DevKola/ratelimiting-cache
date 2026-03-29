var users = new List<IUser>()
{
    new User("user_001", "John Smith", 29, UserEmploymentStatus.Active, "johnsmith@mail.com", "secretary"),
    new User("user_002", "Sam Pickle", 20, UserEmploymentStatus.Active, "sampickle@mail.com", "security"),
    new User("user_003", "Sarah Maclaren", 30, UserEmploymentStatus.Active, "sarahmaclareb@mail.com", "manager"),
    new User("user_004", "Fin Charlie", 26, UserEmploymentStatus.Active, "fincharlie@mail.com", "clerk"),
    new User("user_005", "James Tom", 21, UserEmploymentStatus.Active, "jamestom@mail.com", "customer support"),
};

var downloader = new Downloader(users);
var cachedData = new DownloadCacheData(downloader);

Console.WriteLine("Un-Cached data:");
Console.WriteLine(cachedData.GetUser("user_001"));
Console.WriteLine(cachedData.GetUser("user_002"));
Console.WriteLine(cachedData.GetUser("user_003"));

Console.WriteLine("Cached data:");
Console.WriteLine(cachedData.GetUser("user_001"));
Console.WriteLine(cachedData.GetUser("user_002"));
Console.WriteLine(cachedData.GetUser("user_003"));

Console.ReadKey();
