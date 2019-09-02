using System;
using System.Threading.Tasks;
using benchmark_serilizer.Extension;
using StackExchange.Redis;

namespace benchmark_serilizer
{
    public class RedisCacheService
    {
        private readonly ConnectionMultiplexer _client;

        public RedisCacheService()
        {
            var connectionString = "10.20.48.86:6379";

            ConfigurationOptions options = new ConfigurationOptions
            {
                EndPoints =
                {
                    connectionString
                },
                AbortOnConnectFail = false,
                AsyncTimeout = 10000,
                ConnectTimeout = 10000,
                KeepAlive = 180
            };

            _client = ConnectionMultiplexer.Connect(options);
        }

        public void Set(string key, string value)
        {
            _client.GetDatabase().StringSet(key, value);
        }

        public void Set<TValue>(string key, TValue value) where TValue : class
        {
            _client.GetDatabase().StringSet(key, value.ToByte());
        }

        public Task SetAsync(string key, object value)
        {
            return _client.GetDatabase().StringSetAsync(key, value.ToByte());
        }

        public void Set(string key, object value, TimeSpan expiration)
        {
            _client.GetDatabase().StringSet(key, value.ToByte(), expiration);
        }

        public Task SetAsync(string key, object value, TimeSpan expiration)
        {
            return _client.GetDatabase().StringSetAsync(key, value.ToByte(), expiration);
        }

        public TValue Get<TValue>(string key) where TValue : class
        {
            byte[] value = _client.GetDatabase().StringGet(key);

            return value.ToObject<TValue>();
        }

        public string Get(string key)
        {
            return _client.GetDatabase().StringGet(key);
        }

        public async Task<TValue> GetAsync<TValue>(string key) where TValue : class
        {
            byte[] value = await _client.GetDatabase().StringGetAsync(key);

            return value.ToObject<TValue>();
        }

        public void Remove(string key)
        {
            _client.GetDatabase().KeyDelete(key);
        }
    }
}
