using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models{
    public class UserInfo
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [Phone]
        public string? Phone { get; set; }
        public bool WillAttend  { get; set; }
    }
}