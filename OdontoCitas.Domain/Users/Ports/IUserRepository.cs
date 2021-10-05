using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OdontoCitas.Domain.Users.Ports
{
    public interface IUserRepository<E>  : IDisposable where E : OdontoCitas.Domain.Users.Entities.User
    {

        Task<IEnumerable<E>> GetAsync();
        Task<E> GetByIdAsync(object id);
        Task<IEnumerable<E>> GetByIdentificationAsync(object id);
        Task<Boolean> ExistAsync(object id);
        Task<Boolean> ExistExcludingIdAsync(object id, object identification);
        Task<E> AddAsync(E entity);
        Task UpdateAsync(E entity);
        Task DeleteAsync(E entity);
    

        


    }
}
