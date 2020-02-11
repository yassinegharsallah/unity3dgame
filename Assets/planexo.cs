using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planexo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       //Create a new cube primitive to set the color on

       //Get the Renderer component from the new cube
       var cubeRenderer = this.GetComponent<Renderer>();
 var cubeRenderer2 =  GameObject.FindWithTag("cubexo").GetComponent<Renderer>() ;
 var cubeRenderer3 =  GameObject.FindWithTag("cubexo2").GetComponent<Renderer>() ;

      switch (Random.Range(0, 3))
        {
        case 0:
       cubeRenderer.material.SetColor("_Color", Color.cyan);
       cubeRenderer2.material.SetColor("_Color", Color.cyan);

            break;
        case 1:
      cubeRenderer.material.SetColor("_Color", Color.magenta);
    cubeRenderer3.material.SetColor("_Color", Color.magenta);
            break;
        case 2:
      cubeRenderer.material.SetColor("_Color", Color.yellow);
             cubeRenderer2.material.SetColor("_Color", Color.yellow);
            break;
        default:
      cubeRenderer.material.SetColor("_Color", Color.red);
            break;
        } 

    }

    // Update is called once per frame
    void Update()
    {   

    }  
}
