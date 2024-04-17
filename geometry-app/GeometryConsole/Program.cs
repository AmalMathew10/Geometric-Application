using Microsoft.Extensions.Configuration;
using Microsoft.FeatureManagement;
using Microsoft.Extensions.DependencyInjection;

var featureManagement = new Dictionary<string, string>
{
    { "FeatureManagement:Square", "true" },
    { "FeatureManagement:Rectangle", "false" },
    { "FeatureManagement:Triangle", "true" }
};

IConfigurationRoot configuration = new ConfigurationBuilder()
    .AddInMemoryCollection(featureManagement)
    .Build();

var services = new ServiceCollection();
services.AddFeatureManagement(configuration);
var serviceProvider = services.BuildServiceProvider();

var featureManager = serviceProvider.GetRequiredService<IFeatureManager>();

if (await featureManager.IsEnabledAsync("Square"))
{
    Console.WriteLine("Square feature is enabled.");
    Console.Write("Enter the side length of the Square: ");
    double sideLength = double.Parse(Console.ReadLine());
    var square = new Square(sideLength);
    Console.WriteLine($"Area of the Square: {square.CalculateArea()}");
    Console.WriteLine($"Perimeter of the Square: {square.CalculatePerimeter()}");
}
else
{
    Console.WriteLine("Square feature is disabled.");
}

if (await featureManager.IsEnabledAsync("Rectangle"))
{
    Console.WriteLine("Rectangle feature is enabled.");
    Console.Write("Enter the length of the Rectangle: ");
    double length = double.Parse(Console.ReadLine());
    Console.Write("Enter the width of the Rectangle: ");
    double width = double.Parse(Console.ReadLine());
    var rectangle = new Rectangle(length, width);
    Console.WriteLine($"Area of the Rectangle: {rectangle.CalculateArea()}");
    Console.WriteLine($"Perimeter of the Rectangle: {rectangle.CalculatePerimeter()}");
}
else
{
    Console.WriteLine("Rectangle feature is disabled.");
}

if (await featureManager.IsEnabledAsync("Triangle"))
{
    Console.WriteLine("Triangle feature is enabled.");
    Console.Write("Enter the base of the Triangle: ");
    double @base = double.Parse(Console.ReadLine());
    Console.Write("Enter the height of the Triangle: ");
    double height = double.Parse(Console.ReadLine());
    var triangle = new Triangle(@base, height);
    Console.WriteLine($"Area of the Triangle: {triangle.CalculateArea()}");
    Console.WriteLine($"Perimeter of the Triangle: {triangle.CalculatePerimeter()}");
}
else
{
    Console.WriteLine("Triangle feature is disabled.");
}