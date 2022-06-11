using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSelection : MonoBehaviour
{
    private Vector3 originalScale;
    private Vector3 scaleChange;
    public GameObject ballCountText;
    public GameObject explosiveBallCountText;
    public GameObject antiGravityBallCountText;
    public GameObject grapplingBallCountText;
    public GameObject ballisticBallCountText;
    public GameObject teleportationBallCountText;
    public Throwing throwScript; 

    // Start is called before the first frame update
    void Awake()
    {
        throwScript = GameObject.Find("Player").GetComponent<Throwing>();
    }

    void Start()
    {
        originalScale = new Vector3(0.15f, 0.15f, 0.15f);
        scaleChange = new Vector3(0.20f, 0.20f, 0.20f);
    }

    // Update is called once per frame
    void Update()
    {

        if(throwScript.ballTotalThrows == 0)
        {
            ballCountText.SetActive(false);
        }
        if(throwScript.explosiveBallTotalThrows == 0)
        {
            explosiveBallCountText.SetActive(false);
        }
        if(throwScript.antiGravityBallTotalThrows == 0)
        {
            antiGravityBallCountText.SetActive(false);
        }
        if(throwScript.grapplingBallTotalThrows == 0)
        {
            grapplingBallCountText.SetActive(false);
        }
        if(throwScript.ballisticBallTotalThrows == 0)
        {
            ballisticBallCountText.SetActive(false);
        }
        if(throwScript.teleportationBallTotalThrows == 0)
        {
            teleportationBallCountText.SetActive(false);
        }

        for(int i = 1; i <= 6; i++)
		{
			if(Input.GetKeyDown(i.ToString()))
			{
                if(i == 1)
                {
                    ballCountText.transform.localScale = scaleChange;
                    explosiveBallCountText.transform.localScale = originalScale;
                    antiGravityBallCountText.transform.localScale = originalScale;
                    grapplingBallCountText.transform.localScale = originalScale;
                    ballisticBallCountText.transform.localScale = originalScale;
                    teleportationBallCountText.transform.localScale = originalScale;
                }
                if(i == 2)
                {
                    ballCountText.transform.localScale = originalScale;
                    explosiveBallCountText.transform.localScale = scaleChange;
                    antiGravityBallCountText.transform.localScale = originalScale;
                    grapplingBallCountText.transform.localScale = originalScale;
                    ballisticBallCountText.transform.localScale = originalScale;
                    teleportationBallCountText.transform.localScale = originalScale;
                }
                if(i == 3)
                {
                    ballCountText.transform.localScale = originalScale;
                    explosiveBallCountText.transform.localScale = originalScale;
                    antiGravityBallCountText.transform.localScale = scaleChange;
                    grapplingBallCountText.transform.localScale = originalScale;
                    ballisticBallCountText.transform.localScale = originalScale;
                    teleportationBallCountText.transform.localScale = originalScale;
                }
                if(i == 4)
                {
                    ballCountText.transform.localScale = originalScale;
                    explosiveBallCountText.transform.localScale = originalScale;
                    antiGravityBallCountText.transform.localScale = originalScale;
                    grapplingBallCountText.transform.localScale = scaleChange;
                    ballisticBallCountText.transform.localScale = originalScale;
                    teleportationBallCountText.transform.localScale = originalScale;
                }
                if(i == 5)
                {
                    ballCountText.transform.localScale = originalScale;
                    explosiveBallCountText.transform.localScale = originalScale;
                    antiGravityBallCountText.transform.localScale = originalScale;
                    grapplingBallCountText.transform.localScale = originalScale;
                    ballisticBallCountText.transform.localScale = scaleChange;
                    teleportationBallCountText.transform.localScale = originalScale;
                }
                if(i == 6)
                {
                    ballCountText.transform.localScale = originalScale;
                    explosiveBallCountText.transform.localScale = originalScale;
                    antiGravityBallCountText.transform.localScale = originalScale;
                    grapplingBallCountText.transform.localScale = originalScale;
                    ballisticBallCountText.transform.localScale = originalScale;
                    teleportationBallCountText.transform.localScale = scaleChange;
                }
			}
		}
    }
}
