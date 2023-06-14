 // случайное число 1 2 3 4 ..... 99
 double numberA = new Random().Next(1, 100);
 Console.WriteLine(numberA);
 double numberB = new Random().Next(1, 100);
 Console.WriteLine(numberB);
 double result = numberA + numberB;
 Console.WriteLine(result);