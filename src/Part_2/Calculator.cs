namespace Part_2
{
    public class Calculator
    {
        private readonly double _variableA;
        private readonly double _variableB;
        private readonly char _operation;

        public Calculator(double variableA, double variableB, char operation)
        {
            _variableA = variableA;
            _variableB = variableB;
            _operation = operation;
        }

        public double Calculate()
        {
            double result;

            switch (_operation)
            {
                case '+':
                    result = _variableA + _variableB;
                    break;
                case '-':
                    result = _variableA - _variableB;
                    break;
                case '*':
                    result = _variableA * _variableB;
                    break;
                case '/':
                    if (_variableB == 0)
                    {
                        throw new DivideByZeroException("LEARN MATH, BEFORE USING THIS PROGRAM");
                    }
                    result = _variableA / _variableB;
                    break;
                default:
                    throw new InvalidOperationException($"Open your eyes and type valid operation :): {_operation}");
            }
            return result;
        }
    }
}