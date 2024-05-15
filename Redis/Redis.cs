using StackExchange.Redis;

namespace LoginServer.Redis
{
    public class Redis
    {
        ConnectionMultiplexer _redisConn;
        IDatabase _redisDb;

        public Redis()
        {
            _redisConn = ConnectionMultiplexer.Connect("localhost");
            _redisDb = _redisConn.GetDatabase();
        }

        public void SetKeyValue(string key, string value)
        {
            _redisDb.StringSet(key, value);
        }

        public string? GetValue(string key)
        {
            return _redisDb.StringGet(key);
        }

        public void RemoveKey(string key)
        {
            _redisDb.KeyDelete(key);
        }

        // 3 !! 
        
        // 

        //test 
        // 
        public async Task<bool> StoreAccount(string userID)
        {
            // redis ! 
            try
            {
                var result = await _redisDb.SetAddAsync("sdf", "sdf");
                
            }
            catch (Exception ex) 
            {
                
            }
           
        }

    }
}
