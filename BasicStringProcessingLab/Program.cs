

//Prompt the user to enter a sentence.  Split the sentence into individual words and display each word on its own line.


string userContinue = "";

do
{

    Console.WriteLine("Please enter a sentence:");
    string userInput = Console.ReadLine();
    Console.WriteLine();

    List<string> list = new(userInput.Split(" "));

    foreach (var item in list)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine();
    Console.WriteLine("Do you want to continue (y/n)?");
    userContinue = Console.ReadLine();
    Console.WriteLine();


} while (userContinue.ToLower() == "y");



//Repeatedly prompt the user to enter a string.  Store the string in a list and display the contents of the list with each element separated by a space.

List<string> list2 = new();

do
{

    Console.WriteLine("Please enter a string:");
    string userInput = Console.ReadLine();
    Console.WriteLine();

    list2.Add(userInput);


    Console.WriteLine("Do you want to add another string (y/n)?");
    userContinue = Console.ReadLine();
    Console.WriteLine();

} while (userContinue.ToLower() == "y");

foreach (var item in list2)
{
    Console.Write(item + " ");
}
Console.WriteLine();