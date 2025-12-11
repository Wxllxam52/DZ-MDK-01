public class HeroIsDeadException : Exception
{
    public HeroIsDeadException(string message) : base(message)
    {
    }
}
public class Game
{
    public int Health { get; private set; }

    public Game(int health)
    {
        Health = health;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health <= 0)
        {
            Console.WriteLine($"Ошибка: Герой погиб! Здоровье стало {Health}");
        }
    }
}

class Program
{
    static void Main()
    {
        Game hero = new Game(100);
        Console.WriteLine($"Здоровье: {hero.Health}");
        Console.WriteLine($"Получаем урон: 150");
        hero.TakeDamage(150);

    }
}
