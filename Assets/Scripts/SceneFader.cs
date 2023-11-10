using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class SceneFader : MonoBehaviour
{
    public Image fadeImage;
    public float fadeSpeed = 1.0f;

    private void Start()
    {
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        Color startColor = fadeImage.color;
        Color targetColor = new Color(startColor.r, startColor.g, startColor.b, 0.0f);

        float t = 0.0f;
        while (t < 1.0f)
        {
            t += Time.deltaTime * fadeSpeed;
            fadeImage.color = Color.Lerp(startColor, targetColor, t);
            yield return null;
        }

        // Optionally, you can load a new scene here or perform any other action.
    }
}
