﻿using UnityEngine;
using UnityEngine.UI;
using BeardedManStudios.Forge.Networking;
using BeardedManStudios.Forge.Networking.Generated;

public class LobbyPlayer : LobbyPlayerBehavior
{
    [SerializeField]
    private Text m_PlayerName;

    private RawImage m_Container;

    private bool m_IsReady = false;

    private int m_PreviousPosition = -1;
    private int m_Position = -1;

    private ulong m_Customization;

    private bool m_IsDisconnected = false;

    private void Start()
    {
        m_Container = GetComponent<RawImage>();
    }

    public (int previous, int current) GetPosition()
    {
        return (m_PreviousPosition, m_Position);
    }

    public string GetName()
    {
        return m_PlayerName.text;
    }

    public bool GetIsReady()
    {
        return m_IsReady;
    }

    public bool GetIsDisconnected()
    {
        return m_IsDisconnected;
    }

    public ulong GetCustomization()
    {
        return m_Customization;
    }

    public void UpdatePosition(int index)
    {
        networkObject?.SendRpc(RPC_SET_POSITION, Receivers.All, index);
    }

    public void UpdateName(string name)
    {
        networkObject?.SendRpc(RPC_SET_NAME, Receivers.All, name);
    }

    public void UpdateReadyStatus(bool isReady)
    {
        networkObject?.SendRpc(RPC_SET_READY, Receivers.All, isReady);
    }

    public void SignalDisconnect()
    {
        networkObject?.SendRpc(RPC_SIGNAL_DISCONNECTED, Receivers.All);
    }

    public void Disconnect()
    {
        networkObject?.SendRpc(RPC_DISCONNECT, Receivers.All);
    }

    public void UpdateDataFor(NetworkingPlayer player)
    {
        networkObject?.SendRpc(player, RPC_SET_NAME, m_PlayerName.text);
        networkObject?.SendRpc(player, RPC_SET_READY, m_IsReady);
        networkObject?.SendRpc(player, RPC_SET_POSITION, m_Position);
    }

    public void SetCustomization(ulong data)
    {
        m_Customization = data;
    }

    public override void SetPosition(RpcArgs args)
    {
        m_PreviousPosition = m_Position;
        m_Position = args.GetNext<int>();
        LobbySystem.Instance.SetPlayerInPosition(this);
    }

    public override void SetName(RpcArgs args)
    {
        m_PlayerName.text = args.GetNext<string>();
    }

    public override void SetReady(RpcArgs args)
    {
        m_IsReady = args.GetNext<bool>();

        if (m_IsReady)
            m_Container.color = Color.green;
        else
            m_Container.color = Color.white;
    }

    public override void SignalDisconnected(RpcArgs args)
    {
        m_IsDisconnected = true;
    }

    public override void Disconnect(RpcArgs args)
    {
        Destroy(gameObject);
    }
}
