using System.ComponentModel.DataAnnotations;

namespace DK_JobTGoal.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}