using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedConcepts.Generics
{
    class CompareValue
    {
        //constraints can be set at class level, for example:
        // CompareValue<T> where T: Icomparable
        //However, then you have to specify a single value type like int or float
        //by doing it at the method level we can compare different value types
        //T stands for template
        //notice how we can have multiple parameters specificied with T
        //The Where T, is a constraint that requires the object
        //type to have implemented the IComparable interface

        //        Constraint types
        //where T: IComparable
        //where T: Product
        //where T:  struct (value type)
        //where T:  class
        //where T:  new() (T implements a new constructor)

        //we must have a return type T because we don't know the return type
        //this constraints requires each type to implement IComparable interface
        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;

        }

        public void DoSomething<T>(T InputValue) where T : new()
        {
            //this is possible because we added the new constraint
            var obj = new T();

        }
    }

    //this class uses generics to provide support
    //for null to value types like int and double
    public class Nullable<T> where T : struct
    {
        readonly private object _value;

        public bool HasValue
        {
            get { return _value != null; }
        }

        public Nullable()
        {

        }
        public Nullable(T InputValue)
        {
            _value = InputValue;

        }

        public T GetValueOrDefault()
        {
            if (HasValue)
            {
                return (T)_value;
            }
            else
            {
                return default(T);
            }
        }

    }
}
