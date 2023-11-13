using System;

namespace App3
{
    internal class Data
    {
        private double _maxValue = 30000;
        private double _minValue = 0;
        private double a = 25000;

        public double getData()
        {
            return a;
        }
        public double getPercent()
        {
            return Math.Round(a / (_maxValue - _minValue)*100);

        }
        public double getMaxValue()
        {
            return _maxValue;
        }
        public double getMinValue()
        {
            return _minValue;
        }
    }
}
