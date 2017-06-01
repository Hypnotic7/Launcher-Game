using System;
using Launcher.BusinessLogic.Account.Encryption;
using Launcher.BusinessLogic.RepositoryFactory;
using Launcher.Data.Access.Interface;
using Launcher.Data.Access.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Launcher.BusinessLogic.Account.Validation.Login;

namespace Launcher.Business.Logic.Test.Account
{
    [TestClass]
    public class AccountValidationTests
    {
        [TestMethod]
        public void GivenValidAccountNameAndPasswordIShouldBeLoggedIn()
        {
            var accountName = "Test";
            var password = "test";

            AccountEntity accountEntity = new AccountEntity();
            accountEntity.AccountName = accountName;
            accountEntity.Password = EncrytionUtility.ComputePasswordHashValue(password);

            Moq.Mock<IDataAccess<AccountEntity>> dataAccessMock = new Mock<IDataAccess<AccountEntity>>();
            dataAccessMock.Setup(f => f.Find(It.IsAny<string>())).Returns(accountEntity);
            Moq.Mock<IRepositoryFactory<AccountEntity>> factoryMock = new Mock<IRepositoryFactory<AccountEntity>>();
            factoryMock.Setup(f => f.CreateRepository(It.IsAny<string>(), It.IsAny<string>())).Returns(dataAccessMock.Object);

            AccountValidation accountValidation = new AccountValidation(factoryMock.Object, String.Empty);
            var response = accountValidation.ValidateAccount(accountName, password);

            Assert.IsTrue(response.IsValid);
            dataAccessMock.VerifyAll();
            factoryMock.VerifyAll();
        }
    }
}
