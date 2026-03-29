public class Cache<TKey, TData> : ICache<TKey, TData>
{
    private readonly Dictionary<TKey, TData> _cacheData = new Dictionary<TKey, TData>();

    public TData Get(TKey key, Func<TKey, TData> getDataFromDb)
    {
        if (key is null)
        {
            throw new ArgumentNullException($"Key cannot be null");
        }

        if (!_cacheData.ContainsKey(key))
        {
            _cacheData[key] = getDataFromDb(key);
        }

        return _cacheData[key];
    }
}