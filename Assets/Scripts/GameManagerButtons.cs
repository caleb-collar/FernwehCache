using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerButtons : MonoBehaviour
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
        QuitProgram();
    }

    void QuitProgram()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }

    public void Option1Click()
    {
        var nextStates = currentState.GetNextStates();
        currentState = nextStates[0];
        textComponent.text = currentState.GetStoryText();
    }
    
    public void Option2Click()
    {
        var nextStates = currentState.GetNextStates();
        currentState = nextStates[1];
        textComponent.text = currentState.GetStoryText();
    }
}
