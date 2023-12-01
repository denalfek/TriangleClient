// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var firstType = Triangles.TypeDetector.DetectType(3,4, 5);
var secondType = Triangles.TypeDetector.DetectType(1.55M,14.0134M, 2.5M);
var error = Triangles.TypeDetector.DetectType(1,2, 0);
Console.WriteLine($"First type: {firstType.AsT0}");
Console.WriteLine($"Second type: {secondType.AsT0}");
Console.WriteLine(error.AsT1.Value);