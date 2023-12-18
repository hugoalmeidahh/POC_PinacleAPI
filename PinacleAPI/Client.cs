using System.ComponentModel.DataAnnotations;

namespace PinacleAPI
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "Só {1} caracteres calabreso")]
        public string Name { get; set; }

        [MaxLength(100, ErrorMessage = "Só {1} caracteres calabreso")]
        public string Email { get; set; }
        public bool isActived { get; set; }
    }
}
