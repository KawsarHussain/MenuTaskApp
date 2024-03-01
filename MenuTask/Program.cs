/*
Create a menu where a user would have to log in to with a username and password
Username shouldn't be case specific
Passwords should be case specific
Once logged in, a menu should be presented. Once the menu item has been selected, just repeat the menu selection back
*/

//Set up username and password
string username = "user";
string password = "Password123";

//Inputting of username and password
Console.Write("Username: ");
string inputUsername;
while (true)
{
    inputUsername = Console.ReadLine();
    if (inputUsername == "")
        Console.Write("""
            Please input a Username
            Username: 
            """);
    else
        break; 
}

Console.Write("Password: ");
String inputPassword = Console.ReadLine();

