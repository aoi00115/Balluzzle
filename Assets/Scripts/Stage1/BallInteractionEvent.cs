using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallInteractionEvent : Interactable
{
    private GameObject pedestal;
    private GameObject player;
    public GameObject rangeTable;
    public GameObject target;
    public GameObject dingSound;
    public GameObject instructionEntity;

    // Start is called before the first frame update
    void Start()
    {
        pedestal = GameObject.Find("Pedestal");
        player = GameObject.Find("Player");
        target = GameObject.Find("Target1");
        rangeTable = GameObject.Find("RangeTable");
    }

    // Update is called once per frame
    void Update()
    {

    }

    protected override void Interact()
    {
        Destroy(pedestal);
        if(player.transform.position.z > 2.5f)
        {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, 0);
        }
        target.transform.position = new Vector3(0, 0.5f, 1.27199996f);
        rangeTable.transform.position = new Vector3(0, 0.45f, 2.5f);
        Instantiate(dingSound, gameObject.transform.position, Quaternion.identity);
        Instantiate(instructionEntity, new Vector3(0, -10, 0), Quaternion.identity);
    }
}
