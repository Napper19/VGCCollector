using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Printer : DefaultObserverEventHandler
{
    
    
     protected override void OnTrackingFound()
        {
            Debug.Log("Target Found");
        }
}
