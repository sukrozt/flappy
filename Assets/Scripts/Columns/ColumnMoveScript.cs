using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnMoveScript : MonoBehaviour
{
    public float moveSpeed = 1;

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed);

       /* if(transform.position.x < deadZone){

            Debug.Log("Column Deleted");
            Destroy(gameObject);
        }*/
    }
}
