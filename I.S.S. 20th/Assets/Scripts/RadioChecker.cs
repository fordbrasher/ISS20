using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioChecker : MonoBehaviour
{
    public Radio radio1;
    public Radio radio2;
    public Radio radio3;

    public GameUI gameUI;

    public void FixedUpdate()
    {
        if (radio1.IsFollowing())
        {
            if (radio2.IsFollowing())
            {
                if (radio3.IsFollowing())
                    gameUI.GameOver();
            }
        }
    }
}
