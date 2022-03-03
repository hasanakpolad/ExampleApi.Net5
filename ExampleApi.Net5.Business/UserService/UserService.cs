using AutoMapper;
using ExampleApi.Net5.Business.Mapper;
using ExampleApi.Net5.Data.Dto;
using ExampleApi.Net5.Data.Entities;
using ExampleApi.Net5.DataAccess.Repository;
using ExampleApi.Net5.DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApi.Net5.Business.UserService
{
    public class UserService : IUserService
    {
        private UnitOfWork _uow;
        private IMapper _mapper;
        public UserService(IMapper mapper)
        {
            _mapper = mapper;

        }

        public UserDto Get(int id)
        {
            using (var uow = new UnitOfWork())
            {
                User data = uow.GetRepository<User>().Get(x => x.Id.Equals(id));
                UserDto dtoResult = _mapper.Map<UserDto>(data);
                return dtoResult;
            }
        }
        public IEnumerable<UserDto> GetAll()
        {
            using (var uow = new UnitOfWork())
            {
                var data = uow.GetRepository<User>().GetAll();
                IEnumerable<UserDto> dtoResult = _mapper.Map<IEnumerable<UserDto>>(data);
                return dtoResult;
            }
        }
        public void Add(UserDto model)
        {
            using (var uow = new UnitOfWork())
            {
                User dtoResult = _mapper.Map<User>(model);
                uow.GetRepository<User>().Add(dtoResult);
                uow.SaveChanges();
            }
        }
        public void Update(UserDto model)
        {
            using (var uow = new UnitOfWork())
            {
                User dtoResult = _mapper.Map<User>(model);
                uow.GetRepository<User>().Update(dtoResult);
                uow.SaveChanges();
            }
        }
        public void Delete(UserDto model)
        {
            using (var uow = new UnitOfWork())
            {
                User dtoResult = _mapper.Map<User>(model);
                uow.GetRepository<User>().Delete(dtoResult);
                uow.SaveChanges();
            }
        }
    }
}
