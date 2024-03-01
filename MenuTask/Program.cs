/*
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
while (true)
{
    if (string.Equals(inputUsername, username, StringComparison.OrdinalIgnoreCase) && string.Equals(inputPassword, password))
    {
        Console.WriteLine("""
        You have inputted the correct password and username.
        You may now proceed onto the menu.
        Hope you will have a wonderful time exploring our options
        """);
        break;
    }
    else
    {
        Console.WriteLine("You have inputted the wrong username or password. Try again");
        inputUsername = InputCredentials("Username");
        inputPassword = InputCredentials("Password");

    }
}


//Method allows for the input of credentials
string InputCredentials(string inputTerm)
{
    //Inputting of Whatever is needed
    Console.Write($"{inputTerm}: ");
    string inputIn;
    //does not allow user to skip input
    while (true)
    {
        inputIn = Console.ReadLine();
        if (inputIn == "")
            Console.Write($"""
            Please input a {inputTerm}
            {inputTerm}: 
            """);
        else
            break;
    }
    return inputIn;
}

