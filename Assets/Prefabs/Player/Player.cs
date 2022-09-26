using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _balls;
    private static Player _instance;
    public static Player Instance
    {
        get{
            if(_instance == null) {
                Debug.Log("PLayer is null");
            }
            
            return _instance;
        }
    }


    private void Start()
    {
        _balls = 0;
    }
    private void Awake()
    {
        _instance = this;
    }

    public void AddBalls() {
        _balls++;
    }


    private void Update()
    {
        UIManager.Instance.UpdateBallText(_balls);
    }
}
