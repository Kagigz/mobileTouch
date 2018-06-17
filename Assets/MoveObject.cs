using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{


    GameObject obj = null;

    /* Generate ray from touch */

    Ray RayFromTouch()
    {

        Vector3 touchFar = new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, Camera.main.farClipPlane);
        Vector3 touchNear = new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, Camera.main.nearClipPlane);

        Vector3 touchPosF = Camera.main.ScreenToWorldPoint(touchFar);
        Vector3 touchPosN = Camera.main.ScreenToWorldPoint(touchNear);

        Ray ray = new Ray(touchPosN, touchPosF - touchPosN);
        return ray;
    }

    void Update()
    {
        if (Input.touchCount == 1 && !obj)
        {
            Ray touchRay = RayFromTouch();
            RaycastHit hit;

            if (Physics.Raycast(touchRay.origin, touchRay.direction, out hit))
            {
                obj = hit.transform.gameObject;
            }
        }

        else if (Input.touchCount == 1 && obj)
        {
            Vector3 newPos = Camera.main.ScreenToWorldPoint(Input.touches[0].position);
            obj.transform.position = new Vector3(newPos.x, newPos.y, obj.transform.position.z);
        }

        else if (Input.touchCount == 0 && obj)
        {
            obj = null;
        }
    }

}
