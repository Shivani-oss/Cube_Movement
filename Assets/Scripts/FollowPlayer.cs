using System.Security.Cryptography;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log(player.position);
        Vector3 desiredPosition = player.position + offset;
        //Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);// for going smooth position from one point ot another
        transform.position = desiredPosition; //transform - the object/script in which it is sitting on eg-camera 


       // transform.LookAt(player);
    }
}
 