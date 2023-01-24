using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{

    Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Vector3 deltaPosition = targetPosition - gameObject.transform.position;

            Physics.IgnoreLayerCollision(0, gameObject.layer, true);
            gameObject.GetComponent<CharacterController>().Move(deltaPosition); // via "motion"
            gameObject.GetComponent<CharacterController>().SimpleMove(Vector3.zero); // via "speed"
            Physics.IgnoreLayerCollision(0, gameObject.layer, false);
            //gameObject.transform.position = Vector3.zero;
        }
    }
}
