using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject spawnObject;
    bool isPress = false;
    public float fireRate = 0.2f;
    private float nextFire = 0.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isPress = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isPress = false;
        }

        if (isPress && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 offset = new Vector3(0, 0, 10);
            Instantiate(spawnObject, pos + offset, Quaternion.identity);
        }
    }
}
