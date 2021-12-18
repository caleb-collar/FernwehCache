using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State currentState;
    
    // Start is called before the first frame update
    void Start()
    {
        currentState = startingState;
        textComponent.text = currentState.GetStoryText();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
        QuitProgram();
    }

    void QuitProgram()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }

    void ManageState()
    {
        var nextStates = currentState.GetNextStates();
        for (int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                currentState = nextStates[index];
            }
        }

        textComponent.text = currentState.GetStoryText();
    }
}
