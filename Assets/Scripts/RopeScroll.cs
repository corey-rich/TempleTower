using UnityEngine;

public class RopeScroll: MonoBehaviour
{
    // Scroll main texture based on time

    public float scrollSpeed = 0.5f;
    public float offset;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer> ();
    }

    void Update()
    {
        //float offset = Time.time * scrollSpeed;
        rend.material.mainTextureOffset = new Vector2(-0.05f, offset);
    }
}
