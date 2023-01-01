namespace ResourceCalc
{
    public class ResourceCalculator
    {
        public static int ResPlus(int _currentCount, int _neededToPlus)
        {
            _currentCount += _neededToPlus;
            return _currentCount;
        }

        public static int ResMinus(int _currentCount, int _neededToMinus)
        {
            _currentCount -= _neededToMinus;
            if (_currentCount < 0)
            {
                _currentCount = 0;
            }
            return _currentCount;
        }
    }
}

