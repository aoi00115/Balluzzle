using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : Interactable
{
    [SerializeField]
    private GameObject gate;
    [SerializeField]
    private GameObject button;
    private bool gateOpen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interact()
    {
        gateOpen = !gateOpen;
        gate.GetComponent<Animator>().SetBool("isOpen", gateOpen);
        button.GetComponent<Animator>().SetTrigger("push");
    }
}
