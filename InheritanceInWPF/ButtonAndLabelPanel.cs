using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace InheritanceInWPF
{
    class ButtonAndLabelPanel : StackPanel
    {
        private int _clicks = 0;
        private Label _label;

        public ButtonAndLabelPanel()
        {
            var button = new Button { Content = "Hei" };
            Children.Add(button);
            button.Click += ButtonClick;
            _label = new Label() { Content = "Hei" };
            Children.Add(_label);
        }

        private void ButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            _clicks++;
            _label.Content = _clicks;
        }
    }
}
