using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointScript : MonoBehaviour
 {
     private int waypointIdx = 0;
     public Transform[] waypointList;
     private float stopDistance = 3, moveSpeed = 0.35f;
     private Transform currentPoint;
   private void Start()
     {
         currentPoint = waypointList[0];
     }
 
     private void Update()
     {
         if (waypointIdx <= waypointList.Length)
         {
             transform.position = Vector3.MoveTowards(transform.position, currentPoint.transform.position, moveSpeed * Time.deltaTime);
             if (Vector3.Distance(transform.position, waypointList[waypointIdx].transform.position) <= stopDistance)
             {
                 if (waypointIdx < waypointList.Length - 1)
                 {
                     waypointIdx++;
                 }
                 else if (waypointIdx >= waypointList.Length - 1)
                 {
                     waypointIdx = 0;
                 }
 
                 currentPoint = waypointList[waypointIdx];
             }
         }
 
     }
 }