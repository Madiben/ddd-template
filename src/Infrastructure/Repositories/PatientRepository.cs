using Application.Interfaces;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public class PatientRepository : IRepository<Patient>
    {
        // Repository implementation here
        Task IRepository<Patient>.AddAsync(Patient entity)
        {
            throw new NotImplementedException();
        }

        Task IRepository<Patient>.DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<Patient> IRepository<Patient>.GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Patient>> IRepository<Patient>.ListAsync()
        {
            throw new NotImplementedException();
        }

        Task IRepository<Patient>.UpdateAsync(Patient entity)
        {
            throw new NotImplementedException();
        }
    }
}