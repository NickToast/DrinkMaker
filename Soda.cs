public class Soda : Drink
{
    public bool IsDietVersion {set; get;}

    public Soda (string name, string color, double temp, int calories, bool isDietVersion) : base(name, color,temp, true, calories)
    {
        IsDietVersion = isDietVersion;
    }

    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine($"Diet Version: {IsDietVersion}");
    }

}