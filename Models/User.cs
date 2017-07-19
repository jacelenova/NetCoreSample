using System.ComponentModel.DataAnnotations;
namespace NetCoreSample.Models
{
    public class User
    {
        [Key]
        public int Id { get;set; }
        [MinLength(4)]
        public string Username { get; set; }
        [MinLength(4)]
        public string Password { get; set; }
    }
}