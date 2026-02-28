/*
 * Module: 01_DataTypes
 * Objective: Understand the foundational primitive types in C# and
 * their architectural purpose.
 * * Key Architectural Concepts:
 * - Value Types vs. Reference Types: Most primitives here are
 * structs (Value Types, Stack-allocated), except 'string', which is
 * an object (Reference Type, Heap-allocated).
 * - Compiler Type Inference: Literal suffixes (L, F, M) are
 * mandatory to prevent the compiler from defaulting to Int32 or Double.
 * - Precision vs. Performance (The Double vs Decimal trap): 
 * > float/double: Base-2 (binary) floating-point. Fast, but introduces
 * rounding errors in Base-10 fractions (e.g., 0.1 + 0.2 != 0.3).
 * Used for physics, graphics, and scientific math.
 * > decimal: Base-10 arithmetic. Slower and consumes more memory (16 bytes),
 * but guarantees absolute precision. Strictly mandatory for
 * financial/currency calculations.
 */

// NUMERIC data types in C#

int age = 23;
Console.WriteLine("int: " + age);
Console.WriteLine("int: " + int.MaxValue);
Console.WriteLine("int: " + int.MinValue);

// Adding an 'L' to the end of a long number
// so that C# understands that it is a long number
// an Int64 and not an Int32
long bigNumber = 900000000L;
Console.WriteLine("long: " + bigNumber + " long");
Console.WriteLine("long: " + long.MaxValue);
Console.WriteLine("long: " + long.MinValue);

double negative = -52.2;
Console.WriteLine("double: " + negative);
Console.WriteLine("double: " + double.MaxValue);
Console.WriteLine("double: " + double.MinValue);

// Using the same concept as above, without the 'F' it is treated
// as a double, we put 'F' so the compiler knows
// that it is a float
float precision = 5.00001F;
Console.WriteLine("float: " + precision);
Console.WriteLine("float: " + float.MaxValue);
Console.WriteLine("float: " + float.MinValue);

// Same concept as the previous data.
// Specify with an 'M' to indicate that it is a decimal
decimal money = 14.99M;
Console.WriteLine("decimal: " + money);
Console.WriteLine("decimal: " + decimal.MaxValue);
Console.WriteLine("decimal: " + decimal.MinValue);

// Skip line
Console.WriteLine();
// -------------------------------------
// -------------------------------------

// TEXT data types in C#

string name = "Pedro";
char letter = 'p';  // The CHAR data type only supports ONE character

Console.WriteLine("string: " + name);
Console.WriteLine("char: " + letter);