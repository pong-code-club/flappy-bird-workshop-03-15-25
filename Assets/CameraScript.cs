using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject MyBird;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MyBird = GameObject.Find("Bird");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(MyBird.transform.position.x, transform.position.y, transform.position.z);
    }
}
