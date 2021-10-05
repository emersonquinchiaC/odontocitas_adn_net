using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OdontoCitas.Domain.Users.Entities;

namespace OdontoCitas.Domain.Users.Ports
{
    public interface IUserService
    {

        Task<IEnumerable<User>> FindAllUsersAsync();
        Task<IEnumerable<User>> FindUserByIdentificationAsync(string identification);
        Task<User> SaveUserAsync(User u);
        Task DeleteUser(User u);
        Task UpdateUser(User u);

    }
}
