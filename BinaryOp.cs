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

        }
    }
}