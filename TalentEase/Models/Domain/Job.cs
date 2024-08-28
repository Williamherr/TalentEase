using System.ComponentModel.DataAnnotations.Schema;

namespace TalentEase.Api.Models.Domain
{
    public class Job
    {
        [Column("job_id")]
        public int JobId { get; set; }

        [Column("job_title")]
        public string JobTitle { get; set; }

        [Column("min_salary")]
        public decimal? MinSalary { get; set; }

        [Column("max_salary")]
        public decimal? MaxSalary { get; set; }
    }
}
