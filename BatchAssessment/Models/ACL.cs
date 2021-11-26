using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BatchAssessment.Models
{
    public class ACL
    {
       // [Key]
     // public int Id { get; set; }
      //  public Guid BatchId { get; set; }
     
        [Key]
        public string ReadUser { get; set; }
        public string ReadGroup { get; set; }
    }
}
