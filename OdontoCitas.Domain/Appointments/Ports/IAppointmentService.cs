using OdontoCitas.Domain.Appointments.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoCitas.Domain.Appointments.Ports
{
    public interface IAppointmentService
    {
        Task<IEnumerable<Appointment>> FindAllAppointmentAsync();
        Task<Appointment> FindAppointmentByIdAsync(Guid Id);
        Task<Appointment> SaveAppointmentAsync(Appointment a);
        Task DeleteAppointment(Appointment a);
        Task UpdateAppointment(Appointment a);
    }
}
