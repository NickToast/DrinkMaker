public class Wine : Drink
{
    public string Region {set; get;}
    public int YearBottled {set; get;}

    public Wine (string name, string color, double temp, int calories, string region, int yearBottled) : base(name, color, temp, false, calories)
    {
        Region = region;
        YearBottled = yearBottled;
    }

    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine($"Region: {Region}");
        Console.WriteLine($"Year Bottled: {YearBottled}");
    }

}