using System.Text;

namespace Builder;

public class Car
{
    private readonly List<string> parts = new();
    private readonly string carType;

    public Car(string carType)
    {
        this.carType = carType;
    }

    public void AddPart(string part)
    {
        this.parts.Add(part);
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        foreach (var part in this.parts)
        {
            stringBuilder.Append($"Car of type {carType} has part {part}. ");
        }

        return stringBuilder.ToString();
    }
}

public abstract class CarBuilder
{
    public Car Car { get; private set; }

    public CarBuilder(string carType)
    {
        Car = new Car(carType);
    }

    public abstract void BuildEngine();

    public abstract void BuildFrame();
}

public class MiniBuilder : CarBuilder
{
    public MiniBuilder() : base("Mini")
    {
        
    }

    public override void BuildEngine()
    {
        Car.AddPart("'Not a V8'");
    }

    public override void BuildFrame()
    {
        Car.AddPart("'5-door with metallic finish'");
    }
}

public class BMWBuilder : CarBuilder
{
    public BMWBuilder() : base("BMW")
    {

    }

    public override void BuildEngine()
    {
        Car.AddPart("'A fancy V8 engine'");
    }

    public override void BuildFrame()
    {
        Car.AddPart("'5-door with metallic finish'");
    }
}

public class Garage
{
    private CarBuilder? carBuilder;

    public Garage()
    {
        
    }

    public void Construct(CarBuilder carBuilder)
    {
        this.carBuilder = carBuilder;

        this.carBuilder.BuildEngine();
        this.carBuilder.BuildFrame();
    }

    public void Show()
    {
        Console.WriteLine(carBuilder?.Car.ToString());
    }
}

