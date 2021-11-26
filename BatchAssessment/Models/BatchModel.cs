using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BatchAssessment.Models
{
    public class BatchModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid BatchId { get; set; }


        [Required]
        [Display(Name = "BusinessUnit")]
        public string BusinessUnit { get; set; }
       // public int AttributeId { get; set; }
       // public int aclId { get; set; }
        public IEnumerable<ACL> ACLs { get; set; }
        public IEnumerable<Atribute> Attributes { get; set; }
        public DateTime ExpiryDate { get; set; }
    }

}
