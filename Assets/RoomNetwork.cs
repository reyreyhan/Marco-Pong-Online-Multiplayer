using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;

public class RoomNetwork : MonoBehaviour
{
    [SerializeField] GameObject[] arrayOfPlayer;
    public GameObject[] playerSpawnPoint;
    public GameObject atas, bawah, kiri, kanan;
    public bool jalanAtas, jalanBawah, jalanKiri, jalanKanan; 
    // Start is called before the first frame update
    void Start()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            arrayOfPlayer[0] = PhotonNetwork.Instantiate(arrayOfPlayer[0].name, playerSpawnPoint[0].transform.position, Quaternion.identity, 0);
        }
        else
        {
            arrayOfPlayer[1] = PhotonNetwork.Instantiate(arrayOfPlayer[1].name, playerSpawnPoint[1].transform.position, Quaternion.identity, 0);
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (PhotonNetwork.CurrentRoom.PlayerCount == 2)
        {
            
        }

        if (jalanAtas)
        {
            if (PhotonNetwork.IsMasterClient)
            {
                arrayOfPlayer[0].transform.Translate(new Vector2(0, 1 * Time.deltaTime));
            } else
            {
                arrayOfPlayer[1].transform.Translate(new Vector2(0, 1 * Time.deltaTime));
            }

        }

        if (jalanBawah)
        {
            if (PhotonNetwork.IsMasterClient)
            {
                arrayOfPlayer[0].transform.Translate(new Vector2(0, -1 * Time.deltaTime));
            } else
            {
                arrayOfPlayer[1].transform.Translate(new Vector2(0, -1 * Time.deltaTime));
            }
        }

        if (jalanKanan)
        {
            if (PhotonNetwork.IsMasterClient)
            {
                arrayOfPlayer[0].transform.Translate(new Vector2(1 * Time.deltaTime, 0));
            } else
            {
                arrayOfPlayer[1].transform.Translate(new Vector2(1 * Time.deltaTime, 0));
            }
        }

        if (jalanKiri)
        {
            if (PhotonNetwork.IsMasterClient)
            {
                arrayOfPlayer[0].transform.Translate(new Vector2(-1 * Time.deltaTime, 0));
            } else
            {
                arrayOfPlayer[1].transform.Translate(new Vector2(-1 * Time.deltaTime, 0));
            }
        }


    }

    public void OnClickButton()
    {

        if (PhotonNetwork.IsMasterClient)
        {
            
        }
        else
        {
            
        }

    }

    private bool CheckEndGame()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            
        }
        else
        {
            
        }


        return true;
    }

    private void UpdatePlayers()
    {
        
    }

    public void OnClickAtas()
    {
        jalanAtas = true;
    }

    public void OnAtasLepas()
    {
        jalanAtas = false;
    }

    public void OnClickBawah()
    {
        jalanBawah = true;
    }

    public void OnBawahLepas()
    {
        jalanBawah = false;
    }

    public void OnClickKiri()
    {
        jalanKiri = true;
    }

    public void OnKiriLepas()
    {
        jalanKiri = false;
    }

    public void OnClickKanan()
    {
        jalanKanan = true;
    }

    public void OnKananLepas()
    {
        jalanKanan = false;
    }
}