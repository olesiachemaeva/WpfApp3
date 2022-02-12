using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp3
{
    class MyCommands
    {
        public static RoutedUICommand Exit { get; set; }
        static MyCommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.T, ModifierKeys.Control, "Cntr+T"));
            Exit = new RoutedUICommand("Выход", "Exit",typeof(MyCommands),inputs);
        }
    }
}
