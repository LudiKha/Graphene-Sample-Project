using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Graphene.ViewModel;

namespace Graphene.Demo
{
  public abstract class GenericModelForm<T> : Form
  {
    [Draw(ControlType.ListItem)]
    public List<T> model = new List<T>();
  }

  [CreateAssetMenu(menuName = "UI/Forms/GenericModelForm")]
  public class GenericModelForm : GenericModelForm<BindableObject>
  {
    public override void Initialize(VisualElement container, Plate plate)
    {
    }
  }
}
