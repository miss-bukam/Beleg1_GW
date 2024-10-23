using UnityEngine;

public class BewegungObject : MonoBehaviour
{
    public float geschwindigkeit = 5f;
    public float rotation = 100f; 

    //Schwerkraft mit dem Ridgitbody
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      if(rb == null)
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float bewegungVertical = Input.GetAxis("Vertical");
        float bewegungHorizontal = Input.GetAxis("Horizontal");

        Vector3 bewegung = new Vector3(bewegungHorizontal, 0.0f, bewegungVertical);
        rb.MovePosition(rb.position + bewegung * geschwindigkeit * Time.deltaTime);
        //transform.Translate(Vector3.forward * bewegungRichtung * geschwindigkeit * Time.deltaTime);
        //transform.Rotate(Vector3.up, bewegungHorizontal * geschwindigkeit * Time.deltaTime);
    }
}
