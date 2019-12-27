using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform shooting_object;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            Debug.Log("Button pressed");
            RayCastShoot();
        }
    }

    private void RayCastShoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(shooting_object.position, shooting_object.forward, out hit))
        {
            if (hit.collider.gameObject.CompareTag("Cube"))
            {
                var gameObjectRenderer = hit.collider.gameObject.GetComponent<Renderer>();
                gameObjectRenderer.material.SetColor("_Color", Color.red);
                Debug.Log("SHOT SOMETHING!");
            }
        }
    }
}
