using System;
using System.Collections.Generic;
using System.Text;
using StackExchange.Redis;

namespace Repository
{
    public class RedisCacheSevcice
    {
        public string RedisConnectionGetValue(string key)
        {
            ConnectionMultiplexer RedisCache = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            IDatabase data = RedisCache.GetDatabase();

            string KeyValue = data.StringGet(key);
            return KeyValue;
        }

        public void RedisConnectionSetKeyValue(string key, string value)
        {
            ConnectionMultiplexer RadisCache = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            IDatabase data = RadisCache.GetDatabase();

            data.StringSet(key, value);
            data.StringGet(key);
        }
    }  
}
