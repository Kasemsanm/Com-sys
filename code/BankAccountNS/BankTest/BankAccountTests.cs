using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;

namespace BankTest
{
	[TestClass]
	public class BankAccountTests
	{
		[TestMethod]
		public void Debit_WithInValidAmount_UpdatesBalance()
		{ //arrange
			double beginningBalance = 1500; //เงินคงเหลือ
			double debitAmount = 500; //ถอน
			double expected = 500; //คาดว่าจะเหลือ
			BankAccount account = new BankAccount("Mr.Theerawut Thaweephattharawong", beginningBalance);
			//act
			account.Debit(debitAmount);
			// assert
			double actual = account.Balance; //1000
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Debit_WithValidAmount_UpdatesBalance()
		{ //arrange
			double beginningBalance = 1500; //เงินคงเหลือ
			double debitAmount = 500; //ถอน
			double expected = 1000; //คาดว่าจะเหลือ
			BankAccount account = new BankAccount("Mr.Theerawut Thaweephattharawong", beginningBalance);
			//act
			account.Debit(debitAmount);
			// assert
			double actual = account.Balance;
			Assert.AreEqual(expected, actual);
		}

	}
}
