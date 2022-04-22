using System

namespace BinaryOp
{
    interface BinaryOperator<T> 
    {
        T call(T a, T b);
    }

    class Add<T> : BinaryOperator<T>
    {
        public T call(T a, T b) {
            dynamic a1 = a;
            dynamic b1 = b;
            return (T)(a1 + b1);
        }
    }

    class Subtract<T> : BinaryOperator<T> 
    {
        public T call(T a, T b) {
            dynamic a1 = a;
            dynamic b1 = b;
            return (T)(a1 - b1);
        }
    }
    class Muliply<T> : BinaryOperator<T> 
    {
         public T call(T a, T b) {
            dynamic a1 = a;
            dynamic b1 = b;
            return (T)(a1 * b1);
        }
    }
    class Divide<T> : BinaryOperator<T> 
    {
        public T call(T a, T b) {
            dynamic a1 = a;
            dynamic b1 = b;
            return (T)(a1 / b1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var addOp = new Add<int>();
            var subOp = new Subtract<int>();
            var mulOp = new Muliply<int>();
            var divOp = new Divide<int>();

            Console.WriteLine("Testing Add: " + addOp.call(1, 2));
            Console.WriteLine("Testing Subtract: " + subOp.call(4, 2));
            Console.WriteLine("Testing Multiply:" + mulOp.call(5,5));
            Console.WriteLine("Testing Divide: " + divOp.call(16, 2));
            Console.WriteLine("Hello World!");

        }
    }
}