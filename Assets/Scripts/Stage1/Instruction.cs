using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Instruction : MonoBehaviour
{
    private TextMeshProUGUI instructionText;

    // Start is called before the first frame update
    void Start()
    {
        instructionText = GameObject.Find("InstructionText").GetComponent<TextMeshProUGUI>();
        instructionText.text = "Press [1] to equip the Ball";
    }

    // Update is called once per frame
    void Update()
    {
        if(instructionText.text == "Press [1] to equip the Ball")
        {
            if(Input.GetKeyDown("1"))
            {
                instructionText.text = "Press [Left Mouse Button] to throw the Ball";
            }
        }

        if(instructionText.text == "Press [Left Mouse Button] to throw the Ball")
        {
            if(Input.GetKeyDown(KeyCode.Mouse0))
            {
                instructionText.text = "";
            }
        }
    }
}
