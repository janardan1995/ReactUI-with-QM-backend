using System;
using System.Collections.Generic;
using System.Text;
using StackExchange.Redis;

namespace Repository
{
    public class RedisCache
    {
        public string RedisConnection(string key)
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            IDatabase data = redis.GetDatabase();

            string KeyValue = data.StringGet(key);
            return KeyValue;
        }

        public void RedisConnection(string key, string value)
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            IDatabase data = redis.GetDatabase();

            data.StringSet(key, value);
            data.StringGet(key);
        }
    }  
}
