// Create the array of 12 Dad Jokes
string[] dadJokes = {
"What do you call fake spaghetti? An Impasta!",
"Why did the scarecrow win an award? Because he was outstanding in his field!",
"How do you organize a space party? You planet!",
"What do you call cheese that isn't yours? Nacho cheese!",
"Why don't skeletons fight each other? They don't have the guts!",
"What did the grape do when he got stepped on? Nothing but let out a little whine!",
"Why did the bicycle fall over? Because it was two tired!",
"What do you call a fish with no eyes? Fsh!",
"Why did the coffee file a police report? It got mugged!",
"What do you call a can opener that doesn't work? A can't opener!",
"What do you call a bear with no teeth? A gummy bear!",
"Why did the tomato turn red? Because it saw the salad dressing!" };

// Create new random and bool variables
Random rnd = new Random();
bool more = true;

// Print welcome message 
Console.WriteLine("Welcome to the Dad Joke Generator!");

// While statement to keep printing jokes
while (more)
{
    // Create random numbers within the array
    int num1 = rnd.Next(0, dadJokes.Length);
    int num2;

    // Make sure the second joke is different
    do
    {
        num2 = rnd.Next(0, dadJokes.Length);
    } while (num2 == num1);

    //Print 2 jokes
    Console.WriteLine(dadJokes[num1]);
    Console.WriteLine(dadJokes[num2]);

    // Ask the user if they want to see more jokes
    Console.Write("Do you want to see more dad jokes? Enter True or False ");
    more = bool.Parse(Console.ReadLine());

    // Stop printing jokes if the user wants to stop
    if (!more)
    {
        more = false;
        Console.WriteLine("Thank you for using the program, Goodbye!");
    }

}
