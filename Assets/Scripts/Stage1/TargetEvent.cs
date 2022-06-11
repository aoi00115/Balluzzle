using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetEvent : MonoBehaviour
{
    private GameObject button;
    private bool inTrigger;
    private GameObject buttonFloatingText;

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("Button");
        inTrigger = false;
        buttonFloatingText = GameObject.Find("ButtonText");
    }

    // Update is called once per frame
    void Update()
    {
        if(inTrigger)
        {
            button.transform.position = new Vector3(0, 0.486999989f, 2.5f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Target"))
        {
            inTrigger = true;
        }
    }
}
