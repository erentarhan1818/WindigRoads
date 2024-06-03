using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GroundColorcontroller : MonoBehaviour
{
    [SerializeField] private Material groundMaterial;

    [SerializeField] private Color[] colors;

    private int colorIndex = 0;
    [SerializeField] private float lerpValue; //lerp value min ve max değerler döndürür.

    [SerializeField] private float time;

    private float currentTime; //oyun zamanını yönetmek için kullanılan bir sınıftır CURRENT TİME.

    private void Update()

    {
        SetColorChangeTime();
        SetGroundMaterialSmoothColorChange(); //smooth = pürüzsüz
        
    }   


        private void SetColorChangeTime() //zamanlayıcı
        {
            if(currentTime <= 0)
            {
                CheckColorIndexValue();
                currentTime = time;
            }
            else{
                currentTime -= Time.deltaTime;
            }
        }

        private void CheckColorIndexValue()
        {
            colorIndex++;

            if(colorIndex >= colors.Length)
            {
                colorIndex = 0;
            }
        }
        private void SetGroundMaterialSmoothColorChange()
        {
            groundMaterial.color = Color.Lerp(groundMaterial.color, colors[colorIndex],lerpValue *Time.deltaTime);
        }
        private void OnDestroy() //ondestroy = yok edildiğinde demek
        {
            groundMaterial.color =colors[1];
        }
        
}
