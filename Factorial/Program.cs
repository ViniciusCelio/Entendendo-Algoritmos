ulong Factorial (ulong number) {
    if (number <= 1) 
        return 1;
    else 
        return number * Factorial(number - 1);
}

Console.WriteLine(Factorial(9));

