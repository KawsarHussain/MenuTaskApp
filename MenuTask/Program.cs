﻿/*
Create a menu where a user would have to log in to with a username and password
Username shouldn't be case specific
Passwords should be case specific
Once logged in, a menu should be presented. Once the menu item has been selected, just repeat the menu selection back
*/

//Set up username and password

string username = "user";
string password = "Password123";

string inputUsername = InputCredentials("Username");
string inputPassword = InputCredentials("Password");

//Checks to see if the user inputs were correct
while (!(string.Equals(inputUsername, username, StringComparison.OrdinalIgnoreCase) && string.Equals(inputPassword, password)))
{
    //Incorrect Credentials
    Console.Clear();   
    Console.WriteLine("You have inputted the wrong username or password. Try again");
    inputUsername = InputCredentials("Username");
    inputPassword = InputCredentials("Password");
}
Console.Clear();
Console.WriteLine("""
        You have inputted the correct username and password.
        You may now proceed onto the menu.
        Hope you will have a wonderful time exploring our options
        Make sure to input a number between 1-4 to select the menu option
        """);

string menu = """
    1. Manage Self
    2. Manage Another User
    3. Upload Video
    4. Exit
    """;

Console.WriteLine(menu);


int inputMenuNumber = InputMenu();
while (inputMenuNumber != 4) //Want it to loop if the user does not exit the program
{
    //Used to handle the different Cases
    switch (inputMenuNumber)
    {
        case 1:
            Console.WriteLine("Manage Self");
            break;
        case 2:
            Console.WriteLine("Manage Another User");
            break;
        case 3:
            Console.WriteLine("Upload Video");
            break;
        case 4:
            Console.WriteLine("Exit");
            break;
    }
    Console.WriteLine($"What else would you like to do? \n{menu}");
    inputMenuNumber = InputMenu();
}

//This part is only reached once the user exits out of the menu
Console.WriteLine("Hope you have had a wonderfule time navigating this menu. Thank you and goodbye.");


//Method to handle menu input
int InputMenu()
{
    string inputMenuOption = "";
    int inputNumber = -1;
    //Validates the input for the menu options
    while (inputMenuOption == "")
    {
        inputMenuOption = Console.ReadLine();
        try
        {
            inputNumber = Int32.Parse(inputMenuOption); //Checks to see if the value can be converted to int
            if (inputNumber >= 1 && inputNumber <= 4) //Breaking condition
            {
                Console.Clear();
                break;
            }
        }
        catch (FormatException) // If input cannot be parsed into string
        {
            Console.Clear();
            Console.WriteLine("Do not input a string.");
        }
        inputMenuOption = "";
        Console.WriteLine($"Please input a number between 1-4 \n{menu}");
    }
    return inputNumber;
}

//Method allows for the input of credentials
string InputCredentials(string inputTerm)
{
    Console.Write($"{inputTerm}: ");
    string inputIn = Console.ReadLine();
    
    //does not allow user to skip input
    while (inputIn == "")
    {
        Console.Write($"""
         Please input a {inputTerm}
         {inputTerm}: 
         """);
        inputIn = Console.ReadLine();
    }
    return inputIn;
}

