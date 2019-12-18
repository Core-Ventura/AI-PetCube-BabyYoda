using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetController : MonoBehaviour
{
    public Transform goal;
    public float speed = 0.5f; //ajustar para la animacion
    public float acc = 1.0f;
    public float rotSpeed = 0.5f;

    void LateUpdate() 
    {
        Vector3 lookAtGoal = new Vector3(goal.position.x, 
                                        this.transform.position.y,
                                        goal.position.z);
        Vector3 direction = lookAtGoal - this.transform.position;
        
        if (Vector3.Distance(transform.position, lookAtGoal) > acc){

            //Rotate pet
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, 
                                            Quaternion.LookRotation(direction), 
                                            Time.deltaTime*rotSpeed);

            //Move pet
            this.transform.Translate(0,0,speed*Time.deltaTime);
        }
  
    }
}