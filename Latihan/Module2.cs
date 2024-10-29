// Console.WriteLine("Welcome to Shape Calculator!");
// Console.WriteLine("-------------------------------");
// Console.WriteLine("Choose the shape:");
// Console.WriteLine("1. Circle");
// Console.WriteLine("2. Square");
// Console.WriteLine("3. Triangle");
// Console.Write("Input your choice of shape: ");
// int shape = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Choose the calculation:");
// Console.WriteLine("1. Area");
// Console.WriteLine("2. Perimeter");
// Console.Write("Input your choice of calculation: ");
// int Choice = Convert.ToInt32(Console.ReadLine());

// switch (shape)
// {
//     case 1: 
//         if (Choice == 1) 
//         {
//             Console.Write("Input the radius: ");
//             double radius = Convert.ToDouble(Console.ReadLine());
            
//             double area = Math.PI * Math.Pow(radius, 2);
//             Console.WriteLine($"Area of the circle: {area:F2} cm²");
//         }
//         else if (Choice == 2) 
//         {
//             Console.Write("Input the radius: ");
//             double radius = Convert.ToDouble(Console.ReadLine());

//             double perimeter = 2 * Math.PI * radius;
//             Console.WriteLine($"Circumference of the circle: {perimeter:F2} cm");
//         }
//         break;

//     case 2: 
//         Console.Write("Input the side length of the square: ");
//         double side = Convert.ToDouble(Console.ReadLine());
//         if (Choice == 1) 
//         {
//             double area = Math.Pow(side, 2);
//             Console.WriteLine($"Area of the square: {area:F2} cm²");
//         }
//         else if (Choice == 2) 
//         {
//             double perimeter = 4 * side;
//             Console.WriteLine($"Perimeter of the square: {perimeter:F2} cm");
//         }
//         break;

//     case 3: 
//         if (Choice == 1)
//         {
//             Console.Write("Input the base of the triangle: ");
//             double baseLength = Convert.ToDouble(Console.ReadLine());
//             Console.Write("Input the height of the triangle: ");
//             double height = Convert.ToDouble(Console.ReadLine());

//             double area = 0.5 * baseLength * height;
//             Console.WriteLine($"Area of the triangle: {area:F2} cm²");
//         }
//         else if (Choice == 2) 
//         {
//             Console.Write("Input the base of the triangle: ");
//             double baseLength = Convert.ToDouble(Console.ReadLine());
//             Console.Write("Input the side a length: ");
//             double sideA = Convert.ToDouble(Console.ReadLine());
//             Console.Write("Input the side b length: ");
//             double sideB = Convert.ToDouble(Console.ReadLine());

//             double perimeter = baseLength + sideA + sideB;
//             Console.WriteLine($"Perimeter of the triangle: {perimeter:F2} cm");
//         }
//         break;

//     default:
//         Console.WriteLine("Invalid shape choice!!!");
//         break;
// }