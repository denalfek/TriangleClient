// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var type = Triangles.TypeDetector.DetectType(1,2, 3);
var type1 = Triangles.TypeDetector.DetectType(1,2, 0);
Console.WriteLine(type);
Console.WriteLine(type1.AsT1.Value);