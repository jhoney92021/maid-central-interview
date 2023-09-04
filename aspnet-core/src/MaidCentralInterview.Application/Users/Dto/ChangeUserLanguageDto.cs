using System.ComponentModel.DataAnnotations;

namespace MaidCentralInterview.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}