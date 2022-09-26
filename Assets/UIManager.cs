using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;
    public Text BallText;

    public static UIManager Instance{
        get{
            if(_instance == null) {
                Debug.Log("UIManager is null");
            }
            
            return _instance;
        }
    }

    void Awake() {
        _instance = this;
    }

    public void UpdateBallText(int balls) {
        BallText.text = "Dragon Balls: " + balls;
    }
}
