using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text ballCountText;
    public Text explosiveBallCountText;
    public Text antiGravityBallCountText;    
    public Text grapplingBallCountText;
    public Text ballisticBallCountText;
    public Text teleportationBallCountText;
    public Throwing throwScript;

    private void Awake()
    {
        throwScript = GameObject.Find("Player").GetComponent<Throwing>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ballCountText.text = "X " + throwScript.ballTotalThrows.ToString("f0");
        explosiveBallCountText.text = "X " + throwScript.explosiveBallTotalThrows.ToString("f0");
        antiGravityBallCountText.text = "X " + throwScript.antiGravityBallTotalThrows.ToString("f0");        
        grapplingBallCountText.text = "X " + throwScript.grapplingBallTotalThrows.ToString("f0");
        ballisticBallCountText.text = "X " + throwScript.ballisticBallTotalThrows.ToString("f0");
        teleportationBallCountText.text = "X " + throwScript.teleportationBallTotalThrows.ToString("f0");
    }

    public void SinglePlayerButton()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void ExtraButton()
    {
        SceneManager.LoadScene("Hub");
    }
}
