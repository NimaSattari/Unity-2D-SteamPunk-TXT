using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdvantureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;

    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }


    void Update()
    {
        ManageState();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();

        for(int i = 0; i < nextStates.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                state = nextStates[i];
            }
        }

        textComponent.text = state.GetStateStory();
    }
}
