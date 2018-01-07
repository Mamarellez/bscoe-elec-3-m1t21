using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hacker : MonoBehaviour {

    // Use this for initialization
    string greetings = "Welcome Hacker!";
    int toCompare;
    int lvl;
    Screen currentScreen;

    enum Screen { MainMenu, Password, Win};
    string[] lvl1 = {"paper","pens","board","chair","table"};
    string[] lvl2 = {"deposit","cheque","payment","merchant","banking"};
    string[] lvl3 = { "accounts", "policies", "birthday", "notification", "messages" };

    void Start () {
      
        showMainMenu(greetings);
	}

    void showMainMenu(string greetings)
    {
        currentScreen = Screen.MainMenu;
        Terminal.WriteLine("M1T21");
        Terminal.WriteLine(greetings);
        Terminal.WriteLine("What would you like to hack?");
        Terminal.WriteLine("\nPress 1 to hack School Files");
        Terminal.WriteLine("Press 2 to hack Bank Account");
        Terminal.WriteLine("Press 3 to hack Facebook Account");
        Terminal.WriteLine("\nEnter your selection:");
        
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            Terminal.ClearScreen();
            showMainMenu(greetings);
        }
        else if (input == "007")
        {
            Terminal.WriteLine("Welcome Secret Agent!");
        }

        else if (currentScreen == Screen.MainMenu)
        {
            if (input == "1")
            {
                lvl = 1;
                StartGame();
            }
            else if (input == "2")
            {
                lvl = 2;
                StartGame();
            }
            else if (input == "3")
            {
                lvl = 3;
                StartGame();
            }
            else
            {
                Terminal.ClearScreen();
                Terminal.WriteLine("Please type a valid level");
            }
        }else if(currentScreen == Screen.Password)
        {
            if(lvl == 1)
            {
                if (input == lvl1[toCompare])
                {
                    WinGame(lvl);
                }
                else
                {
                    StartGame();
                }
            }else if (lvl == 2)
            {
                if (input == lvl2[toCompare])
                {
                    WinGame(lvl);
                }
                else
                {
                    StartGame();
                }
            }else if (lvl == 3)
            {
                if (input == lvl3[toCompare])
                {
                    WinGame(lvl);
                }
                else
                {
                    StartGame();
                }
            }
        }
        else if(currentScreen == Screen.Win)
        {
            WinGame(lvl);
        }
       
    }
    void WinGame(int level)
    {
        Terminal.ClearScreen();
        currentScreen = Screen.Win;
        if (level == 1)
        {
            Terminal.WriteLine("──────▄▀▄─────▄▀▄\n─────▄█░░▀▀▀▀▀░░█▄\n─▄▄──█░░░░░░░░░░░█──▄▄\n█▄▄█─█░░▀░░┬░░▀░░█─█▄▄█");
        }
        else if (level == 2)
        {
            Terminal.WriteLine("──────▄▀▄─────▄▀▄\n─────▄█░░▀▀▀▀▀░░█▄\n─▄▄──█░░░░░░░░░░░█──▄▄\n█▄▄█─█░░▀░░┬░░▀░░█─█▄▄█");
        }
        else if (level == 3)
        {
            Terminal.WriteLine("──────▄▀▄─────▄▀▄\n─────▄█░░▀▀▀▀▀░░█▄\n─▄▄──█░░░░░░░░░░░█──▄▄\n█▄▄█─█░░▀░░┬░░▀░░█─█▄▄█");
        }
            Terminal.WriteLine(" YEHEY! :)");

    }

    void StartGame()
    {
        Terminal.ClearScreen();
        currentScreen = Screen.Password;
        toCompare = UnityEngine.Random.Range(0, 4);
        if (lvl == 1)
        {
            Terminal.WriteLine("Level " + lvl +": "+StringExtension.Anagram(lvl1[toCompare]));

        }else if (lvl == 2)
        {
            Terminal.WriteLine("Level " + lvl + ": " + StringExtension.Anagram(lvl2[toCompare]));
        }
        else if (lvl == 3)
        {
            Terminal.WriteLine("Level " + lvl + ": " + StringExtension.Anagram(lvl3[toCompare]));
        }
        Terminal.WriteLine("Enter Password: ");
    }



    // Update is called once per frame
    void Update () {
		
	}
}
