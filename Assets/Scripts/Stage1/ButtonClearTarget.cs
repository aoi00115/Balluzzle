using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClearTarget : Interactable
{
    private GameObject target;
    private GameObject button;
    private GameObject buttonFloatingText;
    private GameObject button1;

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("Button");
        button1 = GameObject.Find("Button1");
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.Find("Target1");
    }

    protected override void Interact()
    {
        button1.transform.position = new Vector3(0, 1.92999995f, 13.46f);
        Destroy(target);
        button.GetComponent<Animator>().SetInteger("isPushed", 1);
        Invoke(nameof(Reset), 0.2f);
        Invoke(nameof(DestroyButton), 1);
    }

    private void DestroyButton()
    {
        Destroy(button);
    }

    private void Reset()
    {
        button.GetComponent<Animator>().SetInteger("isPushed", 0);
    }
}
