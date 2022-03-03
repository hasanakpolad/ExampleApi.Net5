using ExampleApi.Net5.Data.Dto;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApi.Net5.Business.UserService
{
    public interface IUserService
    {
        UserDto Get(int id);
        IEnumerable<UserDto> GetAll();
        void Add(UserDto model);
        void Update(UserDto model);
        void Delete(UserDto model);

    }
}
