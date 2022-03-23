using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthComponent : HealthComponent
{
    // Start is called before the first frame update
    protected override void start()
    {
        base.start();
        PlayerEvents.InvokeOnHealthInitialized(this);
    }
}
