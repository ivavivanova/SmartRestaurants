namespace Infrastructure.Enums
{
    using Infrastructure.Entities;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Question")]
    public partial class Question
    {
        public Question()
        {
            FeedbackQuestionAnswers = new HashSet<FeedbackQuestionAnswer>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        public virtual ICollection<FeedbackQuestionAnswer> FeedbackQuestionAnswers { get; set; }
    }
}
