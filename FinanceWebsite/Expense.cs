namespace FinanceWebsite;

public class Expense(){
    public string? Name {get; set}
    public int Amount {get; set;}
    public bool IsAfterpay {get; set;} = false;
}