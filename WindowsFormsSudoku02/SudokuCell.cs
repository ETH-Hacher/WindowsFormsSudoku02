using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSudoku02
{
    class SudokuCell : Button
    {
        public int Value { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsLocked { get; set; }
        public FontFamily FontFamily { get; internal set; }

        public void Clear()
        {
            Text = string.Empty;
            IsLocked = false;
        }
    }
}
