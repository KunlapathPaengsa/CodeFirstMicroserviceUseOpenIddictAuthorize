using Common.Data.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Member.Models.Tables
{
    [Table(nameof(Member))]
    public class Member : IAuditableEntity
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(256), Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
        [MaxLength(256), Required]
        public string Email { get; set; }

        [Required]
        public string SecurityStamp { get; set; }

        public DateTime LastUpdatedPwd { get; set; }
        public int PwdExpiredDays { get; set; }

        [MaxLength(10)]
        public string PhoneNumber { get; set; }
        public int AccessFailedCount { get; set; }

        public string Pincode { get; set; }

        public string PincodeSecurityStamp { get; set; }

        public bool IsLocked { get; set; }
        public bool IsActive { get; set; }

        public Guid UserLevelId { get; set; }

        [MaxLength(50)]
        public string AccountNo { get; set; }

        public DateTime LastLoginDate { get; set; }
        public bool IsApprove { get; set; }
        public bool IsBuyProduct { get; set; }

        public bool IsEmailAuthentication { get; set; }
        public bool IsSmsAuthentication { get; set; }
        public bool IsGoogleAuthentication { get; set; }
        public string TwoFactorAuthenticationSecurity { get; set; }

        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        //public virtual MemberProfile MemberProfile { get; set; }
        //[ForeignKey("UserLevelId")]
        //public virtual UserLevel UserLevel { get; set; }
    }
}
