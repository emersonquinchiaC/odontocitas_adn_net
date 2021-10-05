using OdontoCitas.Domain.Users.Entities;
using OdontoCitas.Domain.Users.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoCitas.Domain.Users.Services
{
    public class UserService : IUserService, IDisposable
    {

        private readonly IUserRepository<User> _UserRepository;

        public UserService(IUserRepository<User> userRepository)
        {
            _UserRepository = userRepository;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            this._UserRepository.Dispose();
        }

        public async Task DeleteUser(User u)
        {
            await _UserRepository.DeleteAsync(u).ConfigureAwait(false);
        }


        public async Task<IEnumerable<User>> FindAllUsersAsync()
        {
            return await _UserRepository.GetAsync().ConfigureAwait(false);
        }

        public async Task<IEnumerable<User>> FindUserByIdentificationAsync(string identification)
        {
            return await _UserRepository.GetByIdentificationAsync(identification).ConfigureAwait(false);
        }

        public async Task<User> SaveUserAsync(User u)
        {

            return await _UserRepository.AddAsync(u).ConfigureAwait(false);
        }

        public async Task UpdateUser(User u)
        {
            await _UserRepository.UpdateAsync(u).ConfigureAwait(false);
        }

    }       
}
