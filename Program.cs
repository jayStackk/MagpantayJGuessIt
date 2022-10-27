// John Magpantay
// 10-20-2022
// revamp : Guessing game! But only Hard Game! Trying to test to give the user minimum and maximum ranges of numbers they have to guess!
// Also trying out Do while loops i learned from w3schools, Basically acts like a while loop minus the if, if else , else, else if. 
// Peer review : 


string playAgain = "yes";
while (playAgain == "yes")
{
int clown = 0, numTwo = 0, min = 0, max = 10, pokeM = 0;
Random Rnd = new Random();
Console.WriteLine(" Guessing game!!! HARD ONLY!!!");
Console.Write("Enter the minimum range: ");
int Smallest = int.Parse(Console.ReadLine());

Console.Write("Enter the maximum range: ");
int Largest = int.Parse(Console.ReadLine());

clown = Convert.ToInt32(Rnd.Next(Smallest, Largest));
Console.Write("Enter numbers between those ");
do
{
    pokeM++;
    numTwo = Convert.ToByte(Console.ReadLine());
    if (numTwo > clown)
        max = numTwo;
    else
        min = numTwo;

    // Console.WriteLine("{0} - {1} Enter numbers between", min, max);
     Console.WriteLine("Enter numbers between", min, max);
}
while (clown != numTwo);

Console.WriteLine("Congratulations! it's : {0}.  {1} : times you guessed ", clown, pokeM);


// Console.ReadLine();

Console.WriteLine("Would you like to do it again? yes or no");
playAgain = Console.ReadLine();
if (playAgain == "yes")
{
    Console.WriteLine("Let's do it again!");

}
else
{
    Console.WriteLine("Thank you for your time, feed back please.");
}

}