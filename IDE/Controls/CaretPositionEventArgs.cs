namespace IDE.Controls
{
    public class CaretPositionEventArgs : EventArgs
    {
        public int Line { get; set; }
        public int Column { get; set; }

        public CaretPositionEventArgs()
        {
            
        }

        public CaretPositionEventArgs(int line, int column)
        {
            Line = line;
            Column = column;
        }
    }
}