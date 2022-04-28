using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ElevatorController : MonoBehaviour
{
    public GameObject player;
    public bool elevatorReady = false;
    public GameObject groundFloor;
    public GameObject secondFloor;
    public GameObject thirdFloor;

    public GameObject elevatorUI;


    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Elevator on!");
            elevatorReady = true;
            ShowUI();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Elevator off!");
            elevatorReady = false;
            HideUI();
        }
    }

    public void HideUI()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        FindObjectOfType<Invector.vCharacterController.vThirdPersonInput>().cameraDisabled = false;
        elevatorUI.SetActive(false);
    }

    public void ShowUI()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        elevatorUI.SetActive(true);
        FindObjectOfType<Invector.vCharacterController.vThirdPersonInput>().cameraDisabled = true;
    }

    public void TeleportToGroundFloor()
    {
        if (elevatorReady)
        {
            if (this.gameObject.name == "Third Floor")
            {
                player.transform.position = new Vector3(player.transform.position.x, groundFloor.transform.position.y, player.transform.position.z);
            }
            else if (this.gameObject.name == "Second Floor")
            {
                player.transform.position = new Vector3(player.transform.position.x, groundFloor.transform.position.y, player.transform.position.z);
            }
        }
    }

    public void TeleportToSecondFloor()
    {
        if (elevatorReady)
        {
            if (this.gameObject.name == "Ground Floor")
            {
                player.transform.position = new Vector3(player.transform.position.x, secondFloor.transform.position.y, player.transform.position.z);
            }
            else if (this.gameObject.name == "Third Floor")
            {
                player.transform.position = new Vector3(player.transform.position.x, secondFloor.transform.position.y, player.transform.position.z);
            }
        }
    }

    public void TeleportToThirdFloor()
    {
        if (elevatorReady)
        {
            if (this.gameObject.name == "Ground Floor")
            {
                player.transform.position = new Vector3(player.transform.position.x, thirdFloor.transform.position.y, player.transform.position.z);
            }
            else if (this.gameObject.name == "Second Floor")
            {
                player.transform.position = new Vector3(player.transform.position.x, thirdFloor.transform.position.y, player.transform.position.z);
            }
        }
    }
}
