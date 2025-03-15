using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdScript : MonoBehaviour
{
    public ScoreScript MyScoreScript;
    public Transform MyTransform;
    public Rigidbody MyRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MyScoreScript = GameObject.Find("ScoreUI").GetComponent<ScoreScript>();
        MyTransform = GetComponent<Transform>();
        MyRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(3 * Time.deltaTime,0,0);

        if (Input.GetMouseButtonDown(0))
        {
            //MyRigidbody.linearVelocity = new Vector3 (0,0,0);
            MyRigidbody.linearVelocity = Vector3.zero;
            MyRigidbody.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //SceneManager.LoadScene("FlappyBirdExample");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Went Through Pipe");
        MyScoreScript.AddToScore();
    }
}
