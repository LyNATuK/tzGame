using UnityEngine;

public class ReloadScens : MonoBehaviour
{

    public GameObject Player;

    public GameObject textLose;

    public static bool lose = false;

    void Update()
    {
        if (Player.transform.position.y < -4f)
        {
            ClickRotate.startClick = false;
            GenerationMap.Cubes = 0;
            Player.GetComponent<Rigidbody>().useGravity = false;

            textLose.SetActive(true); // animation text your lose
            lose = true;
        }
    }
}
