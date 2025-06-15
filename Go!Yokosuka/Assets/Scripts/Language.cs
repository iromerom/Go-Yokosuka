using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

// IVAN ROMERO MOYANO //

public class Language : MonoBehaviour
{
    // Variable para controlar si ya estamos cambiando el idioma o no
    private bool active = false;

    // Método público para cambiar el idioma
    public void ChangeLocale(int localeID)
    {
        // Si ya estamos cambiando el idioma, no hacemos nada
        if (active == true)
            return;

        // Iniciamos el cambio de idioma en una corrutina
        StartCoroutine(SetLocale(localeID));
    }

    // Método que cambia el idioma en segundo plano (corrutina)
    IEnumerator SetLocale(int _localeID)
    {
        // Esperamos a que se complete la inicialización de la localización
        yield return LocalizationSettings.InitializationOperation;

        // Cambiamos el idioma a la localización seleccionada por su ID
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_localeID];

        // Marcamos como inactivo el proceso de cambio de idioma
        active = false;
    }
}
