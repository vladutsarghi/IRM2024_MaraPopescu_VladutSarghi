using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distance : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    private float distanc;

    public Animator characterAnimator1;
    public Animator characterAnimator2;


    void Update()
    {
       
         distanc = Vector3.Distance(object1.transform.position, object2.transform.position);
         Debug.Log("Distance: " + distanc);

         if (distanc < 0.25f)
         {
           Debug.Log("Objects are close!");
              
             characterAnimator1.SetBool("state", true);
         characterAnimator2.SetBool("attack", true);

         }
         else
         {
          Debug.Log("Distanta prea mare ");

          characterAnimator1.SetBool("state", false);
          characterAnimator2.SetBool("attack", false);

         }

    }

}


     

    
