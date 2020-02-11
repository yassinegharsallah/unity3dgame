using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinderScript : MonoBehaviour
{   
    bool isTouched = false;
    bool isTouched2 = false;
    bool isFollow = false;
    string Loser = "";

   // Start is called before the first frame update
    void Start()
    {        

    }
    
void OnCollisionEnter(Collision collision) 
 {       
         if(collision.gameObject.tag == "mywall")  // or if(gameObject.CompareTag("YourWallTag"))
         {
                  Debug.Log("entered");
          Vector3 position = this.transform.position;
          position.z--;
          this.transform.position = position;
         }
        
        if(collision.gameObject.tag == "cubexo")  // or if(gameObject.CompareTag("YourWallTag"))
         {    
             isTouched = true ;
             if (Loser == "sayabt")
             {
                 isTouched =false;
             }
            Debug.Log("Touched the cube");
         }  

          if(collision.gameObject.tag == "cubexo2")  // or if(gameObject.CompareTag("YourWallTag"))
         {    
             isTouched2 = true ;
             if (Loser == "sayabt2")
             {
                 isTouched2 =false;
             }
            Debug.Log("Touched the cube");
         }  


 }

 
    // Update is called once per frame
    void Update()
    {


      
if (Input.GetKeyDown(KeyCode.LeftArrow))
{
    Vector3 position = this.transform.position;
    position.x--;
    this.transform.position = position;   
     if (isTouched == true)
     {
   GameObject.FindWithTag("cubexo").transform.position =  position ;
     }
    if (isTouched2 == true)
     {
   GameObject.FindWithTag("cubexo2").transform.position =  position ;
     }
}
if (Input.GetKeyDown(KeyCode.RightArrow))
{
    Vector3 position = this.transform.position;
    position.x++;
    this.transform.position = position;
         if (isTouched == true)
     {
   GameObject.FindWithTag("cubexo").transform.position =  position ;
     }
              if (isTouched2 == true)
     {
   GameObject.FindWithTag("cubexo2").transform.position =  position ;
     }
}
if (Input.GetKeyDown(KeyCode.UpArrow))
{
    Vector3 position = this.transform.position;
    position.z++;
    this.transform.position = position;
         if (isTouched == true)
     {
   GameObject.FindWithTag("cubexo").transform.position =  position ;
     }
              if (isTouched2 == true)
     {
   GameObject.FindWithTag("cubexo2").transform.position =  position ;
     }
}
if (Input.GetKeyDown(KeyCode.DownArrow))
{
    Vector3 position = this.transform.position;
    position.z--;
    this.transform.position = position;
         if (isTouched == true)
     {
   GameObject.FindWithTag("cubexo").transform.position =  position ;
     }
              if (isTouched2 == true)
     {
   GameObject.FindWithTag("cubexo2").transform.position =  position ;
     }
}   
     
    /* check if the player touched the cube */
    if(Input.GetKeyDown(KeyCode.Space) && isTouched == true){
       Debug.Log("BACK SPACE AND  TOUCH");

    }
    /* check if the player touched the cube */ 
    
   /* check if the player abandonned the cube */
    if(Input.GetKeyUp(KeyCode.Space) && isTouched == true){
      
       Debug.Log("BACK SPACE UP AND IS TOUCHED IS FALSE NOW ");
               GameObject.FindWithTag("cubexo2").transform.position =  this.transform.position ;
          Loser = "sayabt" ;  
    }
   /*  check if the player abondonned the cube */ 

       /* check if the player touched the cube */
    if(Input.GetKeyDown(KeyCode.Space) && isTouched2 == true){
       Debug.Log("BACK SPACE AND  TOUCH");

    }
    /* check if the player touched the cube */ 
    
   /* check if the player abandonned the cube */
    if(Input.GetKeyUp(KeyCode.Space) && isTouched2 == true){
       Debug.Log("BACK SPACE UP AND IS TOUCHED IS FALSE NOW ");
          Loser = "sayabt2" ;  
    }
   /*  check if the player abondonned the cube */ 
     
 //IA FOLLOW 
   if(this.transform.position.z > 0.66f){
    isFollow = true ;
   }
 //IA FOLLOW 
if(isFollow == true){
GameObject.FindWithTag("ennemi").transform.position = Vector3.MoveTowards(GameObject.FindWithTag("ennemi").transform.position ,  this.transform.position ,0.2f * Time.deltaTime);
  }
 //color compare 



 //color compare
    }
}
