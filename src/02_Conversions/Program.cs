/*
 * Module: 02_Conversions
 * Objective: Understand string-to-numeric conversions
 * and global thread culture.
 * * Key Architectural Concepts:
 * - Instead of passing CultureInfo to every single Parse() 
 * and ToString() method, we override the CurrentCulture
 * of the entire application thread.
 * This ensures consistent input/output behavior
 * (e.g., using '.' for decimals) globally, 
 * decoupling the app from the host OS regional settings.
 * - Strict Parsing: type.Parse() ensures explicit conversion
 * and throws errors on bad data, avoiding the silent
 * failure trap of Convert.ToX(null).
 */

using System.Globalization;

// We force the entire application to use the universal standard from line 1.
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

// Basic Conversions using the Convert class
string textAge = "23";
int age = Convert.ToInt32(textAge);
Console.WriteLine("int (convert): " + age);

string textBigNumber = "90000000000";
long bigNumber = Convert.ToInt64(textBigNumber);
Console.WriteLine("long (convert): " + bigNumber);

// Separator
Console.WriteLine(new string('-', 20));

// Strict Conversions using Parse
string textNegative = "-52.2";
double negative = double.Parse(textNegative);
Console.WriteLine("double (parse): " + negative);

string textPrecision = "5.00001";
float precision = float.Parse(textPrecision);
Console.WriteLine("float (parse): " + precision);

string textMoney = "14.99";
decimal money = decimal.Parse(textMoney);
Console.WriteLine("decimal (parse): " + money);
