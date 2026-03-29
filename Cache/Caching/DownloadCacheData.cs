public class DownloadCacheData : IDownloader
{
    private readonly ICache<string, IUser> _cache = new Cache<string, IUser>();
    private readonly IDownloader _downloader;
    private readonly IRateLimiter _rateLimiter;

    public DownloadCacheData(IDownloader downloader)
    {
        _downloader = downloader;
        _rateLimiter = new RateLimiter(5, TimeSpan.FromSeconds(10));
    }

    public IUser GetUser(string userId)
    {
        if (!_rateLimiter.IsAllowed(userId))
        {
            Console.WriteLine($"User with Id: {userId} has reached maximum requests" +
                              $"Wait for {_rateLimiter.TimeWindow}");
        }
        return _cache.Get(userId, _downloader.GetUser);
    }
}