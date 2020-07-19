using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveSetActive : MonoBehaviour
{
   
    public void CompleteObjective()
    {
        gameObject.SetActive(false);
    }

    public void IncompleteObjective()
    {
        gameObject.SetActive(true);
    }

}
