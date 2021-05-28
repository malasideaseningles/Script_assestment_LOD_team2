using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectClicker : MonoBehaviour
{
    [SerializeField]
    private GameObject hintCamera;

    public int NumberOfObjects;
    int puntos;

    void Start()
    {
        this.puntos = 0;
        Debug.Log("Find " + NumberOfObjects + " objects to win!");
    }

    private void Update(){
        if(Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, 100.0f)){
                if(hit.transform != null){
                    if(hit.transform.gameObject.tag == "Buscado"){
                        puntos += 1;
                        Debug.Log("Object found! Score =" + puntos);
                        hit.transform.gameObject.tag = "Untagged";
                        hintCamera.GetComponent<HintCamera>().selectTarget();
                        //Destroy(hit.transform.gameObject, 0.5f);
                    }
                }
            }
            if(puntos == NumberOfObjects){
                Debug.Log("You have reached the max score. Congratulations!");
            }
        }
        
    }

    private void PrintName(GameObject go){
        print(go.name);
    }

    
}
