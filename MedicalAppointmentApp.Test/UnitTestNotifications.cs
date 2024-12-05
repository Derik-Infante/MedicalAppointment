using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Domain.Result;
using MedicalAppointmentApp.Test.Context;
using MedicalAppointmentApp.Test.NotificationsTest;
using Moq;

namespace MedicalAppointmentApp.Test
{
    public class UnitTestNotifications
    {
        private readonly NotificationsMockRepository _notificationsRepository;

        public UnitTestNotifications()
        {
            var mockContext = new Mock<MedicalAppointmentsMockContext>();
            _notificationsRepository = new NotificationsMockRepository(mockContext.Object);
        }

        [Fact]
        public async void Save_NullNotification_ReturnsFailure()
        {
            // Arrange
            Notifications notification = null;

            // Act
            var result = await _notificationsRepository.Save(notification);
            var expectedMessage = "La entidad es requerida.";

            // Assert
            Assert.IsType<OperationResult>(result);
            Assert.False(result.Success);
            Assert.Equal(expectedMessage, result.Message);
        }

        [Fact]
        public async void Save_EmptyMessage_ReturnsFailure()
        {
            // Arrange
            var notification = new Notifications { Message = string.Empty };

            // Act
            var result = await _notificationsRepository.Save(notification);
            var expectedMessage = "Mensaje requerido";

            // Assert
            Assert.IsType<OperationResult>(result);
            Assert.False(result.Success);
            Assert.Equal(expectedMessage, result.Message);
        }
    }

}