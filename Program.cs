Soda Coke = new Soda("Coca Cola", "Dark Brown", 35, 150, false);
Coffee Latte = new Coffee("Mocha Latte", "Light Brown", 45, 390, "Dark", "Yemen");
Wine Chardonnay = new Wine("Chardonnay", "Yellow", 38, 100, "Napa Valley", 2022);


//Create list of all drinks
List<Drink> AllBeverages = new List<Drink>();
AllBeverages.Add(Coke);
AllBeverages.Add(Latte);
AllBeverages.Add(Chardonnay);

//Loop through list and ShowDrink();
foreach (Drink d in AllBeverages)
{
    d.ShowDrink();
    Console.WriteLine("========");
}

// Coffee MyDrink = new Soda();
//cannot make instances across child classes