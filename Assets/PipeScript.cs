using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public GameObject MyBirdGameObject;
    public Transform MyBirdTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MyBirdGameObject = GameObject.Find("Bird");
        MyBirdTransform = GameObject.Find("Bird").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (MyBirdGameObject.transform.position.x - transform.position.x > 7.5)
        {
            //transform.Translate(15,0,0);
            transform.position += new Vector3(15, 0, 0);
        }
    }
}
