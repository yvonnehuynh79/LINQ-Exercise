




List<string> foodMenu = new List<string>() { "Spaghetti", "Pizza", "Lasagna" };
foodMenu.Add("Tiramisu");
foodMenu.Add("IceCream");

var orderMenu = foodMenu.OrderBy(name => name.Length);

foreach (var menu in orderMenu)
{
    Console.WriteLine(menu);
}
