﻿using Identity_Server.Bases.Model;
using Identity_Server.Domain;
using Identity_Server.Repository;
using Microsoft.AspNetCore.Identity;

namespace Identity_Server.Service
{
    public class UserService : IUserRepository
    {
        private UserManager<UserEntity> UserManager;
        public UserService(UserManager<UserEntity> UserManager)
        {
            this.UserManager = UserManager;
        }

        public Result<long> Create(UserEntity entity)
        {
            throw new NotImplementedException();
        }

        public Result<bool> Delete(UserEntity entity)
        {
            throw new NotImplementedException();
        }

        public Result<bool> Delete(long ID)
        {
            throw new NotImplementedException();
        }

        public Result<UserEntity> Read()
        {
            throw new NotImplementedException();
        }

        public Result<List<UserEntity>> ReadAll()
        {
            throw new NotImplementedException();
        }

        public Result<bool> Update(UserEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
