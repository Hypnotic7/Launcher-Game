using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.XMLRepository
{
    public class AccountRepositoryXML : XMLRepository, IDataAccess<AccountEntity>
    {
        public string CollectionName => "AccountRepositoryXML";

        public AccountRepositoryXML()
        {

        }

        public void Add(AccountEntity entity)
        {
            throw new NotImplementedException();
        }

        public AccountEntity Find(string id)
        {
            throw new NotImplementedException();
        }

        public void Modify(AccountEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(AccountEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
