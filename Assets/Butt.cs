using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class Butt : MonoBehaviour
{


    public void OnClick()
    {
        var enLoc = LocalizationSettings.AvailableLocales.GetLocale("en");
        var esLoc = LocalizationSettings.AvailableLocales.GetLocale("es");

        if (LocalizationSettings.SelectedLocale = enLoc)
        {
            LocalizationSettings.SelectedLocale = esLoc;
        }
        else
        {
            LocalizationSettings.SelectedLocale = enLoc;
        }

    }
}