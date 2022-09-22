using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    float m_Speed;
    // Start is called before the first frame update
    void Start()
    {
        m_Speed = 30.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,1,0)* Time.deltaTime * m_Speed);
    }
}
