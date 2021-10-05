using OdontoCitas.Domain.Appointments.Entities;
using OdontoCitas.Domain.Appointments.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoCitas.Domain.Appointments.Services
{
    public class AppointmentService : IAppointmentService, IDisposable
    {

        private readonly IAppointmentRepository<Appointment> _AppointmentRepository;

        public AppointmentService(IAppointmentRepository<Appointment> appointmentRepository)
        {
            _AppointmentRepository = appointmentRepository;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            this._AppointmentRepository.Dispose();
        }

        public async Task DeleteAppointment(Appointment a)
        {
            await _AppointmentRepository.DeleteAsync(a).ConfigureAwait(false);
        }

        public async Task<IEnumerable<Appointment>> FindAllAppointmentAsync()
        {
            return await _AppointmentRepository.GetAsync().ConfigureAwait(false);
        }

        public async Task<Appointment> FindAppointmentByIdAsync(Guid Id)
        {
            return await _AppointmentRepository.GetByIdAsync(Id).ConfigureAwait(false);
        }

        public async Task<Appointment> SaveAppointmentAsync(Appointment a)
        {
            return await _AppointmentRepository.AddAsync(a).ConfigureAwait(false);
        }

        public async Task UpdateAppointment(Appointment a)
        {
            await _AppointmentRepository.UpdateAsync(a).ConfigureAwait(false);
        }
    }
}
