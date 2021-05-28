using System;
using System.Windows;
using System.Windows.Controls;

namespace InheritanceInWPF
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var application = new Application();
            var window = new Window();
            var panel1 = new ButtonAndLabelPanel();
            var panel2 = new ButtonAndLabelPanel();
            var panel3 = new ButtonAndLabelPanel();

            var panel = new StackPanel();
            panel.Children.Add(panel1);
            panel.Children.Add(panel2);
            panel.Children.Add(panel3);
            window.Content = panel;
            application.Run(window);
        }
    }
}
