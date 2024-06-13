using System.ComponentModel.DataAnnotations;

namespace CrudAbp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}