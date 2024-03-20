using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;
    [SerializeField] private MeshRenderer vignetteMesh;
    private Material vignetteShader;

    private void Start()
    {
        vignetteShader = vignetteMesh.material;
        vignetteShader.SetFloat("_ApertureSize", 0f);
        StartCoroutine("FadeOutVignette");
    }

    public void LoadNextLevel()
    {
        vignetteShader.SetFloat("_ApertureSize", 1f);
        StartCoroutine("FadeInVignette");
    }

    //fades screen to black
    private IEnumerator FadeInVignette() {
        for (int i = 100; i > 0; i--)
        {
            float vignetteValue = (float)i / 100;
            vignetteShader.SetFloat("_ApertureSize", vignetteValue);
            yield return new WaitForSeconds(0.01f);
        }
        vignetteShader.SetFloat("_ApertureSize", 0f);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneToLoad);
    }

    //fades from black to vision
    private IEnumerator FadeOutVignette()
    {
        yield return new WaitForSeconds(1f);
        for (int i = 0; i < 100; i++)
        {
            float vignetteValue = (float)i / 100;
            vignetteShader.SetFloat("_ApertureSize", vignetteValue);
            yield return new WaitForSeconds(0.01f);
        }
        vignetteShader.SetFloat("_ApertureSize", 1f);
    }
}
