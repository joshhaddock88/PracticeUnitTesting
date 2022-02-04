using System;
using Xunit;
using UnitTestingLab;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnBalance()
        {
            decimal balance = 75.25m;
            Assert.Equal(balance, Program.ViewBalance(balance));
        }

        [Fact]
        public void CanWithdraw()
        {
            decimal balance = 75.25m;
            Assert.Equal(balance - 50, Program.Withdraw(50, balance));
        }

        [Fact]
        public void CannotWithdrawMoreThanBalance()
        {
            decimal balance = 75.25m;
            Assert.Equal(balance, Program.Withdraw(100, balance));
        }

        [Fact]
        public void CanDeposit()
        {
            decimal balance = 75.25m;
            Assert.Equal(balance + 50, Program.Deposit(50, balance));
        }
    }
}
