using System;
using System.Threading.Tasks;
using benchmark_serilizer.Extension;
using StackExchange.Redis;

namespace benchmark_serilizer
{
    public class RedisCacheServiceMsgPack
    {
        private readonly ConnectionMultiplexer _client;

        public RedisCacheServiceMsgPack()
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
            _client.GetDatabase(10).StringSet(key, value);
        }

        public void Set<TValue>(string key, TValue value) where TValue : class
        {
            _client.GetDatabase(10).StringSet(key, value.ToMsgPackSerialize());
        }

        public Task SetAsync(string key, object value)
        {
            return _client.GetDatabase(10).StringSetAsync(key, value.ToMsgPackSerialize());
        }

        public void Set(string key, object value, TimeSpan expiration)
        {
            _client.GetDatabase(10).StringSet(key, value.ToMsgPackSerialize(), expiration);
        }

        public Task SetAsync(string key, object value, TimeSpan expiration)
        {
            return _client.GetDatabase(10).StringSetAsync(key, value.ToMsgPackSerialize(), expiration);
        }

        public TValue Get<TValue>(string key) where TValue : class
        {
            byte[] value = _client.GetDatabase(10).StringGet(key);

            if (value == null)
            {
                return null;
            }
            return value.ToMsgPackDeserialize<TValue>();
        }

        public string Get(string key)
        {
            return _client.GetDatabase(10).StringGet(key);
        }

        public async Task<TValue> GetAsync<TValue>(string key) where TValue : class
        {
            byte[] value = await _client.GetDatabase(10).StringGetAsync(key);

            return value.ToMsgPackDeserialize<TValue>();
        }

        public void Remove(string key)
        {
            _client.GetDatabase(10).KeyDelete(key);
        }
    }
}
