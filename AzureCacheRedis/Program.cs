using StackExchange.Redis;

string connectionString = "sandeep-cache.redis.cache.windows.net:6380,password=phGh4eb1LLc6WzDSqXoaUAvjXV9dcuEIbAzCaOI4Ljg=,ssl=True,abortConnect=False";

ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(connectionString);

SetCacheData();
//GetCacheData();

void SetCacheData()
{
    IDatabase database=redis.GetDatabase();

    database.StringSet("top:3:subjects", "Maths,Chemistry,Physics");

    Console.WriteLine("Cache data set");
}

void GetCacheData()
{
    IDatabase database = redis.GetDatabase();
    if (database.KeyExists("top:3:subjects"))
        Console.WriteLine(database.StringGet("top:3:subjects"));
    else
        Console.WriteLine("key does not exist");

}