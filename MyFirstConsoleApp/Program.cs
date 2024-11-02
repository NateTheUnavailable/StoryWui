using System.Diagnostics;

string contents = File.ReadAllText(@"C:\Users\nate\OneDrive\Documents\StoryWui\StoryWui\Arena Day.txt");
string choice = "";
Console.WriteLine(contents);
Console.WriteLine("Do You");
Console.WriteLine("A.Circle");
Console.WriteLine("B.Strike");
choice = Console.ReadLine();
choice = choice.ToUpper();
while(1==1)
{
    if(choice == "A")
    {
        contents = File.ReadAllText(@"C:\Users\nate\OneDrive\Documents\StoryWui\StoryWui\Circle.txt");
        Console.WriteLine(contents);
        contents = File.ReadAllText(@"C:\Users\nate\OneDrive\Documents\StoryWui\StoryWui\Repair.txt");
        Console.WriteLine(contents);
        Console.WriteLine("Do You");
        Console.WriteLine("C.Loyalty");
        Console.WriteLine("D.Rebellion");
        choice = Console.ReadLine();
        if(choice == "C")
        {
            contents = File.ReadAllText(@"C:\Users\nate\OneDrive\Documents\StoryWui\StoryWui\Loyalty.txt");
            Console.WriteLine(contents);
            Console.WriteLine("thanks for playing my game");
            System.Environment.Exit(1);
        }
        if(choice == "D")
        {
            contents = File.ReadAllText(@"C:\Users\nate\OneDrive\Documents\StoryWui\StoryWui\Rebellion.txt");
            Console.WriteLine(contents);
            Console.WriteLine("thanks for playing my game");
            System.Environment.Exit(1);
        }
    }
    if(choice == "B")
    {
        contents = File.ReadAllText(@"C:\Users\nate\OneDrive\Documents\StoryWui\StoryWui\Strike.txt");
        Console.WriteLine(contents);
        Console.WriteLine("Do You");
        Console.WriteLine("E.Respect");
        Console.WriteLine("F.Scorn");
        choice = Console.ReadLine();
        if(choice == "E")
        {
            contents = File.ReadAllText(@"C:\Users\nate\OneDrive\Documents\StoryWui\StoryWui\Respect.txt");
            Console.WriteLine(contents);
            Console.WriteLine("Do You");
            Console.WriteLine("G.Tribute");
            Console.WriteLine("H.Repair");
            choice = Console.ReadLine();
            if(choice == "G")
            {
                contents = File.ReadAllText(@"C:\Users\nate\OneDrive\Documents\StoryWui\StoryWui\Respect.txt");
                Console.WriteLine(contents);
                Console.WriteLine("Do You");
                Console.WriteLine("I.Sacrifice");
                Console.WriteLine("J.Harvest");
                choice = Console.ReadLine();
                if(choice == "I")
                {
                    contents = File.ReadAllText(@"C:\Users\nate\OneDrive\Documents\StoryWui\StoryWui\Respect.txt");
                    Console.WriteLine(contents);
                    Console.WriteLine("thanks for playing my game");
                    System.Environment.Exit(1);
                }
                if(choice == "J")
                {
                    contents = File.ReadAllText(@"C:\Users\nate\OneDrive\Documents\StoryWui\StoryWui\Respect.txt");
                    Console.WriteLine(contents);
                    Console.WriteLine("thanks for playing my game");
                    System.Environment.Exit(1);
                }
            }
            if(choice == "H")
            {
                contents = File.ReadAllText(@"C:\Users\nate\OneDrive\Documents\StoryWui\StoryWui\Scorn.txt");
                Console.WriteLine(contents);
                Console.WriteLine("thanks for playing my game");
                System.Environment.Exit(1);
            }
        }
        if(choice == "F")
        {
            contents = File.ReadAllText(@"C:\Users\nate\OneDrive\Documents\StoryWui\StoryWui\Scorn.txt");
            Console.WriteLine(contents);
            Console.WriteLine("Do You");
            Console.WriteLine("K.Repair");
            Console.WriteLine("L.Tribute");
            choice = Console.ReadLine();
            if(choice == "L")
            {
                contents = File.ReadAllText(@"C:\Users\nate\OneDrive\Documents\StoryWui\StoryWui\Respect.txt");
                Console.WriteLine(contents);
                Console.WriteLine("Do You");
                Console.WriteLine("I.Sacrifice");
                Console.WriteLine("J.Harvest");
                choice = Console.ReadLine();
                                if(choice == "I")
                {
                    contents = File.ReadAllText(@"C:\Users\nate\OneDrive\Documents\StoryWui\StoryWui\Respect.txt");
                    Console.WriteLine(contents);
                    Console.WriteLine("thanks for playing my game");
                    System.Environment.Exit(1);
                }
                if(choice == "J")
                {
                    contents = File.ReadAllText(@"C:\Users\nate\OneDrive\Documents\StoryWui\StoryWui\Respect.txt");
                    Console.WriteLine(contents);
                    Console.WriteLine("thanks for playing my game");
                    System.Environment.Exit(1);
                }
            }
            if(choice == "K")
            {
                contents = File.ReadAllText(@"C:\Users\nate\OneDrive\Documents\StoryWui\StoryWui\Scorn.txt");
                Console.WriteLine(contents);
                Console.WriteLine("thanks for playing my game");
                System.Environment.Exit(1);
            }
        }
    }
}