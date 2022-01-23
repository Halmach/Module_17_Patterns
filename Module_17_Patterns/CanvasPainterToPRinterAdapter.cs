namespace Module_17_Patterns
{
    public class CanvasPainterToPRinterAdapter : IPrinter
    {
        private CanvasPainter _canvasPainter;
        public CanvasPainterToPRinterAdapter(CanvasPainter canvasPainter)
        {
            _canvasPainter = canvasPainter;
        }

        public void Print()
        {
            _canvasPainter.Paint();
        }
    }
}