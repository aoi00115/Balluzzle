using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SecondTriggerEvent : MonoBehaviour
{
    public GameObject dingSound;
    private GameObject secondTriggerHint;
    private GameObject antiGravityBall;
    private GameObject window3;
    private GameObject thirdTrigger;
    private TextMeshProUGUI objective;

    // Start is called before the first frame update
    void Start()
    {
        secondTriggerHint = GameObject.Find("SecondTriggerHint");
        antiGravityBall = GameObject.Find("AntiGravityBall");
        window3 = GameObject.Find("Window3");
        thirdTrigger = GameObject.Find("ThirdTrigger");
        objective = GameObject.Find("Objective").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(dingSound, gameObject.transform.position, Quaternion.identity);
        antiGravityBall.transform.position = new Vector3(8.96903133f, 2.67700005f, 42);
        thirdTrigger.transform.position = new Vector3(-24.2999992f, 40.3300018f, 23.1523266f); 
        objective.text = "Objective : Activate the third trigger.";
        Destroy(window3);
        Destroy(secondTriggerHint);
        Destroy(gameObject);
    }
}
