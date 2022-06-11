using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonEvent : MonoBehaviour
{
    private GameObject button;
    public GameObject dingSound;
    public GameObject secondTrigger;
    public GameObject secondTriggerHint;
    private TextMeshProUGUI objective;

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("Button");
        objective = GameObject.Find("Objective").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Instantiate(dingSound, gameObject.transform.position, Quaternion.identity);
        Destroy(button);
        objective.text = "Objective : Activate the second trigger.";
        secondTrigger.transform.position = new Vector3(9.81700039f, 1.30700004f, 43.2f);
        secondTriggerHint.transform.position = new Vector3(8.53199959f, 2.48099995f, 43.4329987f);
    }
}
