
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("This thing is friendly");
                break;
            case "Finish":
                Debug.Log("congrats, you finish");
                break;
            case "Fuel":
                Debug.Log("You Picked up fuel");
                break;
            default:
                Debug.Log("Sorry, You blew up");
                break;
        }
    }
}
