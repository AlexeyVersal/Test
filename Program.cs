using Constructor;

Prom program = new Prom("Alex", 24);
program.Show();

class Prom
{
    string _name;
    int _age;
    public Prom(string name, int age)
    {
        _name = name;
        _age = age;
    }
    public void Show()
    {
        Console.WriteLine($"Имя: {_name} Возраст: {_age}");
    }
}


