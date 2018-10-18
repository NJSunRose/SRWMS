using System.ComponentModel.DataAnnotations;

namespace SunRoseWMS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}