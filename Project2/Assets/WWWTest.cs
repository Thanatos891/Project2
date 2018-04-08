using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WWWTest : MonoBehaviour
{
    //make a string to hold the url for the website. 
    string testUrl = "https://vignette.wikia.nocookie.net/plantsvszombies/images/c/c9/Angry_Kirby_Crouching_Super_Star_Ultra_Artwork.png/revision/latest?cb=20160825110511";
    //add in a texture2D variable to use the img as a texture
    //setting things to null keeps warning of no reference showing up. 
    Texture2D testTexture;
   public RawImage testImage = null;
    

    // Use this for initialization
    void Start()
    {
        StartCoroutine(ImgLoader());
    }
    // Update is called once per frame
    IEnumerator ImgLoader()
    {
        yield return null;
        // call the WWW declarer
        WWW imgLink = new WWW(testUrl);
        yield return imgLink;
        testTexture = imgLink.texture;
        testImage.texture = testTexture as Texture2D;
    }
}
