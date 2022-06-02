using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Throwing : MonoBehaviour
{
    [Header("References")]
    public Transform cam;
    public Transform attackPoint;
    public Transform Player;
    private GameObject throwableObject;
    public GameObject[] objectsToThrow;
    public AudioClip throwingSound;
    AudioSource audioSource;

    [Header("Settings")]
    public int ballTotalThrows;
    public int explosiveBallTotalThrows;
    public int antiGravityBallTotalThrows;
    public int grapplingBallTotalThrows;
    public int ballisticBallTotalThrows;
    public int teleportationBallTotalThrows;
    public float throwCooldown;

    [Header("Throwing")]
    public KeyCode throwKey = KeyCode.Mouse0;
    public float throwForce;
    private float throwUpwardForce;

    [Header("Throw upward force")]
    public float normalBall;
    public float antiGravityBall;

    bool readyToThrow;

    private void Start()
    {
        readyToThrow = true;
        audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = throwingSound;
    }

    private void Update()
    {
        // throw up force in case of Anti-Gravity Ball
        if(throwableObject == objectsToThrow[2])
        {
            throwUpwardForce = antiGravityBall;
        }
        else
        {
            throwUpwardForce = normalBall;
        }

        //throw count for each ball
        //ball
        if(Input.GetKeyDown(throwKey) && readyToThrow && ballTotalThrows > 0 && throwableObject == objectsToThrow[0])
        {
            Throw();
            ballTotalThrows--;
        }

        //explosive ball
        if(Input.GetKeyDown(throwKey) && readyToThrow && explosiveBallTotalThrows > 0 && throwableObject == objectsToThrow[1])
        {
            Throw();
            explosiveBallTotalThrows--;
        }

        //anti-gravity ball
        if(Input.GetKeyDown(throwKey) && readyToThrow && antiGravityBallTotalThrows > 0 && throwableObject == objectsToThrow[2])
        {
            Throw();
            antiGravityBallTotalThrows--;
        }

        //grappling ball
        if(Input.GetKeyDown(throwKey) && readyToThrow && grapplingBallTotalThrows > 0 && throwableObject == objectsToThrow[3])
        {
            Throw();
            grapplingBallTotalThrows--;
        }


        //ballistic ball
        if(Input.GetKeyDown(throwKey) && readyToThrow && ballisticBallTotalThrows > 0 && throwableObject == objectsToThrow[4])
        {
            Throw();
            ballisticBallTotalThrows--;
        }

        //teleportation ball
        if(Input.GetKeyDown(throwKey) && readyToThrow && teleportationBallTotalThrows > 0 && throwableObject == objectsToThrow[5])
        {
            Throw();
            teleportationBallTotalThrows--;
        }

        //ball select
        for(int i = 1; i <= objectsToThrow.Length; i++)
		{
			if(Input.GetKeyDown(i.ToString()))
			{
				throwableObject = objectsToThrow[i - 1];
			}
		}
    }

    private void Throw()
    {
        readyToThrow = false;

        audioSource.Play();

        // instantiate object to throw
        GameObject projectile = Instantiate(throwableObject, attackPoint.position, cam.rotation);

        // get rigidbody component
        Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();

        // calculate direction
        Vector3 forceDirection = cam.transform.forward;

        RaycastHit hit;

        if(Physics.Raycast(cam.position, cam.forward, out hit, 500f))
        {
            forceDirection = (hit.point - attackPoint.position).normalized;
        }

        // add force
        Vector3 forceToAdd = forceDirection * throwForce + transform.up * throwUpwardForce;

        projectileRb.velocity = Player.GetComponent<Rigidbody>().velocity;

        projectileRb.AddForce(forceToAdd, ForceMode.Impulse);

        // implement throwCooldown
        Invoke(nameof(ResetThrow), throwCooldown);
    }

    private void ResetThrow()
    {
        readyToThrow = true;
    }
}