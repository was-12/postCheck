using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace postCheck.Models;

public class PostModel
{
    [Key]
    public string post_id { get; set; } = string.Empty;

    public string post_title { get; set; } = string.Empty;

    public string post_content { get; set; } = string.Empty;

    public string user_name { get; set; } = string.Empty;

    [ForeignKey(nameof(user_name))]
    public UserModel user { get; set; } = null!;
}