public interface IRateLimiter
{
    TimeSpan TimeWindow { get; }
    bool IsAllowed(string userId);
}