using System;

namespace SapphireAPI.Models
{
    public class UserAccount
    {
        public int Id { get; set; }
        public string EmployeeNo { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string ImageUrl { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
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
