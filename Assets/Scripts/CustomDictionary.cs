using System.Collections.Generic;

abstract class CustomField
{
    // Don't allow external code to inherit from this type.
    internal CustomField() { }
     
    // These readonly static fields will end up behaving essentially
    // like enum values.
    public static readonly CustomField<string> Name = new CustomField<string>();
    public static readonly CustomField<int> Value = new CustomField<int>();
}
 
sealed class CustomField<T> : CustomField
{
    // Don't allow external code to instantiate this type.
    internal CustomField() { }
}
 
class CustomDictionary
{
    // The keys of this internal dictionary are restricted to only certain values
    // (Name, Value), just like enum keys would be... but they will ALSO provide
    // type information.
    Dictionary<CustomField, object> _fields = new Dictionary<CustomField, object>();
     
    public void Set<T>(CustomField<T> key, T value)
    {
        // Since this is the only place where a value can be set...
        _fields[key] = value;
    }
     
    public T Get<T>(CustomField<T> key)
    {
        // ...this unboxing operation is safe (so long as the key exists)...
        return (T)_fields[key];
    }
     
    public bool TryGet<T>(CustomField<T> key, out T value)
    {
        object valueObject;
        if (_fields.TryGetValue(key, out valueObject))
        {
            // ...as is this.
            value = (T)valueObject;
            return true;
        }
         
        value = default(T);
        return false;
    }
}