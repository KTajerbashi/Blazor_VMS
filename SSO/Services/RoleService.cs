﻿using AutoMapper;
using SSO.BaseSSO.Model;
using SSO.BaseSSO.Repository;
using SSO.Common;
using SSO.DatabaseApplication;
using SSO.Domains;
using SSO.Models.DTOs;
using SSO.Repositpries;

namespace SSO.Services
{
    public class RoleService : BaseServices<RoleDTO>, IRoleRepository
    {
        public RoleService(DbContextApplication context, IMapper mapper) : base(context, mapper)
        {
        }

        public override Result<long> Create(RoleDTO entity)
        {
            try
            {
                var model = Mapper.Map<RoleEntity>(entity);
                Context.Roles.Add(model);
                base.SaveChanges();
                return new Result<long>
                {
                    Data=model.Id,
                    Results = ResponseMessage.Success(),
                    Success= true,
                };
            }
            catch 
            {
                return new Result<long> { Success = false };
            }
        }

        public override Result<bool> Delete(RoleDTO entity)
        {
            throw new NotImplementedException();
        }

        public override Result<bool> Delete(long ID)
        {
            throw new NotImplementedException();
        }

        public override Result<RoleDTO> Read(long Id)
        {
            try
            {
                var model = Mapper.Map<RoleDTO>(Context.Roles.Find(Id));
                return new Result<RoleDTO>
                {
                    Data = model,
                    Results = ResponseMessage.Success(),
                    Success = true,
                };
            }
            catch
            {
                return new Result<RoleDTO> { Success = false };
            }
        }

        public override Result<List<RoleDTO>> ReadAll()
        {
            try
            {
                var model = Mapper.Map<List<RoleDTO>>(Context.Roles.ToList());
                return new Result<List<RoleDTO>>
                {
                    Data = model,
                    Results = ResponseMessage.Success(),
                    Success = true,
                };
            }
            catch
            {
                return new Result<List<RoleDTO>> { Success = false };
            }
        }

        public override Result<bool> Update(RoleDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}