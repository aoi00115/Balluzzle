using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    public Transform playerCam;
    public Throwing throwScript;
    public RaycastHit hitInfo;
    public GameObject ballCountText;
    public GameObject explosiveBallCountText;
    public GameObject antiGravityBallCountText;
    public GameObject grapplingBallCountText;
    public GameObject ballisticBallCountText;
    public GameObject teleportationBallCountText;

    [Header("Settings")]
    public float pickUpRange;
    private PlayerInteract playerInteract;

    private void Awake()
    {
        throwScript = GameObject.Find("Player").GetComponent<Throwing>();
        playerInteract = GameObject.Find("Player").GetComponent<PlayerInteract>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(playerInteract.interactKey))
        {
            Ray pickUpRay = new Ray(playerCam.transform.position, playerCam.transform.forward);
            if(Physics.Raycast(pickUpRay, out hitInfo, pickUpRange))
            {
                if(hitInfo.collider.tag == "Ball")
                {
                    PickUp();
                    Destroy(hitInfo.transform.gameObject);
                    ballCountText.SetActive(true);
                }
                if(hitInfo.collider.tag == "ExplosiveBall")
                {
                    PickUp();
                    Destroy(hitInfo.transform.gameObject);
                    explosiveBallCountText.SetActive(true);
                }
                if(hitInfo.collider.tag == "AntiGravityBall")
                {
                    PickUp();
                    Destroy(hitInfo.transform.gameObject);
                    antiGravityBallCountText.SetActive(true);
                }
                if(hitInfo.collider.tag == "GrapplingBall")
                {
                    PickUp();
                    Destroy(hitInfo.transform.gameObject);
                    grapplingBallCountText.SetActive(true);
                }
                if(hitInfo.collider.tag == "BallisticBall")
                {
                    PickUp();
                    Destroy(hitInfo.transform.gameObject);
                    ballisticBallCountText.SetActive(true);
                }
                if(hitInfo.collider.tag == "TeleportationBall")
                {
                    PickUp();
                    Destroy(hitInfo.transform.gameObject);
                    teleportationBallCountText.SetActive(true);
                }
            }
        } 
    }

    private void PickUp()
    {
        if(hitInfo.collider.tag == "Ball")
        {
            throwScript.ballTotalThrows++;
        }
        if(hitInfo.collider.tag == "ExplosiveBall")
        {
            throwScript.explosiveBallTotalThrows++;
        }
        if(hitInfo.collider.tag == "AntiGravityBall")
        {
            throwScript.antiGravityBallTotalThrows++;
        }
        if(hitInfo.collider.tag == "GrapplingBall")
        {
            throwScript.grapplingBallTotalThrows++;
        }
        if(hitInfo.collider.tag == "BallisticBall")
        {
            throwScript.ballisticBallTotalThrows++;
        }
        if(hitInfo.collider.tag == "TeleportationBall")
        {
            throwScript.teleportationBallTotalThrows++;
        }
    }
}
