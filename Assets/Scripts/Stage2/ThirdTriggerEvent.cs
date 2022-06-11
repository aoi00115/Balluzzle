using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ThirdTriggerEvent : MonoBehaviour
{
    private GameObject thirdTrigger;
    private GameObject hiddenWall;
    public GameObject dingSound;
    public GameObject barricade;
    private GameObject explosiveBall;
    private TextMeshProUGUI objective;

    // Start is called before the first frame update
    void Start()
    {
        thirdTrigger = GameObject.Find("ThirdTrigger");
        hiddenWall = GameObject.Find("HiddenWall");
        explosiveBall = GameObject.Find("ExplosiveBall");
        objective = GameObject.Find("Objective").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Instantiate(dingSound, gameObject.transform.position, Quaternion.identity);
        Instantiate(barricade, new Vector3(-4.0999999f, 2.08999991f, 43.4440002f), Quaternion.identity);
        explosiveBall.transform.position = new Vector3(9.4829998f, 1.12400002f, 21.4580002f);
        objective.text = "Objective : Escape.";
        Destroy(hiddenWall);
        Destroy(thirdTrigger);
    }
}
