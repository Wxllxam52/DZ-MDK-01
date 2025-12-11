public class LoginAlreadyExistsException : Exception
{
    public string Login { get; }

    public LoginAlreadyExistsException(string login)
        : base($"Логин {login} уже занят!")
    {
        Login = login;
    }
}

public class WeakPasswordException : Exception
{
    public WeakPasswordException()
        : base("Слабый пароль: Минимум 6 символов")
    {
    }
}

public class UserService
{
    private HashSet<string> registeredLogins = new HashSet<string>();

    public void Register(string login, string password)
    {
        if (password.Length < 6)
        {
            throw new WeakPasswordException();
        }

        if (registeredLogins.Contains(login))
        {
            throw new LoginAlreadyExistsException(login);
        }

        registeredLogins.Add(login);
        Console.WriteLine($"Пользователь {login} успешно зарегистрирован");
    }
}

class Program
{
    static void Main()
    {
        var userService = new UserService();

        var registrations = new List<(string login, string password)>
        {
            ("admin", "123"),
            ("user1", "secret123"),
            ("user1", "password"),
        };

        foreach (var (login, password) in registrations)
        {
            Console.WriteLine($"Регистрация: {login}, {password}");
            try
            {
                userService.Register(login, password);
            }
            catch (WeakPasswordException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (LoginAlreadyExistsException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}