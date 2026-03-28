namespace Week8;

public static class BoxingTester
{
    public static void Test()
    {
        int a = 10;
        // 1. box a into object
        object b = a;
        
// 2. unbox back into int
        int c = (int)b;
        
// 3. print all values
        Console.WriteLine($"original a: {a}");
        Console.WriteLine($"boxed obj b: {b}");
        Console.WriteLine($"unboxed c: {c}");
// 4. add comments explaining what happens
    }
}