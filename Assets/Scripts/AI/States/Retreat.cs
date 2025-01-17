﻿using UnityEngine;

/*
 * Retreats to spawn point, will exit state upon reaching spawn point.
 */
public class Retreat : AiStateBehaviour
{
    public override void Init()
    {
        m_Agent.SetDestination(m_AiActor.GetSpawnPos());
    }

    public override void Update()
    {
        m_Agent.SetDestination(m_AiActor.GetSpawnPos());
        if (m_AiActor.DistanceFromSpawnPoint() < m_Agent.radius + 0.2f)
        {
            ExitState();
        }
    }
}
