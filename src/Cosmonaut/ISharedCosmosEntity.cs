using Newtonsoft.Json;

namespace Cosmonaut
{
    public interface ISharedCosmosEntity
    {
        [JsonProperty(nameof(DbType))]
        string DbType { get; set; }
    }
}