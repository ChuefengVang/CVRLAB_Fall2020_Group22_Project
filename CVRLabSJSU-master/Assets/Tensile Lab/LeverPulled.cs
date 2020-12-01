using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverPulled : MonoBehaviour
{   public GameObject Manager;
    public bool CheckLeverPulled = false;
    // Start is called before the first frame update
    void Start()
    {
        
        for(int i = 0; i < 10; i++)
        {
            Manager.SetActive (true);
            CheckLeverPulled = true;
        }
        CheckLeverPulled = false;
    }
    
}
