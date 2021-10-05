using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoCitas.Domain.Appointments.Ports
{
    public interface IAppointmentRepository<E> : IDisposable where E : OdontoCitas.Domain.Appointments.Entities.Appointment
    {

        Task<IEnumerable<E>> GetAsync();
        Task<E> GetByIdAsync(object id);
        Task<E> AddAsync(E entity);
        Task UpdateAsync(E entity);
        Task DeleteAsync(E entity);


    }
}
