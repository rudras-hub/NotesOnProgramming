# Primitives

## Data Structure Overview
- Data Structures refer to how you store and interact with data.
- Choosing one data structure over the other has impact on performance and resources (memory).
- Basic Types: Types with no sub-components or structure. (`int`, `char`)
- Composite Data Types: Types which are composite of basic types (`array`, `string`)
- Built-in Type: Types for which language provides built-in support.
    - Basic types + Composite Data Types.

## Primitives
[Wikipedia](https://en.wikipedia.org/wiki/Primitive_data_type):
>Primitive data type is either of the following
> - Basic Type
> - Built-in Type

- A built-in composite type _may or may not_ be a primitive, depending on the language. 
- Basic primitive type are usually faster than composite types. 
- Basic primitive types are usually value types.

### Common Primitive Types:
- Integers (`int`, `long`, `short`, `byte`)
- Floating Point Number (`single`, `double`, `decimal`)
- Fixed Point Number
- `char`
- Boolean
- Reference (pointer)

>NOTE: C# Strings are not basic they are _composed_ of chars. In Javascript strings are basic types.

>NOTE: .NET does not have a fixed point type.

### Floating Point vs Fixed Point
- __Decimal Point Representation__: _Variable vs fixed_  space allocated for integer and fraction part.
    - Float: Fixed space allocated for sign(1 bit), mantissa(23 or 52 bits) and exponent (8 or 11 bits) depending on x86 or x64 architecture.
    - Fixed: Fixed space allocated of numbers occupying left and right of decimal point. 
- __Range__: High range for floats. 
    - Exponentiation allows for ti to represent very large and vary small number.
- __Precision(Amount of information used to represent data)__: Higher precision for floating point.
- __Application__: 
    - Float: Computationally intensive application
    - Fixed: High volume general purpose application.
- __Performance__: Depends on the processor. Performing extensive floating point math with a fixed point optimized processor (or vice versa) can be problematic.     

### Binary vs Decimal Floating Point
- __Underlying Math__: Base 2 for binary vs base 10 for decimal.
- __Precision__: Decimal has better precision.
- __Performance__: Decimal calculations are order of magnitude slower than binary.
- __Memory__: Decimals take approximately twice the memory of binary.
- __Application__: Decimal for precise representations like money transactions. Binary floats for physical measurements.

>NOTE: `Single` and `Double` are binary floating type. `Decimal` is decimal floating point type.

>NOTE: `Single` or "float", as C# defines it is 32 bits. `Double` is 64 bits.

>NOTE: How are `Double` calculations then performed on an x86 architecture? By allocating two contiguous memory blocks!

### Quick points
- Most things in C# is derived from System.Object, including most primitives. But Object is not a primitive.
- Object -> Value Type or Reference Type. _Most_ primitives follow the Object -> Value Type inheritance chain. 
- Pointer types (`int*` etc) do not derive from System.Object. To treat pointer types as value types they can be converted to System.IntPtr (or UIntPtr), which derives from System.Object.
- Pointer types are _not convertible_ to Object.
- Interfaces do not derive from System.Object. But members of System.Object can be called on them, as _interfaces are convertible_ to Object.
- All non-pointer types in C# are convertible to Object.
 
