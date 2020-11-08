using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Assessment_Project.DomainModel
{
    public class Answer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }

        [ForeignKey("QuestionId")]
        public Questions Questions { get; set; }
        public char AnswerLable { get; set; }
        public string Description { get; set; }
        public decimal Mark { get; set; }
        public byte IsBool { get; set; }
    }

}
