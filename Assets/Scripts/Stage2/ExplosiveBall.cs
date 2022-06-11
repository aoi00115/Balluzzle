using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveBall : Interactable
{
    private Throwing throwScript;
    private GameObject explosiveBallCountText;

    // Start is called before the first frame update
    void Start()
    {
        throwScript = GameObject.Find("Player").GetComponent<Throwing>();
        explosiveBallCountText = GameObject.Find("ExplosiveBallCountText");
    }

    void Update()
    {
        
        
    }

    // Update is called once per frame
    protected override void Interact()
    {
        throwScript.explosiveBallTotalThrows = 5;
        explosiveBallCountText.SetActive(true);
        Destroy(gameObject);
    }
}
