
using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Domain.Result;
using MedicalAppointmentApp.Test.Context;
using MedicalAppointmentApp.Test.RolesTest;
using Moq;

namespace MedicalAppointmentApp.Test
{
    public class UnitTestRoles
    {
        private readonly RolesMockRepository _rolesRepository;

        public UnitTestRoles()
        {
            var mockContext = new Mock<MedicalAppointmentsMockContext>();
            _rolesRepository = new RolesMockRepository(mockContext.Object);
        }

        [Fact]
        public async void Save_NullRole_ReturnsFailure()
        {
            // Arrange
            Roles role = null;

            // Act
            var result = await _rolesRepository.Save(role);
            var expectedMessage = "La entidad es requerida.";

            // Assert
            Assert.IsType<OperationResult>(result);
            Assert.False(result.Success);
            Assert.Equal(expectedMessage, result.Message);
        }

        [Fact]
        public async void Save_EmptyRoleName_ReturnsFailure()
        {
            // Arrange
            var role = new Roles { RoleName = string.Empty };

            // Act
            var result = await _rolesRepository.Save(role);
            var expectedMessage = "Nombre del rol requerido";

            // Assert
            Assert.IsType<OperationResult>(result);
            Assert.False(result.Success);
            Assert.Equal(expectedMessage, result.Message);
        }
    }

}
