using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionSound : MonoBehaviour
{
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.Play();
        Invoke(nameof(Remove), 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Remove()
    {
        Destroy(gameObject);
    }
}
