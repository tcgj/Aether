﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BeardedManStudios.Forge.Networking.Generated;

/**
 * This class acts as an identifier for the NetworkManager 
 * to determine what needs to be spawned
 * when a specific ItemSkill is called
 */

public class SwordSlash : SwordSlashBehavior
{
    [SerializeField]
    private DamageDealerBase m_DamageDealerBase;
    private PlayerStance m_PlayerStance;

    private void Awake()
    {
        m_PlayerStance = GameObject.FindWithTag("Player").GetComponent<PlayerStance>();
    }

    private void Start()
    {
        m_DamageDealerBase.Activate(OnDamageDealt);
    }

    private void Update()
    {
        transform.position = m_PlayerStance.transform.position;
        networkObject.position = transform.position;
    }

    private void OnDamageDealt()
    {
        // E4 HACK
        AudioManager.m_Instance.PlaySoundAtPosition("GEN_Sword_Impact_1", transform.position);
    }
}
