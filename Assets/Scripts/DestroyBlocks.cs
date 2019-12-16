using UnityEngine;

public class DestroyBlocks : MonoBehaviour
{

    public bool PlayerHere = false;
    
    void Update()
    {
        if (PlayerHere == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 5f * Time.deltaTime, transform.position.z); // fall
        }
        if (transform.position.y < -5f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && ClickRotate.startClick == true) // if stepped on a block
        {
            Invoke("BlockFall", 1.4f);
        }
    }

    void BlockFall ()
    {
        PlayerHere = true;
    }

}
