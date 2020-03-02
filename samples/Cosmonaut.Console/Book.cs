using Cosmonaut.Attributes;
using Newtonsoft.Json;

namespace Cosmonaut.Console
{
    [SharedCosmosCollection("shared", "books")]
    public class Book : ISharedCosmosEntity
    {
        [CosmosPartitionKey]
        public string Name { get; set; }

        public string AnotherRandomProp { get; set; }
        
        public string Id { get; set; }

        public string DbType { get; set; }
        
        [JsonProperty("_etag")]
        public string Etag { get; set; }
    }
}