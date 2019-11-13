using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class KeyEventArgs : EventArgs
{
    public char KeyPressed { get; }
    public KeyEventArgs(char keyPressed)
    {
        KeyPressed = keyPressed;
    }
}
