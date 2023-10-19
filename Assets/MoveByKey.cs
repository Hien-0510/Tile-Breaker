using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByKey : MonoBehaviour
{
    
    public float speed;
    public float minX,maxX;
    void Update()
    {
        float step = speed * Time.deltaTime;
        if(Input.GetKey(KeyCode.LeftArrow) && transform.position.x > minX)
        {
            transform.Translate(-step, 0, 0);
        }
        else if(Input.GetKey(KeyCode.RightArrow) && transform.position.x < maxX){
            transform.Translate(step,0,0);
        }
    }
}
