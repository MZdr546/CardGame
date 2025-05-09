using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPlace : MonoBehaviour
{
    public Canvas Canvas;

    public MeshRenderer MeshRenderer;

    [SerializeField]
    Color HighlightColor;
    Color OriginalColor;
    private void OnMouseEnter()
    {
        if(GlobalInformation.CardChoosen != null)
        {
            OriginalColor = MeshRenderer.materials[0].color;
            MeshRenderer.materials[0].color = HighlightColor;
           
        }
    }

    private void OnMouseExit()
    {
        if (GlobalInformation.CardChoosen != null)
        {
            MeshRenderer.materials[0].color = OriginalColor;

        }
    }

    private void OnMouseDown()
    {
        Debug.Log("down");

        GameObject gameObject = GlobalInformation.CardChoosen.gameObject;
        StartCoroutine(SetCardDown(gameObject));
    }

    public IEnumerator SetCardDown(GameObject gameObject)
    {
        while(Vector3.Distance(gameObject.transform.position, transform.position) > 0.1f)
        {
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, transform.position, 10f * Time.deltaTime);
            gameObject.transform.rotation = Quaternion.RotateTowards(gameObject.transform.rotation, transform.rotation, 180f);
            yield return new WaitForSeconds(0.1f);
        }

        yield return null;
    }
}
