using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            Player.Instance.AddBalls();
            Destroy(this.gameObject);
        }
        
    }

    
    private void Update()
    {
        transform.Rotate( new Vector3(0, 1, 0) );
    }
}
    