using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TeleportTrigger : MonoBehaviour
{
    public bool targetCollapse;
    public bool targetSnipe;
    public bool targetBomber;
    public bool stage2Clear;
    private GameObject player;
    private GameObject ballCountText;
    private Vector3 targetCollapseCoordinate;
    private Throwing throwScript;
    private TextMeshProUGUI objective;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        throwScript = GameObject.Find("Player").GetComponent<Throwing>();
        ballCountText = GameObject.Find("BallCountText");
        targetCollapseCoordinate = new Vector3(0, 1.5f, 131.5f);
        objective = GameObject.Find("Objective").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if(targetCollapse)
            {
                throwScript.ballTotalThrows = 0;
                throwScript.ballTotalThrows = 10;
                ballCountText.SetActive(true);
                player.transform.position = targetCollapseCoordinate;
            }

            if(stage2Clear)
            {
                objective.text = "";
                SceneManager.LoadScene("GoalScreen");
            }
        }
    }
}
