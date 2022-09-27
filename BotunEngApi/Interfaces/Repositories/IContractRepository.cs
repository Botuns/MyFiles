using BotunsEngApi.Entities;

namespace BotunsEngApi.Interfaces.Repositories
{
    public interface IContractRepository
    {
        public Contract CreateContract(Contract contract);
    }
}
