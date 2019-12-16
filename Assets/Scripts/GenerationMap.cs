using UnityEngine;

public class GenerationMap : MonoBehaviour
{
    public GameObject cristalGO;
    public GameObject CubePref; // next cube
    public int maxCubes; // only for "StartCube"! // records how many cubes will be

    private float CrisChance;
    private int RandomPos;

    public static int Cubes; // current cubes

    void Start()
    {
        if (GenerationMap.Cubes < maxCubes) // quantity limit cubes
        {

            RandomPos = Random.Range(0, 2);
            if (RandomPos == 0)
            {
                if (transform.position.z - transform.position.x != 2) // if not extreme position
                {
                    Instantiate(CubePref, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), transform.rotation); // left spawn
                }
                else
                {
                    Instantiate(CubePref, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), transform.rotation); // right spawn
                }
            }

            if (RandomPos == 1)
            {
                if (transform.position.x - transform.position.z != 2) // if not extreme position
                {
                    Instantiate(CubePref, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), transform.rotation); // right spawn
                } else
                {
                    Instantiate(CubePref, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), transform.rotation); // left spawn
                }
            }

            CrisChance = Random.Range(0f, 1f); // cristall activate chance
            if (CrisChance <= 0.2f)
            {
                cristalGO.SetActive(true);
            }

            GenerationMap.Cubes++;
        }

    }
}
