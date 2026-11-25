using System.ComponentModel.DataAnnotations;

namespace postCheck.Models;

public class UserModel
{
    [Key]
    public string user_name { get; set; } = string.Empty;

    public string hashed_password { get; set; } = string.Empty;

    public ICollection<PostModel> posts { get; set; } = new List<PostModel>();
}