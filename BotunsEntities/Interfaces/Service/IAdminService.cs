using BotunsEntities.DTO;
using System.Threading.Tasks;

namespace BotunsEntities.Interfaces.Service
{
    public interface IAdminService
    {
        Task<BaseResponseModel<AdminDTO>> RegisterAdmin(AdminRequestModel model);

        Task<BaseResponseModel<AdminDTO>> UpdateAdmin(UpdateAdminRequestModel model, int Id);

        Task<BaseResponseModel<AdminDTO>> GetAdminInfo(int id);

        Task<BaseResponseModels<AdminDTO>> GetAllAdmins();

        Task<BaseResponseModel<AdminDTO>> ActivateAdmin(int id);

        Task<BaseResponseModel<AdminDTO>> DeActivateAdmin(int id);

        Task<BaseResponseModels<AdminDTO>> GetAllActivatedAdmins();

        Task<BaseResponseModels<AdminDTO>> GetAllDeactivatedAdmins();

    }
}
