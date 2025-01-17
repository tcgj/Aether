﻿using System.Collections;
using System.Collections.Generic;
using BeardedManStudios.Forge.Networking;
using BeardedManStudios.Forge.Networking.Unity;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationCallbacks : MonoBehaviour
{
    private Animator m_Animator;

    [SerializeField]
    private PlayerMovement m_PlayerMovement;

    [SerializeField]
    private PlayerStance m_PlayerStance;

    protected void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    public void JumpStartCompleted()
    {
    }

    public void OnCallChangeFace(string target)
    {

    }

    public void Backstep() {
        StartCoroutine(m_PlayerMovement.Dash(-transform.forward, 0, 0.3f, 8, () => { }));
    }

    public void DashForward(float distance)
    {
        // E4 Hack: This DashForward function is gonna temporarily be the place to trigger actual
        // attack code. This should be moved into a different event callback
        AudioManager.m_Instance.PlaySoundAtPosition("GEN_Sword_Swing_1", transform.position);
        NetworkManager.Instance?.InstantiateSwordSlash(index: 0, position: transform.position);
        // NetworkManager.Instance.InstantiateSwordSlash(index: 1,
        //    position: transform.position,
        //    rotation: Quaternion.LookRotation(
        //        -m_PlayerStance.GetWeaponTransform().up,
        //        -m_PlayerStance.GetWeaponTransform().forward));
        StartCoroutine(m_PlayerMovement.Dash(transform.forward, 0, distance, 8, () => { }));
    }

    public void SetWeaponActive()
    {
        if (m_PlayerStance != null)
            m_PlayerStance.SetWeaponActive();
    }

    public void OnAnimatorMove()
    {
        if (!m_Animator)
            return;

        //if (!m_Animator.GetCurrentAnimatorStateInfo(4).IsTag("ApplyRootMotion"))
        //    return;

       // m_PlayerMovement.RootMotionMoveTo(m_Animator.rootPosition, m_Animator.rootRotation);
    }
}
