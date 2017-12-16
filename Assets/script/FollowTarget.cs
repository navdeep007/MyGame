using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour
{
    [SerializeField]
    Transform mTarget;
    [SerializeField]
    float mFollowSpeed;
    [SerializeField]
    float mFollowRange;

    //float mArriveThreshold = 0.05f;

    void Update ()
    {
        if(mTarget != null && Time.timeScale != 0)
        {
         
            transform.position = Vector2.MoveTowards(transform.position, mTarget.transform.position, mFollowSpeed);

        }
    }

    public void SetTarget(Transform target)
    {
        mTarget = target;
    }
}
