using System.Collections;
using UnityEngine;

public class ActorCheckerTool
{
    public bool IsEnemyNearby()
    {
        bool condition;
        condition = false;
        return condition;
    }

   
}

public class CircularDetectionTool : MonoBehaviour
{
    public GameObject detectionProbe; 
    public int angle;
    private Vector3[] detectionalVectors;
    public bool IsTargetOnSight;
    public string detectionTag;
    public LayerMask playerMask;
    private int numberOfRays;
    public LineRenderer lr;

    public void Init()
    {
        IsTargetOnSight = false;
        numberOfRays = (360 / angle);
        detectionalVectors = new Vector3[numberOfRays - 1];
        lr = GetComponent<LineRenderer>();
    }



    //public void CalculateDetectionEveryRay(int angle)
    //{
    //    Vector3 directionalVector = (detectionProbe.transform.position - gameObject.transform.position);
    //    for (int i = 0; i < detectionalVectors.Length; i++)
    //    {
    //        int tempAngle = angle * i;
    //        detectionalVectors[i] = GetVectorRotatedPosition(directionalVector, tempAngle);
    //        CheckIfTargetGotCaught(detectionalVectors[i], directionalVector.magnitude);
    //    }
    //}




}