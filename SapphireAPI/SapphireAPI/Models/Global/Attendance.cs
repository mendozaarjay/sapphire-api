using System;

namespace SapphireAPI.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual DateTime LogDate { get; set; }
    }
}
