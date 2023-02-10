using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

 private float rotationSpeed = 45.0f;

    private void Update()
    {
        transform.Rotate(new Vector3(rotationSpeed * Time.deltaTime, 0, 0));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController playerController = other.gameObject.GetComponent<PlayerController>();
            playerController.score++;
            Debug.Log("Score: " + playerController.score);
            gameObject.SetActive(false);
        }
    }
}
