int randomNumber = new Random().Next(1, 3);

int Guess() 
{
    int num;
    Console.WriteLine("Please enter a guess between 1 and 3");
    try
    {
        num = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Please enter a valid number");
        num = Guess();
    }
    return num;
}

while (true)
{
    int guess = Guess();
    if(guess == randomNumber) 
    { 
        Console.WriteLine("Congradulation! You guess it");
    break;
    }
    else if(guess > randomNumber)
    {
        Console.WriteLine("Your guess was too high");
    }
    else if(guess < randomNumber)
    {
        Console.WriteLine("Your guess was too low");
    }
}