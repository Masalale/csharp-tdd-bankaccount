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
            _account.Deposit(100m);
            Assert.That(_account.GetBalance(), Is.EqualTo(100m));
        }

        [Test]
        public void Deposit_NegativeAmount_ShouldThrow()
        {
            Assert.Throws<ArgumentException>(() => _account.Deposit(-1m));
        }

        [Test]
        public void Withdraw_50_FromAccountWith100_BalanceShouldBe50()
        {
            _account.Deposit(100m);
            _account.Withdraw(50m);
            Assert.That(_account.GetBalance(), Is.EqualTo(50m));
        }

        [Test]
        public void Withdraw_MoreThanBalance_ShouldThrow()
        {
            _account.Deposit(100m);
            Assert.Throws<InvalidOperationException>(() => _account.Withdraw(200m));
        }

        [Test]
        public void Withdraw_NegativeAmount_ShouldThrow()
        {
            Assert.Throws<ArgumentException>(() => _account.Withdraw(-1m));
        }
    }
}
