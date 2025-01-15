namespace CSharpOOPPolymorphism.Method_Overloading;

public class MethodOverloading
{
    public decimal _accountMoney { get; set; }

    public MethodOverloading(int accountMoney)
    {
        _accountMoney = accountMoney;
    }

    public void Transact(int amount)
    {
        decimal castAmount = amount;
        _accountMoney += castAmount;
    }

    public void Transact(decimal amount) 
    {
        _accountMoney += amount;
    }

    public string ShowBalance()
    {
        return $"Total balance is {_accountMoney.ToString()}$";
    }
}
