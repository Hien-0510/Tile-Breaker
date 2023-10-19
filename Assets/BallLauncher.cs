using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    public float LaunchingForce;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            LaunchTheBall();
        }
    }

    private void LaunchTheBall(){
        transform.SetParent(null);
        float angle = Random.Range(-80,80);
        GetComponent<Rigidbody2D>().velocity = Quaternion.Euler(0,0,angle) * Vector3.up * LaunchingForce;
    }
}
