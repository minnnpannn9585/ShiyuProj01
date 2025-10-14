using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    bool canDestroy = false;
    public Vector3 deltaRot;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (canDestroy)
            {
                //Destroy(this.gameObject);
                StartCoroutine(DoorOpen());
            }
        }
    }

    IEnumerator DoorOpen()
    {
        float time = 0f;
        Quaternion initialRotation = transform.rotation;
        Quaternion targetRotation = Quaternion.Euler(transform.eulerAngles + deltaRot);
        while (time < 1f)
        {
            time += Time.deltaTime; // Increment time based on real time
            transform.rotation = Quaternion.Slerp(initialRotation, targetRotation, time);
            yield return null; // Wait for the next frame
        }
        transform.rotation = targetRotation; // Ensure final rotation is set
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canDestroy = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canDestroy = false;
        }
    }
}
