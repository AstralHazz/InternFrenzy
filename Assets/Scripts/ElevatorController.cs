using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{
    public GameObject player;
    public bool elevatorReady = false;
    public GameObject groundFloor;
    public GameObject secondFloor;
    public GameObject thirdFloor;


    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (elevatorReady)
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0f) // Floor Up
            {
                if (this.gameObject.name == "Ground Floor")
                {
                    Debug.Log("Elevator Up!");
                    player.transform.position = new Vector3(player.transform.position.x, secondFloor.transform.position.y, player.transform.position.z);
                }
                else if (this.gameObject.name == "Second Floor")
                {
                    Debug.Log("Elevator Up2!");
                    player.transform.position = new Vector3(player.transform.position.x, thirdFloor.transform.position.y, player.transform.position.z);
                }
            }
            else if (Input.GetAxis("Mouse ScrollWheel") < 0f) // Floor Down
            {
                if (this.gameObject.name == "Third Floor")
                {
                    Debug.Log("Elevator Down!");
                    player.transform.position = new Vector3(player.transform.position.x, secondFloor.transform.position.y, player.transform.position.z);
                }
                else if (this.gameObject.name == "Second Floor")
                {
                    Debug.Log("Elevator Down2!");
                    player.transform.position = new Vector3(player.transform.position.x, groundFloor.transform.position.y, player.transform.position.z);
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Elevator on!");
        elevatorReady = true;
        
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Elevator off!");
        elevatorReady = false;
    }

    

    /*IEnumerator TeleportPlayer()
    {
        yield return new WaitForSeconds(1f);
    }*/
}
