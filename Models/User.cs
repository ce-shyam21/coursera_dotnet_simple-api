namespace UserManagementAPI.Models
{
    public class User
    {
        public int Id { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string? Name { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.EmailAddress]
        public string? Email { get; set; }
    }
}
