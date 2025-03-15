using UnityEngine;

public class CharacterClass : MonoBehaviour
{
    public int CoinCount;
    public float HealthPower;
    public string Name;
    public bool IsAlive;
    public Vector3 StartPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("start");
        StartPosition = new Vector3(10, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger");
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
    }
}
