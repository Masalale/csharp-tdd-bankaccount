using BankAccount;

namespace BankAccount.Tests
{
    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void NewAccount_Balance_ShouldBeZero()
        {
            var account = new BankAccount();
            var balance = account.GetBalance();
            Assert.That(balance, Is.EqualTo(0m));
        }

        [Test]
        public void Deposit_NegativeAmount_ShouldThrow() {}

        [Test]
        public void Deposit_ZeroAmount_ShouldThrow() {}

        [Test]
        public void Withdraw_MoreThanBalance_ShouldThrow() {}

        [Test]
        public void Withdraw_NegativeAmount_ShouldThrow() {}

        [Test]
        public void Withdraw_ZeroAmount_ShouldThrow() {}

    }
}
