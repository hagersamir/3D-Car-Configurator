using UnityEngine;
using System.Collections.Generic;

using UnityEngine.EventSystems;
public class PartSelector : MonoBehaviour
{
    public Camera cam;
    public UIManager uiManager;
    private GameObject currentSelected;
    public Material shieldMaterial;

    private Dictionary<Renderer, Material[]> originalMaterials = new Dictionary<Renderer, Material[]>();

  
    private Dictionary<Renderer, Color> originalColors = new Dictionary<Renderer, Color>();
    void Update()
{
    if (Input.GetMouseButtonDown(0))
    {
        // Ignore clicks on UI
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Transform t = hit.transform;

            while (t != null && !t.CompareTag("CarPart"))
            {
                t = t.parent;
            }

            if (t != null)
            {
                SelectPart(t.gameObject);
            }
            else
            {
                Deselect();
            }
        }
        else
        {
            Deselect();
        }
    }
}

    void Deselect()
{
    if (currentSelected != null)
    {
      
        ToggleShield(currentSelected, false);
        currentSelected = null;
    }

    UIManager.Instance.ShowDefault();
}

    void SelectPart(GameObject part)
    {
        
        if (currentSelected != null)
        {
            
            ToggleShield(currentSelected, false);
        }

        currentSelected = part;

        ToggleShield(currentSelected, true);
        
        SoundManager.Instance.PlaySelect();
        
        Debug.Log("Selected Part: " + part.name);

        UIManager.Instance.ShowPanel(part.name);
    }


    void ToggleShield(GameObject part, bool state)
{
    Renderer[] rends = part.GetComponentsInChildren<Renderer>();

    foreach (Renderer r in rends)
    {
        if (state)
        {
            // Save original materials
            if (!originalMaterials.ContainsKey(r))
            {
                originalMaterials[r] = r.materials;
            }

            // Replace ALL materials with shield
            Material[] shieldMats = new Material[r.materials.Length];

            for (int i = 0; i < shieldMats.Length; i++)
            {
                shieldMats[i] = shieldMaterial;
            }

            r.materials = shieldMats;
        }
        else
        {
            // Restore original materials
            if (originalMaterials.ContainsKey(r))
            {
                r.materials = originalMaterials[r];
            }
        }
    }
}
    public void HideCurrentShield()
    {
        if (currentSelected != null)
            ToggleShield(currentSelected, false);
    }

    public void ShowCurrentShield()
    {
        if (currentSelected != null)
            ToggleShield(currentSelected, true);
    }
}