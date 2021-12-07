using BatchAssessment.Data;
using BatchAssessment.IRepository;
using BatchAssessment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatchAssessment.Repository
{
    public class BatchRepository : IBatchRepository
    {
        private readonly ApplicationDbContext _db;

        public BatchRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool CheckACL(IEnumerable<ACL> aclList)
        {
            if (aclList.Count() > 0)
            {
                foreach (var item in aclList)
                {
                    if (string.IsNullOrEmpty(item.ReadUser) || string.IsNullOrEmpty(item.ReadGroup))
                        return false;
                }
            }
            return true;
        }
    

        public bool CheckAttribute(IEnumerable<Atribute> attributes)
        {
            if (attributes.Count() > 0)
            {
                foreach (var item in attributes)
                {
                    if (string.IsNullOrEmpty(item.Key) || string.IsNullOrEmpty(item.Value))
                        return false;
                }
            }
            return true;
        }

        public bool CheckIfBUExists(string businessUnit)
        {
            if (string.IsNullOrEmpty(businessUnit))
                return false;
            return _db.Batches.Any(bu => bu.BusinessUnit.ToLower().Trim() == businessUnit.ToLower().Trim());
        }

        public bool CreateBatch(BatchModel batchObj)
        {
            _db.Batches.Add(batchObj);
            return Save();
        }
        public bool UpdateBatch(BatchModel batchObj)
        {
            _db.Batches.Update(batchObj);
            return Save();
        }
        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }
        public BatchModel GetBatch(Guid batchId)
        {
           return _db.Batches.Include(b => b.Attributes).Include(b=>b.ACLs).ToList().FirstOrDefault(b => b.BatchId == batchId);
        }

        public ICollection<BatchModel> GetBatches()
        {
            return _db.Batches.OrderBy(a => a.BusinessUnit).ToList();
        }
    }
}
