using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;
 //   private Quaternion offsetR;
    [SerializeField]
    private bool lookAt = true;
    [SerializeField]
    private Space offsetPositionSpace = Space.Self;
  
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
       // offsetR = transform.rotation - player.transform.rotation;
    }

    // Update is called once per frame
    void LateUpdate()
     {
        if(offsetPositionSpace == Space.Self)
     {
         transform.position = player.transform.TransformPoint(offset);
     }
     else
     {
         transform.position = player.transform.position + offset;
     }
       //  transform.position = player.transform.position + offset;
        if(lookAt)
     {
         transform.LookAt(player.transform);
     }
     else
     {
         transform.rotation = player.transform.rotation;
     }
       // transform.position = player.transform.position + offset;
    }

//   [SerializeField]
//  private Transform target;

//  [SerializeField]
//  private Vector3 offsetPosition;

//  [SerializeField]
//  private Space offsetPositionSpace = Space.Self;
  
//  [SerializeField]
//  private bool lookAt = true;

//  private void Update()
//  {
//      Refresh();
//  }

//  public void Refresh()
//  {
//      if(target == null)
//      {
//          Debug.LogWarning("Missing target ref !", this);

//          return;
//      }

//      // compute position
//      if(offsetPositionSpace == Space.Self)
//      {
//          transform.position = target.TransformPoint(offsetPosition);
//      }
//      else
//      {
//          transform.position = target.position + offsetPosition;
//      }

//      // compute rotation
//      if(lookAt)
//      {
//          transform.LookAt(target);
//      }
//      else
//      {
//          transform.rotation = target.rotation;
//      }
 //}
}
