namespace Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FeedbackQuestionAnswer")]
    public partial class FeedbackQuestionAnswer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int FeedbackId { get; set; }

        public int QuestionId { get; set; }

        public int AnswerId { get; set; }

        public virtual Answer Answer { get; set; }

        public virtual Feedback Feedback { get; set; }

        public virtual Question Question { get; set; }
    }
}
