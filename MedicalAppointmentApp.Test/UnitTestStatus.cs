
using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Domain.Result;
using MedicalAppointmentApp.Test.Context;
using MedicalAppointmentApp.Test.StatusTest;
using Moq;

namespace MedicalAppointmentApp.Test
{
    public class UnitTestStatus
    {
        private readonly StatusMockRepository _statusRepository;

        public UnitTestStatus()
        {
            var mockContext = new Mock<MedicalAppointmentsMockContext>();
            _statusRepository = new StatusMockRepository(mockContext.Object);
        }

        [Fact]
        public async void Save_NullStatus_ReturnsFailure()
        {
            // Arrange
            Status status = null;

            // Act
            var result = await _statusRepository.Save(status);
            var expectedMessage = "La entidad es requerida.";

            // Assert
            Assert.IsType<OperationResult>(result);
            Assert.False(result.Success);
            Assert.Equal(expectedMessage, result.Message);
        }

        [Fact]
        public async void Save_EmptyStatusName_ReturnsFailure()
        {
            // Arrange
            var status = new Status { statusName = string.Empty };

            // Act
            var result = await _statusRepository.Save(status);
            var expectedMessage = "Nombre requerido";

            // Assert
            Assert.IsType<OperationResult>(result);
            Assert.False(result.Success);
            Assert.Equal(expectedMessage, result.Message);
        }
    }
}
