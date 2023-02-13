
using System.Security.Principal;

namespace cSharpSyntax;

    public class Properties
    {
    [Fact]
    public void WorkingWithTheAccount()
    {
        var account = new Account();
        account.Name = "Bob";
        Assert.Equal("Bob", account.Name);

        Assert.Equal(5000M, account.Balance);
    }
}
public class Account
{
    private string _name = "";
    private decimal _balance = 5000M;
    
    public string Name // Property ----can use get, set in .NET
    {
        get { return _name; }
        set { _name = value; }
        //private set means it can only be changed within the class, not outside
        //read only would only have a get property
    }
    public decimal Balance
    {
        get { return _balance; }           
    }

}

