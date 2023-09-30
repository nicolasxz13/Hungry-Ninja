//No me acordaba de las instrucciones de nivel superior.
//https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/top-level-statements

Buffet buffete = new Buffet();

Ninja ninja = new Ninja();

ninja.Eat(buffete.Serve());
ninja.Eat(buffete.Serve());
ninja.Eat(buffete.Serve());
ninja.Eat(buffete.Serve());
ninja.Eat(buffete.Serve());

class Food
{
    public string Name;
    public int Calories;
    public bool IsSpicy;
    public bool IsSweet;

    public Food(string name, int calories, bool isSpicy, bool isSweet)
    {
        Name = name;
        Calories = calories;
        IsSpicy = isSpicy;
        IsSweet = isSweet;
    }
};

class Buffet
{
    public List<Food> Menu;

    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Carne", 1200, false, false),
            new Food("Helado", 2000, false, true),
            new Food("Frutas", 1400, false, true),
            new Food("Pan Con carne", 1300, false, false),
            new Food("Costillar", 1300, false, false),
            new Food("Costillar Argentino", 1650, false, false),
            new Food("Costillar Brazileño", 1700, false, false),
        };
    }

    public Food Serve()
    {
        Random rand = new Random();
        int result = rand.Next(0, Menu.Count);
        return Menu[result];
    }
};

class Ninja
{
    private int calorieIntake;
    public List<Food> FoodHistory;

    // add a constructor
    public Ninja()
    {
        calorieIntake = 0;
        FoodHistory = new List<Food>();
    }
    // add a public "getter" property called "IsFull"
    public bool IsFull()
    {
        if (calorieIntake > 1200)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    // build out the Eat method
    public void Eat(Food item)
    {
        if (!IsFull())
        {
            calorieIntake += item.Calories;
            FoodHistory.Add(item);
            Console.WriteLine($"Nombre comida : {item.Name}");
            if (item.IsSpicy)
            {
                Console.WriteLine("Es Picante");
            }
            else
            {
                Console.WriteLine("No es Picante");
            }
            if (item.IsSweet)
            {
                Console.WriteLine("Es Dulce \n");
            }
            else
            {
                Console.WriteLine("No es Dulce \n");
            }
        }
        else
        {
            Console.WriteLine("No puedo comer mas estoy lleno");
        }
    }
};
