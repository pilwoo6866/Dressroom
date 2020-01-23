using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Active : MonoBehaviour
{
    public GameObject gameObject;
    
    public void setActive(bool activated)
    {
        gameObject.SetActive(activated);
    }
}
