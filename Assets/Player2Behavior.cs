using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using LockingPolicy = Thalmic.Myo.LockingPolicy;
using Pose = Thalmic.Myo.Pose;
using UnlockType = Thalmic.Myo.UnlockType;
using VibrationType = Thalmic.Myo.VibrationType;

public class Player2Behavior : MonoBehaviour
{
    ThalmicMyo thalmicMyo;
    [SerializeField] GameObject myo;
    [SerializeField] GameObject[] playerObj;

    public int player;

    // Start is called before the first frame update
    void Start()
    {
        thalmicMyo = myo.GetComponent<ThalmicMyo>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player == 2)
        {
            if (thalmicMyo.pose == Pose.DoubleTap)
            {
                Debug.Log("tembak");
            }

            else if (thalmicMyo.pose == Pose.Fist)
            {
                Debug.Log("perisai");
            }

            else if (thalmicMyo.pose == Pose.WaveIn)
            {
                Debug.Log("dashKiri");
                playerObj[0].transform.position = new Vector2(transform.position.x + 0.2f, 0);
            }

            else if (thalmicMyo.pose == Pose.WaveOut)
            {
                Debug.Log("doubleDashKanan");
                playerObj[0].transform.position = new Vector2(0, transform.position.x + 0.2f);
            }
        }
    }
}
