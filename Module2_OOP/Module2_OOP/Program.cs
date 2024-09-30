using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Задача 1: Создание класса Person
        Person person = new Person();
        person.SetName("Иван Иванов");
        person.SetAge(30);
        person.SetAddress("Москва, ул. Примерная, д. 1");
        Console.WriteLine(person.GetInfo());

        // Задача 2: Наследование и полиморфизм
        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(4, 6);
        Shape triangle = new Triangle(4, 3);

        Console.WriteLine($"Площадь круга: {circle.Area()}, Периметр круга: {circle.Perimeter()}");
        Console.WriteLine($"Площадь прямоугольника: {rectangle.Area()}, Периметр прямоугольника: {rectangle.Perimeter()}");
        Console.WriteLine($"Площадь треугольника: {triangle.Area()}, Периметр треугольника: {triangle.Perimeter()}");

        // Задача 3: Композиция
        Author author = new Author("Лев Толстой", 1828);
        Book book = new Book("Война и мир", 1869, author);
        Console.WriteLine(book);

        // Задача 4: Интерфейсы
        IDrawable[] drawables = new IDrawable[] { new Circle(3), new Rectangle(2, 5), new Triangle(4, 3) };
        foreach (var drawable in drawables)
        {
            drawable.Draw();
        }

        // Задача 5: События
        TemperatureSensor sensor = new TemperatureSensor();
        Thermostat thermostat = new Thermostat(sensor);

        sensor.Temperature = 18; // Включить отопление
        sensor.Temperature = 22; // Выключить отопление

        // Вариант 1: Студенты
        Student[] students = new Student[3]
        {
            new Student { FirstName = "Алексей", LastName = "Смирнов", Age = 20, AverageScore = 4.5 },
            new Student { FirstName = "Ольга", LastName = "Петрова", Age = 22, AverageScore = 3.8 },
            new Student { FirstName = "Дмитрий", LastName = "Иванов", Age = 21, AverageScore = 4.2 }
        };

        foreach (var student in students)
        {
            Console.WriteLine($"Студент: {student.FirstName} {student.LastName}, Возраст: {student.Age}, Средний балл: {student.AverageScore}");
        }

        // Задача 2: Структура Train
        Train[] trains = new Train[5];

        // Заполнение массива поездов
        for (int i = 0; i < trains.Length; i++)
        {
            Console.WriteLine($"Введите информацию о поезде {i + 1}:");
            Console.Write("Пункт назначения: ");
            trains[i].Destination = Console.ReadLine();
            Console.Write("Номер поезда: ");
            trains[i].TrainNumber = int.Parse(Console.ReadLine());
            Console.Write("Время отправления (формат ГГГГ-ММ-ДД ЧЧ:ММ): ");
            trains[i].DepartureTime = DateTime.Parse(Console.ReadLine());
        }

        // Сортировка по номеру поезда
        Array.Sort(trains, (t1, t2) => t1.TrainNumber.CompareTo(t2.TrainNumber));

        // Вывод информации о всех поездах
        Console.WriteLine("\nСписок поездов (по номеру):");
        foreach (var train in trains)
        {
            Console.WriteLine($"Пункт назначения: {train.Destination}, Номер поезда: {train.TrainNumber}, Время отправления: {train.DepartureTime}");
        }

        // Вывод информации о поезде по номеру, введенному пользователем
        Console.Write("\nВведите номер поезда для получения информации: ");
        int trainNumberToFind = int.Parse(Console.ReadLine());
        var foundTrain = trains.FirstOrDefault(t => t.TrainNumber == trainNumberToFind);

        if (foundTrain.TrainNumber != 0) // Проверяем, что поезд найден
        {
            Console.WriteLine($"Пункт назначения: {foundTrain.Destination}, Номер поезда: {foundTrain.TrainNumber}, Время отправления: {foundTrain.DepartureTime}");
        }
        else
        {
            Console.WriteLine("Поезд не найден.");
        }

        // Сортировка по пункту назначения, затем по времени отправления
        Array.Sort(trains, (t1, t2) =>
        {
            int result = t1.Destination.CompareTo(t2.Destination);
            if (result == 0)
                return t1.DepartureTime.CompareTo(t2.DepartureTime);
            return result;
        });

        // Вывод информации после сортировки по пункту назначения
        Console.WriteLine("\nСписок поездов (по пункту назначения):");
        foreach (var train in trains)
        {
            Console.WriteLine($"Пункт назначения: {train.Destination}, Номер поезда: {train.TrainNumber}, Время отправления: {train.DepartureTime}");
        }

        Console.WriteLine("Программа завершена.");
        Console.ReadLine();
    }
}