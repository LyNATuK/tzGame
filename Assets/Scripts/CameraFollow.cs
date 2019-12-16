using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject player;

    private float movementX;
    private float movementZ;
    public GameObject followedCamera;
    
    void Update()
    {
        if (ReloadScens.lose == false) {
            movementX = ((player.transform.position.x - this.transform.position.x));
            movementZ = ((player.transform.position.z - this.transform.position.z));
            var movmentXZ = (movementX + movementZ) / 2;
            this.transform.position += new Vector3((movmentXZ * 3 * Time.deltaTime), 0, (movmentXZ * 3 * Time.deltaTime));

            Vector3 temp = followedCamera.transform.position;
            temp.y = 0f;
            followedCamera.transform.position = temp;
        }
    }
}
