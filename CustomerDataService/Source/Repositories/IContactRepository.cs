using System.Threading.Tasks;
using CustomerDataService.Dtos;
using CustomerDataService.Entities;

namespace CustomerDataService.Repositories
{

    public interface IContactRepository //what's the difference between IcontactRepository and a contactRepository?
    {
        public Task<ContactEntity> GetContactAsync(string phoneNumber);
        public Task<ContactEntity?> CreateContactAsync(CreateContactRequest request);
        public Task<ContactEntity?> UpdateContactAsync(int id, string? firstName, string? lastName, string? email, string? phoneNumber);
        public Task<ContactEntity?> DELETEContactAsync(int id);
    }
    
}