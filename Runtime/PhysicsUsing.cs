using System;
using UnityEngine;

public class PhysicsUsing : IDisposable
{
    private readonly bool _hitTriggersTempSetting;

    public static PhysicsUsing EnableQueryHitTriggers()
    {
        return new PhysicsUsing(true);
    }
        
    public static PhysicsUsing DisableQueryHitTriggers()
    {
        return new PhysicsUsing(false);
    }
        
    public static PhysicsUsing QueryHitTriggers(bool state)
    {
        return new PhysicsUsing(state);
    }
        
    public PhysicsUsing(bool state)
    {
        _hitTriggersTempSetting = Physics2D.queriesHitTriggers;
        Physics2D.queriesHitTriggers = state;
    }
        
    public void Dispose()
    {
        Physics2D.queriesHitTriggers = _hitTriggersTempSetting;
    }
}