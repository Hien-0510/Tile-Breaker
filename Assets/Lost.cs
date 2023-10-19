using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lost : MonoBehaviour
{
    public GameObject panel;
 
        // Start is called before the first frame update
        private void OnTriggerEnter2D(Collider2D collider)
        {
            Time.timeScale =0;
            panel.SetActive(true);
        }
}
