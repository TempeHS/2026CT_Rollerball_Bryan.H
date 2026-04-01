using UnityEngine;
using System.Collections;

public class FadeGround : MonoBehaviour
{
    public GameObject ground;
    public float fadeSpeed = 1f;

    public void StartFade()
    {
        StartCoroutine(FadeOutGround());
    }

    private IEnumerator FadeOutGround()
    {
        MeshRenderer renderer = ground.GetComponent<MeshRenderer>();
        Material mat = renderer.material;

        Color color = mat.color;

        while (color.a > 0)
        {
            color.a -= Time.deltaTime * fadeSpeed;
            mat.color = color;
            yield return null;
        }

        ground.GetComponent<Collider>().enabled = false;
    }
}
       



