using BankAccount;

namespace BankAccount.Tests
{
    [TestFixture]
    public class BankAccountTests
    {
        private BankAccount _account;

        [SetUp]
        public void SetUp()
        {
            _account = new BankAccount();
        }

        [Test]
        public void NewAccount_Balance_ShouldBeZero()
        {
            Assert.That(_account.GetBalance(), Is.EqualTo(0m));
        }

        [Test]
        public void Deposit_100_Balance_ShouldBe100()
        {
        }

        [Test]
        public void Deposit_NegativeAmount_ShouldThrow()
        {
        }

        [Test]
        public void Withdraw_50_FromAccountWith100_BalanceShouldBe50()
        {
        }

        [Test]
        public void Withdraw_MoreThanBalance_ShouldThrow()
        {
        }

        [Test]
        public void Withdraw_NegativeAmount_ShouldThrow()
        {
        }
    }
}
