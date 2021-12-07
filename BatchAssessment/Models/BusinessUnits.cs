using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BatchAssessment.Models
{
    public class BusinessUnits
    {
        [Key]
        public string BusinessUnit { get; set; }

        public IEnumerable<ACL> ACLs { get; set; }
        public IEnumerable<Atribute> Attributes { get; set; }
        public Guid BatchId { get; set; }
        //BatchModel batch = new BatchModel();
    }
}
