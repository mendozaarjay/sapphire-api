using System;

namespace SapphireAPI.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public virtual Company Company { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string LogoUrl { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string TIN { get; set; }
        public string SSS { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
