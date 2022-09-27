using BotunsEngineeringServices.Entities;

namespace BotunsEngineeringServices.Interfaces.Repositories
{
    public interface IContractRepository
    {
        public Contract CreateContract(Contract contract);
    }
}
