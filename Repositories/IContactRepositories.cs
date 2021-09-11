using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ContactManagement.Entities;

namespace ContactManagement.Repositories
{
    public interface IContactRepositories
    {
        Task<Contact> GetContactAsync(Guid id);
        Task<IEnumerable<Contact>> GetContactsAsync();

        Task<IEnumerable<Contact>> SearchContactsAsync(string FirstName);

        Task CreateContactAsync(Contact contact);

        Task UpdateContactAsync(Contact contact);

        Task DeleteContactAsync(Guid id);

        
    }
}