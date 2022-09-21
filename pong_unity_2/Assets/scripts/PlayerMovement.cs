using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int PlayerNumber = 1;
    // Update is called once per frame
    void Update()
    {
        if (PlayerNumber == 1)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("player1") * Time.deltaTime * 6, 0));
        }
        
        if (PlayerNumber == 2)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("player2") * Time.deltaTime * 6, 0));
        }
    }
}
