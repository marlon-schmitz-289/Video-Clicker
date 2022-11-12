using System;
using System.Windows.Controls;

namespace Video_Clicker.MVVM.View.CustomControls
{
    public partial class ClickerObject : UserControl
    {
        public event Action OnClick;

        public ClickerObject()
        {
            InitializeComponent();
            HitBox.MouseDown += (sender, e) => OnClick?.Invoke();
        }
    }
}
