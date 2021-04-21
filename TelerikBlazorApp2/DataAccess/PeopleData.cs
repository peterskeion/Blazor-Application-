using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PeopleData : IPeopleData
    {
        private readonly IsqlDataAcess _db;
        public PeopleData(IsqlDataAcess db)
        {
            _db = db;

        }

        public Task<List<ContactModel>> GetContact()
        {

            string sql = "select * from dbo.Contacts";

            return _db.LoadData<ContactModel, dynamic>(sql, new { });
        }
        public Task Delete(string ids)
        {

            string sql = "DELETE FROM dbo.Contacts WHERE id = ";
            sql = sql + ids + " ;";
            return _db.SaveData(sql, new { id = ids });

        }

        public Task InsertContact(ContactModel contact)
        {


            string sql = @"insert into dbo.Contacts (id, lastName, firstName, PhoneNumber, birthDate) values (@id, @lastName, @firstName, @PhoneNumber, @birthDate);";


            return _db.SaveData(sql, contact);
        }

        public Task updateContact(ContactModel contact)
        {

            string id = contact.id;
            string lastName = contact.lastName;
            string firstName = contact.firstName;
            string phoneNumber = contact.PhoneNumber;
            DateTime date = contact.birthDate;

            string sql = @"UPDATE dbo.Contacts SET lastName = " +"'" + lastName +"'"+ " , firstName = " +"'"+ firstName +"'"+ " , PhoneNumber = " + phoneNumber + " , birthDate = " +"'" +date +"'"+ " WHERE id = "+ id +";";


            return _db.SaveData(sql, contact);
        }


    }
}
