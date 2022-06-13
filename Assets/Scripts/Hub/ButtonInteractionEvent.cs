using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInteractionEvent : Interactable
{
    public GameObject targetCollapseTarget;
    public GameObject targetBomberTarget;
    private GameObject targetCollapseTargetClone;
    private GameObject targetBomberTargetClone;
    private GameObject button;
    public bool targetCollapse, targetBomber;

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("Button");
    }

    void Update()
    {
        targetCollapseTargetClone = GameObject.Find("TargetCollpaseTarget(Clone)");
        targetBomberTargetClone = GameObject.Find("TargetBomberTarget(Clone)");
    }

    // Update is called once per frame
    protected override void Interact()
    {
        button.GetComponent<Animator>().SetInteger("isPushed", 1);
        Invoke(nameof(Reset), 0.2f);
        if(targetCollapse)
        {
            Destroy(targetCollapseTargetClone);
            Instantiate(targetCollapseTarget, new Vector3(3.6f, 0.7f, 138.9f), Quaternion.Euler(0, 270, 0));
        }
        if(targetBomber)
        {
            Destroy(targetBomberTargetClone);
            Instantiate(targetBomberTarget, new Vector3(143.490387f, 1.21394229f, 0.0145799909f), Quaternion.Euler(0, 0, 0));
        }
    }

    private void Reset()
    {
        button.GetComponent<Animator>().SetInteger("isPushed", 0);
    }
}
