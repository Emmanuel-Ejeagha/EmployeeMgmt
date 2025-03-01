using System.Text.Json.Serialization;

namespace BaseLib.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        // Relationship : One to Many
        [JsonIgnore]
        public List<Employee>? Employees { get; set; }

    }
}