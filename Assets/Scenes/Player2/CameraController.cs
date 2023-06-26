using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset;
    public float speedCamera;

    private bool flag = true;

    void FixedUpdate()
    {
        if (flag)
        {
            transform.position = new Vector3(playerTransform.position.x + offset.x, offset.y, offset.z);
            flag = false;
        }

        if (playerTransform.position.x < 5 && playerTransform.position.x > -4.5f)
        {
            Vector3 newCamPosition = new Vector3(playerTransform.position.x + offset.x, offset.y, offset.z);
            transform.position = Vector3.Lerp(transform.position, newCamPosition, speedCamera * Time.deltaTime);
        }
    }
}
