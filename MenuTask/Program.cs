/*
Create a menu where a user would have to log in to with a username and password
Username shouldn't be case specific
Passwords should be case specific
Once logged in, a menu should be presented. Once the menu item has been selected, just repeat the menu selection back
*/

//Set up user dictionary. Keys are in lower case
Dictionary<string/*Username*/, string/*Password*/> users = new Dictionary<string, string>(); //username in lower case
users.Add("user1", "Password1");
users.Add("user2", "Password2");

//Set up username and password. Changed to do-while
string username = "user";
string password = "Password123";
string inputUsername;
string inputPassword;
bool check;

//Implemented the checking credentials using a diectionary
do
{
    inputUsername = InputCredentials("Username").ToLower();//Ensures case insensitivity
    inputPassword = InputCredentials("Password");
    check = users.ContainsKey(inputUsername) && inputPassword.Equals(users[inputUsername]);
    if (!check)
    {
        //Incorrect Credentials
        Console.Clear();
        Console.WriteLine("You have inputted the wrong username or password. Try again");
    }
} while (!check);

//do
//{
//    string inputUsername = InputCredentials("Username");
//    string inputPassword = InputCredentials("Password");
//    //Checks if user input is correct
//    check = string.Equals(inputUsername, username, StringComparison.OrdinalIgnoreCase) && string.Equals(inputPassword, password);
//    if (!check)
//    {
//        //Incorrect Credentials
//        Console.Clear();
//        Console.WriteLine("You have inputted the wrong username or password. Try again");
//    }
//} while (!check);

Console.Clear();

string menu = """
    1. Manage Self
    2. Manage Another User
    3. Upload Video
    4. Exit
    """;

Console.WriteLine($"""
        Welcome {inputUsername}!!!
        You may now proceed onto the menu.
        Hope you will have a wonderful time exploring our options
        Make sure to input a number between 1-4 to select the menu option
        {menu}
        """);

//This part handles the menu. Changed to do-while
int inputMenuNumber;
do
{
    inputMenuNumber = InputMenu();
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
    if (inputMenuNumber != 4) Console.WriteLine($"What else would you like to do? \n{menu}");
} while (inputMenuNumber != 4); //Want it to loop if the user does not exit the program


//This part is only reached once the user exits out of the menu
Console.WriteLine($"Hope you have had a wonderful time navigating this menu {inputUsername}. Thank you and goodbye.");


//Method to handle menu input
int InputMenu()
{
    string inputMenuOption;
    int inputNumber = -1;
    bool wrongInputType;
    //Validates the input for the menu options. Changed to do-while
    do
    {
        inputMenuOption = Console.ReadLine();
        try
        {
            wrongInputType = false;
            inputNumber = Int32.Parse(inputMenuOption); //Checks to see if the value can be converted to int
        }
        catch (FormatException) // If input cannot be parsed into integer
        {
            wrongInputType = true;   
        }

        if (inputNumber >= 1 && inputNumber <= 4) //Breaking condition
            Console.Clear();
        else
        {
            Console.Clear();
            inputMenuOption = "";//Made to be "" so it doesn't break out of loop
            if (wrongInputType) Console.WriteLine("Do not input a string."); //If the input is a string, it outputs this
            Console.WriteLine($"Please input a number between 1-4 \n{menu}");
        }
    } while (inputMenuOption == "");
    return inputNumber;
}

//Method allows for the input of credentials
string InputCredentials(string inputTerm)
{
    Console.Write($"{inputTerm}: ");
    string inputIn;
    //Prevents User from skipping input
    do
    {
        inputIn = Console.ReadLine();
        if (inputIn == "")
            Console.Write($"""
             Please input a {inputTerm}
             {inputTerm}: 
             """);
    } while (inputIn == "");
    return inputIn;
}

