using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AulaAPI.DataModels
{
    public class Pessoa
    {
        public int id { get; set; }

        [Required]
        public string nome { get; set; }

        [JsonIgnore]
        public virtual ICollection<Email>? Emails { get; set; }
    }
}
