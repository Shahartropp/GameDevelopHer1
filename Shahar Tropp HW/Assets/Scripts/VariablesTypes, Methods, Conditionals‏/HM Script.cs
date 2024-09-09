using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        SmoothOperator();
        IfIntiger();
        SwitchingIsGreat();
    }

    void SmoothOperator()
    {
        // user has entered an input
        int userInput = 4;
        Debug.Log($"your number's worth {userInput * 2} when doubled");
    }

    void IfIntiger()
    {
        // user has entered an input
        int userInput = 4;

        if (userInput < 0)
        {
            Debug.Log("Your number should be greater than 0");
        }
        else
        {
            Debug.Log("Now you can start the game");
        }

    }
//could improve it by accepting the input like so : SwitchingIsGreat(int userInput)
    void SwitchingIsGreat()
    {
        // user has entered an input
        int userInput = 4;

        switch (userInput)
        {
            case 1:
                Debug.Log("case 1");
                break;
            case 2:
                Debug.Log("case 2");
                break;
            default:
                Debug.Log("not sure I understood");
                break;
        }
    }
}
