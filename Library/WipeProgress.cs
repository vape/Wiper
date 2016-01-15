namespace Wiper.Library
{
    public struct WipeProgress
    {
        public double Progress
        {
            get;
            private set;
        }

        public int PercentProgress
        {
            get
            {
                return (int)(Progress * 100);
            }
        }
        
        public WipeProgress(long position, long length)
        {
            Progress = ((double)position) / length;
        }
    }
}
