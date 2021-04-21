using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IPeopleData
    {
        Task Delete(string ids);
        Task<List<ContactModel>> GetContact();
        Task InsertContact(ContactModel contact);
        Task updateContact(ContactModel contact);
    }
}