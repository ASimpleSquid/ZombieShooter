using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieStateMachine : MonoBehaviour
{
 
    public State currentState { get; private set; }
    protected Dictionary<ZombieStateType, State> states;
    bool isRunning;

    // Update is called once per frame
    void Update()
    {
        
    }
}
