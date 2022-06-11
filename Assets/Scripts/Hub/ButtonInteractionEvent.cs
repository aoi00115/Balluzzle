using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInteractionEvent : Interactable
{
    public GameObject target;
    private GameObject targetClone;
    private GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("Button");
    }

    void Update()
    {
        targetClone = GameObject.Find("Target(Clone)");
    }

    // Update is called once per frame
    protected override void Interact()
    {
        button.GetComponent<Animator>().SetInteger("isPushed", 1);
        Invoke(nameof(Reset), 0.2f);
        Destroy(targetClone);
        Instantiate(target, new Vector3(3.6f, 0.7f, 138.9f), Quaternion.Euler(0, 270, 0));
    }

    private void Reset()
    {
        button.GetComponent<Animator>().SetInteger("isPushed", 0);
    }
}
