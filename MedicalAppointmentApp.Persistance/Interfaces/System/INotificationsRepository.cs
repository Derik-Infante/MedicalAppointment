﻿
using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Domain.Repositories;
using MedicalAppointmentApp.Domain.Result;

namespace MedicalAppointmentApp.Persistance.Interfaces.System
{
    public interface INotificationsRepository : IBaseRepository<Notifications> 
    {
        List<OperationResult> GetNotificationByNotificationID(int NotificationID);
    }
}
