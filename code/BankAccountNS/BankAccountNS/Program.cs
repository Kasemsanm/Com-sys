using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BankAccountNS
{
	public class BankAccount
	{

		private string m_customerName;
		private double m_balance;
		private bool m_frozen = false;

		private BankAccount()
		{
		}

		public BankAccount(string customerName, double balance)
		{
			m_customerName = customerName;
			m_balance = balance;
		}

		public string CustomerName
		{
			get { return m_customerName; }
		}

		public double Balance
		{
			get { return m_balance; }
		}

		public void Debit(double amount) //ถอนเงิน
		{
			if (m_frozen)//ถ้าบัญชีถูกระงับ
			{
				throw new Exception("Account frozen");
			}
			if (amount > m_balance)//ถ้าจำนวนเงินฝากหรือเครดิต (Credit) นั้น มากกว่าจำนวนยอดเงินคงเหลือ (Balance)
			{
				throw new ArgumentOutOfRangeException("amount");
			}
			if (amount < 0) //ถ้าจำนวนเงินฝากหรือเครดิต (Credit) นั้นน้อยกว่าศูนย์
			{
				throw new ArgumentOutOfRangeException("amount");
			}
			m_balance -= amount;
			//m_balance = m_balance - amount;
		}

		public void Credit(double amount)//ฝากเงิน
		{
			if (m_frozen)
			{
				throw new Exception("Account frozen"); //ถ้าบัญชีถูกระงับ
			}
			if (amount < 0)
			{
				throw new ArgumentOutOfRangeException("amount"); //ถ้าจำนวนเงินฝากหรือเครดิต (Credit) นั้นน้อยกว่าศูนย์
			}
			m_balance += amount;
			//m_balance = m_balance + amount;
		}

		private void FreezeAccount()//ระงับบัญชี
		{
			m_frozen = true;
		}

		private void UnfreezeAccount()//ปลดล็อคบัญชี
		{
			m_frozen = false;
		}

		public static void Main()
		{
			BankAccount ba = new BankAccount("Mr.Theerawut Thaweephattharawong", 500); //เงืนเหลือ
			ba.Credit(1500); //ฝากเงินเพิ่ม
			ba.Debit(500); //ถอนเงิน
			Console.WriteLine("Current balance is ", ba.Balance);
		}
	}
}