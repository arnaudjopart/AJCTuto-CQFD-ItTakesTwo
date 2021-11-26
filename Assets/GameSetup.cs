using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameSetup : MonoBehaviour
{
    public Transform[] m_startPositions;
    public Material[] m_playerMaterials;
    public string[] m_playerCameraLayer;

    private int m_playerIndex;

    public void HandleNewPlayerConnection(PlayerInput _player)
    {
        print("HandleNewPlayerConnection with device " + _player.devices[0]);
        var playerSetup = _player.GetComponent<PlayerSetup>();

        playerSetup.SetMaterial(m_playerMaterials[m_playerIndex]);
        playerSetup.SetCameraLayer(m_playerCameraLayer[m_playerIndex]);
        playerSetup.SetCameraCulling(m_playerCameraLayer[m_playerIndex]);
        playerSetup.SetPlayerStartPosition(m_startPositions[m_playerIndex]);
        playerSetup.SetPlayerInputIndex(m_playerIndex);

        m_playerIndex++; 
    }
}