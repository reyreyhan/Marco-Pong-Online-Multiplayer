using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Network : MonoBehaviourPunCallbacks
{
    public GameObject buttonMultiPlayer;

    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnConnectedToMaster()
    {
        buttonMultiPlayer.SetActive(true);
    }
    
    public void OnClickMultiplayer()
    {
        PhotonNetwork.JoinRandomRoom();
        StartCoroutine(JoinRoom());
    }

    public override void OnJoinedRoom()
    {
        StopAllCoroutines();
        Application.LoadLevel("Multiplayer");
    }

    IEnumerator JoinRoom()
    {
        yield return new WaitForSeconds(2);

        RoomOptions roomOpt = new RoomOptions() { IsVisible = true, IsOpen = true, MaxPlayers = 2 };
        int roomNumber = Random.Range(0, 100);
        PhotonNetwork.CreateRoom(roomNumber.ToString(), roomOpt, null, null);
    }
}
