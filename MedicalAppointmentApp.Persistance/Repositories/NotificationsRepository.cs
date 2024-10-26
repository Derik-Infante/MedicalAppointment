﻿

using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Domain.Result;
using MedicalAppointmentApp.Persistance.Base;
using MedicalAppointmentApp.Persistance.Context;
using MedicalAppointmentApp.Persistance.Interfaces.System;
using Microsoft.Extensions.Logging;

namespace MedicalAppointmentApp.Persistance.Repositories
{
    public class NotificationsRepository(MedicalAppointmentsContext medicalAppointmentsContext, ILogger<NotificationsRepository> logger) : BaseRepository<Notifications> (medicalAppointmentsContext), INotificationsRepository
    {
        private readonly MedicalAppointmentsContext _medicalAppointmentsContext = medicalAppointmentsContext;
        private readonly ILogger<NotificationsRepository> logger = logger;
        

        public List<OperationResult> GetNotificationByNotificationID(int NotificationID)
        {
            throw new NotImplementedException();
        }

        public override Task<OperationResult> Update(Notifications entity)
        {
            return base.Update(entity);
        }

    }
}
