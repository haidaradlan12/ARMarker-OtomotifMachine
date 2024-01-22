using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform MenuGearAtas, MenuGearBawah, MenuLogoTengah, MenuButton, MenuLogoKanan, MenuProfil, MenuPetunjuk, MenuSKKD, MenuMateri1, MenuMateri2, MenuMateri3, MenuMateri4, MenuMateri5, MenuMateri6, MenuButtonMateri, MenuS1, MenuS2, MenuS3, MenuS4, MenuS5, MenuS6, MenuS7, MenuS8, MenuS9, MenuS10;
    // Start is called before the first frame update
    void Start()
    {
        MenuGearAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGearBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLogoTengah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLogoKanan.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuSKKD.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(1500,0), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(1500,0), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(1500,0), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(1500,0), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(1500,0), 1.0f);
        MenuMateri6.DOAnchorPos(new Vector2(1500,0), 1.0f);
        MenuButtonMateri.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS7.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS9.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS10.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void MenuProfilbutton()
    {
        MenuGearAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGearBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLogoTengah.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuLogoKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuSKKD.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuButtonMateri.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS7.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS9.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS10.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void MenuPetunjukbutton()
    {
        MenuGearAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGearBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLogoTengah.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuLogoKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuSKKD.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuButtonMateri.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS7.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS9.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS10.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void MenuSKKDbutton()
    {
        MenuGearAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGearBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLogoTengah.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuLogoKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuSKKD.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuButtonMateri.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS7.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS9.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS10.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void MenuSoal1()
    {
        MenuGearAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGearBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLogoTengah.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuLogoKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuSKKD.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuButtonMateri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuS1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS7.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS9.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS10.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void MenuSoal2()
    {
        MenuGearAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGearBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLogoTengah.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuLogoKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuSKKD.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuButtonMateri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuS1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS7.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS9.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS10.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void MenuSoal3()
    {
        MenuGearAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGearBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLogoTengah.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuLogoKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuSKKD.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuButtonMateri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuS1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS7.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS9.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS10.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void MenuSoal4()
    {
        MenuGearAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGearBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLogoTengah.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuLogoKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuSKKD.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuButtonMateri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuS1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS7.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS9.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS10.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void MenuSoal5()
    {
        MenuGearAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGearBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLogoTengah.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuLogoKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuSKKD.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuMateri6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuButtonMateri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuS1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS7.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS9.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS10.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void MenuSoal6()
    {
        MenuGearAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGearBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLogoTengah.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuLogoKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuSKKD.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuMateri6.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButtonMateri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuS1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS7.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS9.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS10.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void MenuS1Button()
    {
        MenuGearAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGearBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLogoTengah.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuLogoKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuSKKD.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuButtonMateri.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuS2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS7.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS9.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS10.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void MenuS2Button()
    {
        MenuGearAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGearBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLogoTengah.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuLogoKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuSKKD.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuButtonMateri.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuS3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS7.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS9.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS10.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void MenuS3Button()
    {
        MenuGearAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGearBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLogoTengah.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuLogoKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuSKKD.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuButtonMateri.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS2.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS3.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuS4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS7.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS9.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS10.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void MenuS4Button()
    {
        MenuGearAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGearBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLogoTengah.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuLogoKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuSKKD.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuButtonMateri.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS2.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS3.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS4.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS7.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS9.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS10.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void MenuS5Button()
    {
        MenuGearAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGearBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLogoTengah.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuLogoKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuSKKD.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuButtonMateri.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS2.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS3.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS4.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS5.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuS6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS7.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS9.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS10.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void MenuS6Button()
    {
        MenuGearAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGearBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLogoTengah.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuLogoKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuSKKD.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuButtonMateri.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS2.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS3.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS4.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS5.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS6.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuS7.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS9.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS10.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void MenuS7Button()
    {
        MenuGearAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGearBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLogoTengah.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuLogoKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuSKKD.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuButtonMateri.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS2.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS3.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS4.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS5.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS6.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS7.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuS8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS9.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS10.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void MenuS8Button()
    {
        MenuGearAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGearBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLogoTengah.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuLogoKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuSKKD.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuButtonMateri.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS2.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS3.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS4.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS5.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS6.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS7.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS8.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuS9.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS10.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void MenuS9Button()
    {
        MenuGearAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGearBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLogoTengah.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuLogoKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuSKKD.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuButtonMateri.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS2.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS3.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS4.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS5.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS6.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS7.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS8.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS9.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuS10.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void MenuS10Button()
    {
        MenuGearAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGearBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLogoTengah.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuLogoKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuSKKD.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuButtonMateri.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS2.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS3.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS4.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS5.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS6.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS7.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS8.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS9.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuS10.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
    public void MenuKembalibutton()
    {
        MenuGearAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGearBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLogoTengah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLogoKanan.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuSKKD.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuMateri6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuButtonMateri.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS7.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS9.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuS10.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
}
