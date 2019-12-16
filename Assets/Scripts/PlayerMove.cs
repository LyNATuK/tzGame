using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{

    public int CristallScore;
    public float speed;
    public Text txtScore;

    public bool FlipXZ; // if FALSE-right, else TRUE - forward
    public bool startClick = false; // first click current game

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ReloadScens.lose = false;
    }


    void Update()
    {
        startClick = ClickRotate.startClick;
        FlipXZ = ClickRotate.FlipXZ;

        if (startClick == true)
        {
            rb.velocity = transform.right * speed;

            if (FlipXZ == true) // rotation
            {
                transform.rotation = Quaternion.Euler(0, -90, 0); // forward
            } else if (FlipXZ == false)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0); // right
            }
        }

        txtScore.text = "Score: " + CristallScore.ToString("n0"); // show score
    }
    

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "StartPlace" || collision.gameObject.tag == "Cube")
        {
            GetComponent<PlayerMove>().enabled = true;
        }

    }

    private void OnCollisionExit(Collision collision) // goes beyond
    {
        if (collision.gameObject.tag == "StartPlace" || collision.gameObject.tag == "Cube")
        {
            GetComponent<PlayerMove>().enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cristal")
        {
            CristallScore++;
            Destroy(other.gameObject);
        }
    }

}
