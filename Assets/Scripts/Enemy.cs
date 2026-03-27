using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
   public GameObject cannon;

    public float rotationSpeed;
    private bool rotateBack;
    



    



    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Vector3 targetPosition = new Vector3(other.transform.position.x, cannon.transform.position.y, other.transform.position.z);
            Quaternion targetRotation = Quaternion.LookRotation(targetPosition - cannon.transform.position);

            targetRotation *= Quaternion.Euler(0, 180, 0);

            // Gradually rotate towards the player
            cannon.transform.rotation = Quaternion.RotateTowards(cannon.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);


            float angle = Quaternion.Angle(cannon.transform.rotation, targetRotation);

            // Fire if within angle threshold
            // if (angle < firingAngleThreshold && timeSinceLastShot >= timeBetweenShots)
            // {
            //     FireCannon();
            //     timeSinceLastShot = 0f;
            // }
        }
    }



    private void OnTriggerExit(Collider other)
    {
        // if (other.tag == "Player")
        // {
        //     rotateBack = true;
        // }
    }



    void LateUpdate()
    {
        if (rotateBack)
        {
            Quaternion forward = Quaternion.Euler(0, 180, 0);
            if (Quaternion.Angle(cannon.transform.localRotation, forward) > 0.1f)
            {
                cannon.transform.localRotation = Quaternion.RotateTowards(cannon.transform.localRotation, forward, rotationSpeed * Time.deltaTime);
            }
            else
            {
                rotateBack = false;
            }
        }
    }



    
}
