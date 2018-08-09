﻿using UnityEngine;
using UnityEngine.UI;

public class UiCategory : MonoBehaviour 
{
    #region FIELDS

    [SerializeField] private Text _description;
    //[SerializeField] private Image _icon;

    private Category _category;

    #endregion

    public void Setup(Category category)
    {
        _category = category;
        _description.text = _category.Description;
    }

    public void Select()
    {
        if (HubContentLoader.Instance)
        {
            HubContentLoader.Instance.SelectCategory(_category);
        }
    }
}
