using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AulaAPI.DataModels
{
    public class Email
    {
        public int id { get; set; }

        [Required]
        public string email { get; set; }

        [JsonIgnore]
        public virtual Pessoa? pessoa { get; set; }
    }
}
