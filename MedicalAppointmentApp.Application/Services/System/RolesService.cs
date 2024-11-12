
using MedicalAppointmentApp.Application.Contracts;
using MedicalAppointmentApp.Application.Dtos.System.Roles;
using MedicalAppointmentApp.Application.Responses.System.Roles;
using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Persistance.Interfaces.System;
using Microsoft.Extensions.Logging;

namespace MedicalAppointmentApp.Application.Services.System
{
    public class RolesService : IRolesService
    {
        private readonly IRolesRepository _rolesRepository;
        private readonly ILogger<RolesService> _logger;

        public RolesService(IRolesRepository rolesRepository,
                          ILogger<RolesService> logger)
        {
            _rolesRepository = rolesRepository;
            _logger = logger;
        }
        public async Task<RolesResponse> GetAll()
        {
            RolesResponse rolesResponse = new RolesResponse();

            try
            {
                var result = await _rolesRepository.GetAll();

                if (!result.Success)
                {
                    rolesResponse.Message = result.Message;
                    rolesResponse.IsSuccess = result.Success;
                    return rolesResponse;
                }

                rolesResponse.Data = result.Data;

            }
            catch (Exception ex)
            {

                rolesResponse.IsSuccess = false;
                rolesResponse.Message = "Error obteniendo los roles";
                _logger.LogError(rolesResponse.Message, ex.ToString());

            }

            return rolesResponse;
        }

        public async Task<RolesResponse> GetById(int Id)
        {
            RolesResponse rolesResponse = new RolesResponse();

            try
            {
                var result = await _rolesRepository.GetEntityBy(Id);

                if (!result.Success)
                {
                    rolesResponse.Message = result.Message;
                    rolesResponse.IsSuccess = result.Success;
                    return rolesResponse;
                }

                rolesResponse.Data = result.Data;

            }
            catch (Exception ex)
            {

                rolesResponse.IsSuccess = false;
                rolesResponse.Message = "Error obteniendo el rol";
                _logger.LogError(rolesResponse.Message, ex.ToString());

            }

            return rolesResponse;
        }

        public async Task<RolesResponse> SaveAsync(RolesSaveDto dto)
        {
            RolesResponse rolesResponse = new RolesResponse();

            try
            {
                Roles rol = new Roles();

                rol.RoleName = dto.RoleName;
                


                var result = await _rolesRepository.Save(rol);

                if (result.Success)
                {
                    rolesResponse.IsSuccess = true;
                    rolesResponse.Message = "Se guardó correctamente el rol";
                }
                else
                {
                    rolesResponse.IsSuccess = false;
                    rolesResponse.Message = result.Message;
                }
            }
            catch (Exception ex)
            {

                rolesResponse.IsSuccess = false;
                rolesResponse.Message = "Error guardando el rol";
                _logger.LogError(rolesResponse.Message, ex.ToString());
            }

            return rolesResponse;
        }

        public async Task<RolesResponse> UpdateAsync(RolesUpdateDto dto)
        {
            RolesResponse rolesResponse = new RolesResponse();

            try
            {
                var resultGetById = await _rolesRepository.GetRoleByRoleID(dto.RoleID);

                if (!resultGetById.Success)
                {
                    rolesResponse.IsSuccess = resultGetById.Success;
                    rolesResponse.Message = resultGetById.Message;
                    return rolesResponse;
                }


                if (resultGetById.Data == null)
                {
                    rolesResponse.IsSuccess = false;
                    rolesResponse.Message = "No se encontró el rol";
                    return rolesResponse;
                }

                if (!(resultGetById.Data is Roles rol))
                {
                    rolesResponse.IsSuccess = false;
                    rolesResponse.Message = "El tipo de datos es incorrecto.";
                    return rolesResponse;
                }

                rol.RoleID = dto.RoleID;
                rol.RoleName = dto.RoleName;


                var result = await _rolesRepository.Update(rol);

                if (result.Success)
                {
                    rolesResponse.IsSuccess = true;
                    rolesResponse.Message = "El rol fue actualizado correctamente.";
                }
                else
                {
                    rolesResponse.IsSuccess = false;
                    rolesResponse.Message = result.Message;
                }

            }
            catch (Exception ex)
            {

                rolesResponse.IsSuccess = false;
                rolesResponse.Message = "Error actualizando el rol.";
                _logger.LogError(rolesResponse.Message, ex.ToString());
            }

            return rolesResponse;
        }
    }
}
