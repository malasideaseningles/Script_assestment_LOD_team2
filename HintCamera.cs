using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintCamera : MonoBehaviour
{
    [SerializeField]
    public GameObject[] targets;
    private int currentTarget;
    private int index = 0;
    private int pastIndex = 0;

    public void selectTarget()
    {
        GameObject actual = this.targets[index];
        index = this.currentTarget;
        
        while (index == this.currentTarget)
        {
            pastIndex = index;
            index = Random.Range(0, this.targets.Length);
        }
        this.gameObject.transform.localPosition = this.targets[index].GetComponent<ITarget>().getCameraPosition();
        this.gameObject.transform.localRotation = this.targets[index].GetComponent<ITarget>().getCameraRotation();
        this.currentTarget = index;

        actual = this.targets[pastIndex];
        if(actual.tag != "Encontrado"){
            actual.tag = "Untagged";
        }
        

        actual = this.targets[index];
        if(actual.tag != "Encontrado"){
            actual.tag = "Buscado";
        }

        //Debug.Log("Index: " + this.index);

    }


    void Start()
    {
        this.currentTarget = 0;
        this.selectTarget();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
