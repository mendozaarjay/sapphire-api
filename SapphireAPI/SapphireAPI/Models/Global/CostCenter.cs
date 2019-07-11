using System;

namespace SapphireAPI.Models
{
    public class CostCenter
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public virtual Company Company { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
