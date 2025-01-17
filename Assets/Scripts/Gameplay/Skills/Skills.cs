﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BeardedManStudios.Forge.Networking.Generated;

/**
 * This class acts as an identifier for the NetworkManager 
 * to determine what needs to be spawned
 * when a specific ItemSkill is called
 */

public class Skills : SkillsBehavior
{
    [SerializeField]
    private DamageDealerBase m_DamageDealerBase;

    private void Start()
    {
        m_DamageDealerBase?.Activate(null);
    }
}
