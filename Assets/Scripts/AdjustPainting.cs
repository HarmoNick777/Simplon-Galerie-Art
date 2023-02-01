using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustPainting : MonoBehaviour
{
    [SerializeField] GameObject paintingFrame;
    [SerializeField] float maxDimensionUnits = 2; //taille voulue du tableau en unit�s de longueur Unity sur son c�t� le plus large
    SpriteRenderer importedPainting;
    bool portrait;
    float localBoundsWidth;
    float localBoundsHeight;
    float borderWidth = 8f; //on d�cale le cadre en largeur et en hauteur pour que le tableau tout entier rentre dans le cadre
    float ratio;
    float rescaleFactor;
    float newFrameScaleWidth;
    float newFrameScaleHeight;
    float frameImportScaleFactor = 0.8f; // scale factor du cadre PaintingFrame import� et utilis� dans le pr�fab

    void Start()
    {
        importedPainting = GetComponent<SpriteRenderer>();
        localBoundsWidth = importedPainting.localBounds.size.x; // largeur du tableau en unit�s de longeur Unity
        localBoundsHeight = importedPainting.localBounds.size.y; // hauteur du tableau en unit�s de longeur Unity
        portrait = localBoundsWidth <= localBoundsHeight; //portrait est true si le tableau est au format portrait, false s'il est au format paysage
        ratio = localBoundsWidth / localBoundsHeight; // rapport largeur sur hauteur
        
        rescaleFactor = portrait ? localBoundsHeight / maxDimensionUnits : localBoundsWidth / maxDimensionUnits; // on resize le tableau pour que son c�t� le plus grand prenne 2 unit�s de longueur Unity
        transform.localScale /= rescaleFactor;
        newFrameScaleWidth = portrait ? 100f / frameImportScaleFactor * ratio + borderWidth : 100f / frameImportScaleFactor + borderWidth * ratio;
        newFrameScaleHeight = portrait ? 100f / frameImportScaleFactor + borderWidth : 100f / frameImportScaleFactor / ratio + borderWidth / ratio;
        paintingFrame.transform.localScale = new Vector3(paintingFrame.transform.localScale.x, newFrameScaleWidth, newFrameScaleHeight); // on resize le cadre pour qu'il entoure parfaitement le tableau
    }

    void Update()
    {
        
    }
}