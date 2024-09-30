public class Person
{
    private string name;
    private int age;
    private string address;

    public void SetName(string name) => this.name = name;
    public void SetAge(int age) => this.age = age;
    public void SetAddress(string address) => this.address = address;
    public string GetInfo() => $"Имя: {name}, Возраст: {age}, Адрес: {address}";
}
