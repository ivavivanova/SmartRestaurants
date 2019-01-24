namespace Infrastructure.Entities
{
    using Infrastructure.Enums;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("FeedbackQuestionAnswer")]
    public partial class FeedbackQuestionAnswer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int FeedbackId { get; set; }

        public int QuestionId { get; set; }

        public int AnswerId { get; set; }

        public virtual Answer Answer { get; set; }

        public virtual Feedback Feedback { get; set; }

        public virtual Question Question { get; set; }
    }
}
