using AutoMapper;
using wex_test.Application.ViewModels;
using wex_test.Domain;

namespace wex_test.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<TransactionViewModel, TransactionWex>();
        }

    }
}
