namespace Infrastructure.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Feedback")]
    public partial class Feedback
    {
        public Feedback()
        {
            FeedbackQuestionAnswers = new HashSet<FeedbackQuestionAnswer>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int OrderId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime RegistrationDate { get; set; }

        public virtual Order Order { get; set; }

        public virtual ICollection<FeedbackQuestionAnswer> FeedbackQuestionAnswers { get; set; }
    }
}
