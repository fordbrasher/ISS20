using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteRadioObjectiveTriggerButton : MonoBehaviour
{
    [SerializeField] private ObjectiveSetActive objective;
    private BasicMovement[] thePlayers;
    private BasicMovement thePlayer1;
    private BasicMovement thePlayer2;

    private BasicMovement found;

    public Transform placeRadio;
 

    void Start()
    {
        thePlayers = FindObjectsOfType<BasicMovement>();
        int length = thePlayers.Length;
        thePlayer1 = thePlayers[0];
        thePlayer2 = thePlayers[1];

        objective.IncompleteObjective();
    }

    void Update()
    {
    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("Bob"))
        {
            if (thePlayer1.followingRadio != null)
            {
                objective.CompleteObjective();
                thePlayer1.followingRadio.followTarget = placeRadio;
         
                
                
            }
        }
        if (other.tag == ("Doug"))
        {
            if (thePlayer2.followingRadio != null)
            {
                objective.CompleteObjective();
                thePlayer2.followingRadio.followTarget = placeRadio;



            }
        }
    }

}
