using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float verticalmove = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(0f, verticalmove, 0f);

        Vector3 clampPos = transform.position;
        clampPos.y = Mathf.Clamp(clampPos.y, -3.89f, 3.88f);
        transform.position = clampPos;

        //transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(1);
        }
    }
}
