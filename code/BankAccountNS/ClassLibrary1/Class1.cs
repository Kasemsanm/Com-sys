using System;
using BankAccountNS;

namespace ClassLibrary1
{
    public class Class1
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
	}
}
