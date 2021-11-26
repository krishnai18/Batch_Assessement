using BatchAssessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatchAssessment.IRepository
{
  public  interface IBatchRepository
    {
        ICollection<BatchModel> GetBatches();

        BatchModel GetBatch (Guid batchId);
        bool CreateBatch(BatchModel batchObj);
        bool CheckIfBUExists(string businessUnitName);
        bool CheckAttribute(IEnumerable<Models.Atribute> attributesList);

        bool CheckACL(IEnumerable<Models.ACL> aclList);
    }
}
