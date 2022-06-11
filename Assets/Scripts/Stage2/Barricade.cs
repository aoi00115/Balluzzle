using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barricade : Interactable
{
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
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("ExplosiveBall"))
        {
            gameObject.AddComponent<Rigidbody>().AddForceAtPosition(new Vector3(0 ,-1f, -3) * 10 + Vector3.up * 10, new Vector3(0,-0.5f,0), ForceMode.Impulse);;
        }
    }
}
