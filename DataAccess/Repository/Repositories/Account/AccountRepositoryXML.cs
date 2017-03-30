using System;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;

namespace DataAccess.Repository.Repositories.Account
{
    public class AccountRepositoryXML : XMLRepository, IDataAccess<AccountEntity>
    {
        public AccountRepositoryXML(string filePath) : base(filePath)
        {

        }

        public string CollectionName { get; }

        public void Add(AccountEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(AccountEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Modify(AccountEntity entity)
        {
            throw new NotImplementedException();
        }

        public AccountEntity Find(string id)
        {
           // var sectionElement = GetSectionElement("Accounts").XPathSelectElements("/Account/AccountID/" + id);
            
            return new AccountEntity();
        }

    }
}
