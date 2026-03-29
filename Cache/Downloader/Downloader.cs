public class Downloader : IDownloader
{
    private readonly IEnumerable<IUser> _user;

    public Downloader(IEnumerable<IUser> user)
    {
        _user = user;
    }

    public IUser GetUser(string userId)
    {
        if (userId == null)
        {
            throw new ArgumentNullException($"UserId cannot be null");
        }

        IUser result = null;
        foreach (var user in _user)
        {
            if (user.Id == userId)
            {
                result = user;
            }
        }

        Thread.Sleep(1000);
        return result;
    }
}