﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Graphene.ViewModel;

namespace Graphene.Demo
{
  public abstract class GenericModelBehaviour<T> : MonoBehaviour, IModel
  {
    [field:SerializeField][Bind("Title")]
    protected string title { get; set; }
    
    [field: SerializeField]
    [Bind("Render")]
    public bool Render { get; set; } = true;

    [Draw(ControlType.ListItem)]
    [SerializeField]
    protected List<T> items = new List<T>();

    public abstract List<T> Items { get; }
    public System.Action onModelChange { get; set; }

    public abstract void Initialize(VisualElement container, Plate plate);
  }

  public class GenericModelBehaviour : GenericModelBehaviour<BindableObject>
  {
    public override List<BindableObject> Items => items;

    public override void Initialize(VisualElement container, Plate plate)
    {
    }
  }
}
