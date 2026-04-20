using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wex_test.Application.ViewModels;
using wex_test.Domain;

namespace wex_test.Application.AutoMapper
{
    public class DomainToViewModelMappingTransaction : Profile
    {
        public DomainToViewModelMappingTransaction()
        {         
            CreateMap<TransactionWex, TransactionViewModel>();
        }
    }
}
