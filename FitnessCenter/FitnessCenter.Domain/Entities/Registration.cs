using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FitnessCenter.Domain.Entities
{
    public class Registration
    {
        [Key]
        public int RegistrationID { get; set; }
        [ForeignKey("Schedule")]
        public int ScheduleID { get; set; }
        [ForeignKey("User")]
        public virtual string UserId { get; set; }
        public int WaitNumber { get; set; }
        public DateTime DateTime { get; set; }
        public RegisrtationStatus status { get; set; }
        [Required]
        public virtual Schedule Schedule { get; set; }
        public virtual AppUser User { get; set; }
    }

    public enum RegisrtationStatus
    {
        Confirmed,
        Waiting
    }
}
