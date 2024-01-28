using UnityEngine;

public class ParallaxStatic : MonoBehaviour
{
    [SerializeField] Vector2 velMov;
    Vector2 offset;
    Material material;
    void Start()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset = velMov * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
