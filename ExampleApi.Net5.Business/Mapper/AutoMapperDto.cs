using AutoMapper;
using ExampleApi.Net5.Data.Dto;
using ExampleApi.Net5.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApi.Net5.Business.Mapper
{
    public class AutoMapperDto : Profile
    {
        public AutoMapperDto()
        {
            CreateMap<User, UserDto>();
        }
    }
}
