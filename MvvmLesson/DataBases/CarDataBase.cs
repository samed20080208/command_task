using MvvmLesson.Models;

namespace MvvmLesson.DataBases;

public static class CarDataBase
{
    public static List<Car>? CarsDB { get; set; } = new List<Car>();
    static CarDataBase()
    {
        CarsDB = new List<Car>
        {
            new Car("Model S", "Tesla", new DateTime(2021, 1, 1), 5),
            new Car("Model 3", "Tesla", new DateTime(2021, 1, 1), 5),
            new Car("Model X", "Tesla", new DateTime(2021, 1, 1), 7),
            new Car("Model Y", "Tesla", new DateTime(2021, 1, 1), 7),
            new Car("Roadster", "Tesla", new DateTime(2021, 1, 1), 2),
            new Car("Cybertruck", "Tesla", new DateTime(2021, 1, 1), 6),
            new Car("Semi", "Tesla", new DateTime(2021, 1, 1), 2),
        };
    }
}
