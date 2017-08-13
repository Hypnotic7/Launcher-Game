using System;
using Launcher.BusinessLogic.RepositoryFactory;
using Launcher.Data.Access.Interface;
using Launcher.Data.Access.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Launcher.BusinessLogic.Account.Validation.Login;
using Launcher.BusinessLogic.Utilities.Encryption;

namespace Launcher.Business.Logic.Test.Account
{
    [TestClass]
    public class AccountValidationTests
    {
        private string _accountName { get; set; }
        private string _password { get; set; }
        [TestInitialize]
        public void Init()
        {
            _accountName = "Test";
            _password = "test";
        }

        [TestMethod]
        public void GivenValidAccountNameAndPasswordIShouldBeLoggedIn()
        {
            _accountName = "Test";
            _password = "test";

            AccountEntity accountEntity = new AccountEntity();
            accountEntity.AccountName = _accountName;
            accountEntity.Password = EncrytionUtility.ComputePasswordHashValue(_password);

            Mock<IDataAccess<AccountEntity>> dataAccessMock = new Mock<IDataAccess<AccountEntity>>();
            dataAccessMock.Setup(f => f.Find(It.IsAny<string>())).Returns(accountEntity);
            Mock<IRepositoryFactory<AccountEntity>> factoryMock = new Mock<IRepositoryFactory<AccountEntity>>();
            factoryMock.Setup(f => f.CreateRepository(It.IsAny<string>(), It.IsAny<string>())).Returns(dataAccessMock.Object);

            
            AccountValidation accountValidation = new AccountValidation(factoryMock.Object, string.Empty);
            var response = accountValidation.ValidateAccount(_accountName, _password);

            Assert.IsTrue(response.IsValid);
            Assert.AreEqual(accountEntity.AccountName,response.Account.AccountName);
            factoryMock.VerifyAll();
        }

        [TestMethod]
        public void GivenInvalidAccountNameIShouldNotLogIn()
        {
            _accountName = "";
            _password = "test";

            AccountEntity accountEntity = new AccountEntity();
            accountEntity.AccountName = _accountName;
            accountEntity.Password = EncrytionUtility.ComputePasswordHashValue(_password);

            Mock<IDataAccess<AccountEntity>> dataAccessMock = new Mock<IDataAccess<AccountEntity>>();
            dataAccessMock.Setup(f => f.Find(It.IsAny<string>())).Returns(accountEntity);
            Mock<IRepositoryFactory<AccountEntity>> factoryMock = new Mock<IRepositoryFactory<AccountEntity>>();
            factoryMock.Setup(f => f.CreateRepository(It.IsAny<string>(), It.IsAny<string>())).Returns(dataAccessMock.Object);


            AccountValidation accountValidation = new AccountValidation(factoryMock.Object, string.Empty);
            var response = accountValidation.ValidateAccount(_accountName, _password);

            Assert.IsFalse(response.IsValid);
            factoryMock.VerifyAll();
        }

        [TestMethod]
        public void GivenInvalidPasswordIShouldNotLogIn()
        {
            _accountName = "Test";
            _password = "";

            AccountEntity accountEntity = new AccountEntity();
            accountEntity.AccountName = _accountName;
            accountEntity.Password = EncrytionUtility.ComputePasswordHashValue(_password);

            Mock<IDataAccess<AccountEntity>> dataAccessMock = new Mock<IDataAccess<AccountEntity>>();
            dataAccessMock.Setup(f => f.Find(It.IsAny<string>())).Returns(accountEntity);
            Mock<IRepositoryFactory<AccountEntity>> factoryMock = new Mock<IRepositoryFactory<AccountEntity>>();
            factoryMock.Setup(f => f.CreateRepository(It.IsAny<string>(), It.IsAny<string>())).Returns(dataAccessMock.Object);


            AccountValidation accountValidation = new AccountValidation(factoryMock.Object, String.Empty);
            var response = accountValidation.ValidateAccount(_accountName, _password);

            Assert.IsFalse(response.IsValid);
            factoryMock.VerifyAll();
        }
    }
}
