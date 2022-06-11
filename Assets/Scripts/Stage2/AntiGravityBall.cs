using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiGravityBall : Interactable
{
    private Throwing throwScript;
    public GameObject antiGravityBallCountText;

    // Start is called before the first frame update
    void Start()
    {
        throwScript = GameObject.Find("Player").GetComponent<Throwing>();
        antiGravityBallCountText = GameObject.Find("Anti-GravityBallCountText");
    }

    void Update()
    {
        
        
    }

    // Update is called once per frame
    protected override void Interact()
    {
        throwScript.antiGravityBallTotalThrows++;
        antiGravityBallCountText.SetActive(true);
        Destroy(gameObject);
    }
}
