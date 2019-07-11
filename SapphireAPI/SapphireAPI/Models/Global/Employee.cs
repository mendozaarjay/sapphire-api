using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SapphireAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public virtual Company Company { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Department Department { get; set; }
        public virtual Position Position { get; set; }
        public virtual EmployeeClassification EmployeeClassification { get; set; }
        public string EmployeeNo { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string ImageUrl { get; set; }
        public string TIN { get; set; }
        public string SSS { get; set; }
        public string PagIbig { get; set; }
        public string PhilHealth { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public decimal BasicSalary { get; set; }
        public bool IsActivated { get; set; }
        public bool IsLocked { get; set; }
        public bool IsVerified { get; set; }
        public bool IsUser { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
