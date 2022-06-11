using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallInteractEvent : Interactable
{
    private TextMeshProUGUI objective;

    // Start is called before the first frame update
    void Start()
    {
        objective = GameObject.Find("Objective").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        
        
    }

    // Update is called once per frame
    protected override void Interact()
    {
        objective.text = "Objective : Activate the first trigger.";
    }
}
