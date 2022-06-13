using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1InteractionEvent : Interactable
{
    private GameObject button1;
    private GameObject player;
    private Throwing throwScript;

    // Start is called before the first frame update
    void Start()
    {
        button1 = GameObject.Find("Button1");
        player = GameObject.Find("Player");
        throwScript = GameObject.Find("Player").GetComponent<Throwing>();
    }

    void Update()
    {

    }

    // Update is called once per frame
    protected override void Interact()
    {
        button1.GetComponent<Animator>().SetInteger("isPushed", 1);
        Invoke(nameof(Reset), 0.2f);
        player.transform.position = new Vector3(0, 0.5f, 0);
        throwScript.ballTotalThrows = 0;
        throwScript.explosiveBallTotalThrows = 0;
    }

    private void Reset()
    {
        button1.GetComponent<Animator>().SetInteger("isPushed", 0);
    }
}
