using UnityEngine;
using UnityEngine.EventSystems;
using static UnityEditor.PlayerSettings;

public class Manager : MonoBehaviour
{
    public GameObject spawnObject;
    bool isPress = false;
    public float fireRate = 0.2f;
    private float nextFire = 0.0f;

    public float fireRate1 = 0.2f;
    private float nextFire1 = 0.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool isPointerOverGameObject = EventSystem.current.IsPointerOverGameObject();
        if (Input.GetMouseButtonDown(0))
        {
            isPress = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isPress = false;
        }

        if (!isPointerOverGameObject && isPress && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 offset = new Vector3(0, 0, 10);
            Instantiate(spawnObject, pos + offset, Quaternion.identity);
        }

        if (Time.time > nextFire1)
        {
            nextFire1 = Time.time + fireRate1;
            Vector3 offset = new Vector3(0, 0, 10);
            Vector3 pos = new Vector3(-7, 3, 0);
            Instantiate(spawnObject, pos + offset, Quaternion.identity);
        }
    }
}
