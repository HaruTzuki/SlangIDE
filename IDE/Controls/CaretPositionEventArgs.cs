namespace IDE.Controls
{
    public class CaretPositionEventArgs : EventArgs
    {
        public int Line { get; set; }
        public int Column { get; set; }
        public int Position { get; set; }

        public CaretPositionEventArgs()
        {
            
        }

        public CaretPositionEventArgs(int line, int column, int position)
        {
            Line = line;
            Column = column;
            Position = position;
        }
    }
}