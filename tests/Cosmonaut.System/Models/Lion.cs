using Cosmonaut.Attributes;

namespace Cosmonaut.System.Models
{
    [SharedCosmosCollection("shared")]
    public class Lion : Animal, ISharedCosmosEntity
    {
        [CosmosPartitionKey]
        public string Id { get; set; }

        public string DbType { get; set; }
    }
}