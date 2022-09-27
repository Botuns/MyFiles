using BotunsEntities.Entities;
using BotunsEntities.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BotunsEntities.Implementations.Repositories
{
    public class ContractRepository : IContractRepository
    {
        public Task<bool> Delete(Contract entity)
        {
            throw new NotImplementedException();
        }

        public Task<Contract> Get(Expression<Func<Contract, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Contract>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IList<Contract>> GetByExpression(Expression<Func<Contract, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Contract> Register(Contract entity)
        {
            throw new NotImplementedException();
        }

        public Task<Contract> Update(Contract entity)
        {
            throw new NotImplementedException();
        }
    }
}
