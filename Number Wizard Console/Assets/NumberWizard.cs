using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame() 
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to number wizard!");
        Debug.Log("Please pick a nubmer!");
        Debug.Log("The maximum number is: " + max);
        Debug.Log("The minimum number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push up = higher, push down = lower, push enter = correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Debug.Log("Up Arrow key was pressed.");
                min = guess;
                NextGuess();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Debug.Log("Down Arrow key was pressed.");
                max = guess;
                NextGuess();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log("Enter key was pressed.");
                StartGame();
            }
            else
            {
                Debug.Log("Invalid input");
            }
        }
    }

    void NextGuess() 
    {
        guess = (max + min) / 2;
        Debug.Log("Tell me if your number is higher or lower than " + guess);
    }
}
