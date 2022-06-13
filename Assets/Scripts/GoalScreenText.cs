using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalScreenText : MonoBehaviour
{
    private TextMeshProUGUI goalText;
    public float timeElapsed;

    // Start is called before the first frame update
    void Start()
    {
        goalText = GameObject.Find("GoalText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;

        if(timeElapsed <= 5.0f)
        {
            goalText.text = "Thank you for playing!";
        }
        if(timeElapsed <= 10.0f && timeElapsed >= 5.0f )
        {
            goalText.text = "This is a demo buid";
        }
        if(timeElapsed <= 15.0f && timeElapsed >= 10.0f )
        {
            goalText.text = "and levels are to be updated";
        }
        if(timeElapsed <= 20.0f && timeElapsed >= 15.0f )
        {
            goalText.text = "Press M to return to main menu.";
        }
    }
}
