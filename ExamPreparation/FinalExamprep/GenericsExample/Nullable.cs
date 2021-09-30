﻿namespace GenericsExample
{
    public class Nullable<T> where T:struct
    {
        public object _value;
        public Nullable()
        {

        }
       public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;
            else
                return default(T);
        }
    }
}
