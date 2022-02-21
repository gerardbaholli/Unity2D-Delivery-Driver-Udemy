using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    [SerializeField] GameObject thingToFollow;

    private void LateUpdate()
    {
        //transform.position = new Vector3(thingToFollow.transform.position.x, thingToFollow.transform.position.y, -10f);
        transform.position = thingToFollow.transform.position + new Vector3(0f, 0f, -10f);
    }


}
