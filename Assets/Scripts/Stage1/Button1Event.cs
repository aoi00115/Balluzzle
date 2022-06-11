using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1Event : MonoBehaviour
{
    private GameObject button1;
    [SerializeField]
    private GameObject gate;
    private bool gateOpen;

    // Start is called before the first frame update
    void Start()
    {
        button1 = GameObject.Find("Button1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            gateOpen = !gateOpen;
            gate.GetComponent<Animator>().SetBool("isOpen", gateOpen);
            Destroy(button1);
        }
    }
}
