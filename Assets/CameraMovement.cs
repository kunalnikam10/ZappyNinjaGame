using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed;
    public float speedMultiplier;
    public float speedIncreaseMilestone;
    private float speedMilestoneCount;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);

        if(transform.position.x > speedMilestoneCount)
        {
            speedMilestoneCount += speedIncreaseMilestone;
            cameraSpeed = cameraSpeed * speedMultiplier;
        }
    }
}