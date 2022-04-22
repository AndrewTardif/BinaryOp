using System

namespace BinaryOp
{
    interface BinaryOperator<T> 
    {
        T call(T a, T b);
    }

    class Add<T> : BinaryOperator<T>
    {

    }

    class Subtract<T> : BinaryOperator<T> 
    {

    }
    class Muliply<T> : BinaryOperator<T> 
    {

    }
    class Divide<T> : BinaryOperator<T> 
    {

    }
}