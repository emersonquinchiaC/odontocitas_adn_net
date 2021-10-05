using OdontoCitas.Domain.AppointmentTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoCitas.Domain.Appointments.Entities
{
    public class Appointment : DomainEntity
    {

        private Guid Id { get; }
        private string UserId { get; }

        private AppointmentTypeEnum AppointmentType { get;  }

        private DateTime StartDate { get;  }

        private DateTime EndingDate { get; }

        public Appointment(Guid id, string userId, AppointmentTypeEnum appointmentType, DateTime startDate)
        {
            Id = id;
            UserId = userId;
            AppointmentType = appointmentType;
            StartDate = startDate;
            EndingDate = AssingEndingDate();
        }

        private DateTime AssingEndingDate()
        {
            return StartDate.AddMinutes(AppointmentType.Duration);
        }

        public Boolean IsBusyDate (Appointment appointment)
        {
            return (appointment.StartDate.Equals(StartDate)
                || (StartDate < appointment.StartDate) && (StartDate > appointment.EndingDate)
                || (EndingDate < appointment.StartDate) && (EndingDate > appointment.EndingDate));
        }
    }
}
