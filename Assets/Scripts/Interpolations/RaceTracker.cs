using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceTracker : MonoBehaviour
{
    public Transform start, finish, player;

    public float percentage;

    private void Update() {
        Vector3 startPos = start.position;
        Vector3 finishPos = finish.position;
        Vector3 playerPos = player.position;

        percentage = MathUtilities.InverseLerp(startPos, finishPos, playerPos);

        float startToFinishDist = Vector3.Distance(startPos, finishPos);
        float playerToFinishDist = Vector3.Distance(playerPos, finishPos);

        float percent = playerToFinishDist / startToFinishDist;
    }
}
