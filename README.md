# Learning C#

A personal repository dedicated to deepening my knowledge of C# and the .NET ecosystem. This serves as a practical log of my learning journey.

## Module Index

* **`src/01_DataTypes`**: Exploration of C# primitive data types. Covers numeric types (int, long, double, float, decimal) and text types (string, char), and booleans (bool). Demonstrating their memory boundaries (`MaxValue`/`MinValue`), the use of literal suffixes (`L`, `F`, `M`), and the architectural reality of byte-aligned memory addressing for single-bit logical states.

* **`src/02_Conversions`**: String-to-numeric conversions. Covers the architectural differences between the `Convert` class and strict `type.Parse()` methods, highlighting the global injection of `CultureInfo.InvariantCulture` to prevent regional formatting crashes.