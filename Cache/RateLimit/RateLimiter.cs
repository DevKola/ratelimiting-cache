public class RateLimiter : IRateLimiter
{
    private readonly Dictionary<string, List<DateTime>> _request = new();

    private readonly int _maxRequests;
    public TimeSpan TimeWindow { get; init; }

    public RateLimiter(int maxRequests, TimeSpan timeWindow)
    {
        _maxRequests = maxRequests;
        TimeWindow = timeWindow;
    }

    public bool IsAllowed(string userId)
    {
        if (!_request.ContainsKey(userId))
        {
            _request[userId] = new List<DateTime>(); 
        }
        
        var now = DateTime.UtcNow;
        _request[userId].RemoveAll(d => now - d > TimeWindow);

        if (_request[userId].Count >= _maxRequests)
        {
            return false;
        }
        _request[userId].Add(now);
        return true;
    }
}