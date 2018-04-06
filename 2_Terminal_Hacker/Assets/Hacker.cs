using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Game state
	int level;
	enum Screen { MainMenu, Password, Win };
	Screen currentScreen;
	string password;

	// Use this for initialization
	void Start ()
    {
        ShowMainMenu();
	}

    // Function for displaying the Main Menu
    void ShowMainMenu()
    {
		currentScreen = Screen.MainMenu;
		Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("");
        Terminal.WriteLine("Press 1 for Kitchen");
        Terminal.WriteLine("Press 2 for Police Station");
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter your selection:");
    }

    // Functioin to handle Main Menu
    void OnUserInput(string input)
    {
		if (input == "menu" || input == "Menu") // We can always go direct to main menu
		{
			ShowMainMenu();
		}
		else if (currentScreen == Screen.MainMenu)
		{
			RunMainMenu(input);
		}
		else if (currentScreen == Screen.Password)
		{
			CheckPassword(input);
		}
	}

	// Function to accept user input for level selection
	void RunMainMenu(string input)
	{
		if (input == "1")
		{
			level = 1;
			password = "One";
			StartGame();
		}
		else if (input == "2")
		{
			level = 2;
			StartGame();
		}
		else if (input == "007")
		{
			Terminal.WriteLine("Please select a valid option Mr. Bond");
		}
		else
		{
			Terminal.WriteLine("Please select a valid option");
		}
	}

	// Function to start the game once a level is selected
	void StartGame()
	{
		currentScreen = Screen.Password;
		Terminal.WriteLine("You have chosen level " + level);
		Terminal.WriteLine("Please enter your password: ");
	}

	// Function to check the current password for current level
	void CheckPassword(string input)
	{
		if (input == password)
		{
			Terminal.WriteLine("You have entered the correct password for level 1");
		}
		else
		{
			Terminal.WriteLine("You have entered the incorrect password for level " + level);
		}
	}
}
