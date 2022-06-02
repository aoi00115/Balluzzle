using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    public LayerMask pickUpLayer;
    public Transform playerCam;
    public Throwing throwScript;
    public RaycastHit hitInfo;

    [Header("Settings")]
    public float pickUpRange;
    public KeyCode pickUpKey = KeyCode.F;

    private void Awake()
    {
        throwScript = GameObject.Find("Player").GetComponent<Throwing>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(pickUpKey))
        {
            Ray pickUpRay = new Ray(playerCam.transform.position, playerCam.transform.forward);
            if(Physics.Raycast(pickUpRay, out hitInfo, pickUpRange, pickUpLayer))
            {
                PickUp();
                Destroy(hitInfo.transform.gameObject);
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
