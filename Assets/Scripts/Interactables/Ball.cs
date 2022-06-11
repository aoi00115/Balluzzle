using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : Interactable
{
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interact()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        audioSource.Play();
    }
}
