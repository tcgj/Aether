﻿using System.Collections.Generic;
using UnityEngine;
using BeardedManStudios.Forge.Networking.Unity;

[RequireComponent(typeof(PlayerNetworkManager))]
public class PlayerManager : Singleton<PlayerManager>
{
    public event System.Action PlayerListPopulated;

    [SerializeField]
    private PlayerNetworkManager m_PlayerNetworkManager;

    private Player m_LocalPlayer;
    private List<Player> m_Players;
    private int m_TotalPlayerCount;

    private void Awake()
    {
        m_Players = new List<Player>();
    }

    public void AddPlayer(Player player)
    {
        m_Players.Add(player);

         if (player != null)
        {
            PlayerMovement movement = player.GetComponent<PlayerMovement>();
            if (movement != null)
                movement.SetFrozen(true);
        }

        PlayerDetails details = player.GetPlayerDetails();
        if (details == null)
        {
            Debug.LogError("Player details are null. PlayerManager.AddPlayer");
            return;
        }

        NetworkManager.Instance?.InstantiateSkills(index: 8, position: transform.position, rotation: transform.rotation);

        // Check if all players are loaded into the lists
        if (m_Players.Count == m_TotalPlayerCount)
            PlayerListPopulated?.Invoke();
    }

    public void SetLocalPlayer(Player player)
    {
        m_LocalPlayer = player;
    }

    public void SetPlayerCount(int count)
    {
        m_TotalPlayerCount = count;
    }

    public Player GetLocalPlayer()
    {
        return m_LocalPlayer;
    }

    public int GetPlayerCount()
    {
        return m_TotalPlayerCount;
    }

    public Player GetPlayerById(uint networkId)
    {
        return m_Players.Find(player => player.GetPlayerDetails().GetNetworkId() == networkId);
    }

    public List<Player> GetAllPlayers()
    {
        return m_Players;
    }

    public List<Player> GetOtherPlayers()
    {
        List<Player> others = m_Players.ConvertAll(player => player);
        if (!others.Remove(m_LocalPlayer))
            Debug.Log("Local player not found in player list");

        return others;
    }

    public PlayerNetworkManager GetPlayerNetworkManager()
    {
        return m_PlayerNetworkManager;
    }

    public void DestroyPlayer(Player player)
    {
        if (!m_Players.Contains(player))
            return;

        m_Players.Remove(player);
        m_TotalPlayerCount--;
    }
}
