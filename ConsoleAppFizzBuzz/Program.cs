// See https://aka.ms/new-console-template for more information
const int fizz = 3;
const int buzz = 5;
const int start = 1;
const int end = 100;
Console.WriteLine("Hello, FizzBuzz World!");
Console.WriteLine(
    string.Join(
        Environment.NewLine,
        Enumerable.Range(start, end)
            .Select(n => (n % 3, n % 5) switch
            {
                (0, 0) => "FizzBuzz",
                (0, _) => "Fizz",
                (_, 0) => "Buzz",
                (_, _) => n.ToString()
            })
        )
    );
Console.ReadKey();