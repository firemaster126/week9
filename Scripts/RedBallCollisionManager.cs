using System;
using UnityEngine;

public class RedBallCollisionManager : BallCollisionManager
{
    public AudioSource vineboomsound;
    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Red Ball Collision Manager Function");

        vineboomsound.Play();
    }
}

