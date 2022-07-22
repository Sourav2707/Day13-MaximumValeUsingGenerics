using FindMaximumValue;
Console.WriteLine("Welcome to Generics program to find the maximum of three values");
Find<int> check1 = new Find<int>();
Find<double> check2 = new Find<double>();
Find<string> check3 = new Find<string>();
check1.ToCompare(3, 2, 1);
check2.ToCompare(1.234, 2.453, 1.534);
check3.ToCompare("Sourava", "Srivatsan", "srinivasan");