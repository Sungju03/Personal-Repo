using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;//Rigidbody of the player
    private int count;
    private float movementX;//movement along x and y axes
    private float movementY;
    public float speed = 0;//speed at which the player moves
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    void Start()//start is called before the first frame update
    {
        rb = GetComponent<Rigidbody>();/*get and store the Rigidbody 
        component attached to the player.*/
        count = 0;
        SetCountText();
        winTextObject.SetActive(false);

    }

    void OnMove(InputValue movementValue)/*this function is called when
    a move input is detected*/
    {
        Vector2 movementVector = movementValue.Get<Vector2>(); /*convert
        the input value into a Vector2 for movement*/
        movementX = movementVector.x;//store the x and y components for movement
        movementY = movementVector.y;
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }

    private void FixedUpdate()//FixedUpdate is called once per fixed frame-rate frame
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);/*create a
        3D movement vector using the x and y inputs*/
        rb.AddForce(movement * speed);//apply force to the Rigidbody to move the player.
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))/*check if the object
        the player collided with has the "PickUp" tag*/
        {
            other.gameObject.SetActive(false);//deactivate the collided object (makes it disappear)
            count = count + 1;
            SetCountText();
            if (count >= 5)
            {
                winTextObject.SetActive(true);
            }
        }
    }
}
