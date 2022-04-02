using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFolow;

    // this things position (camera) should be the same as the car's position
    void LateUpdate()
    {
        transform.position = this.thingToFolow.transform.position + new Vector3(0, 0, -10);
    }
}
