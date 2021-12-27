# My C# Notes #

1. Concatinate with PLUS: var + var

2. Plus Equals to add to a variable: TotalPrice += tax;
 - This is called a Compound Assignment Operator and works with all basic math opertors (+*/-)

3. The increment operator can be used before the variable (i.e. ++ThisVar) instead of just after the variable (ThisVar++)
 - This can make a difference with the order that is used.
 - - A = B++ will assign B's value to A, and then will increment B.
 - - A = ++B will increment B, and then assign the new value of B to A.

4. You can check for if an arithmatic calculation results in an overflow or not using the CHECKED() function.
 - checked(X *= X);
 - - This will throw an exception if an overflow happens.
 - You can also use it with multiple lines
 checked
 {
     CALC1 *= X;
     CALC2 *= X;
 }
 - This function is performance intensive

5. Data Types [signed, unsigned]: 8 bit numbers [sbyte, byte], 16 bit numbers [short, ushort], 32 bit numbers [int, uint], 64 bit numbers [long, ulong]
 - The compiler will automatically convert the type to a higher type if needed during mathematical operations involving multiple data types. This happens before the calculation happens, so before over/underflow can happen.
 - If you are adding an int and uint together, DC# will implicitly convert each number to a long for the operation, because that's the only data type that can hold all of the possible values. This means you need to make sure the result is being stored in a long object type, and not an int or uint, or you will get a compile error.
 - You cannot perform operations using a long and ulong, because there are no data types large enough to hold every possible value, so this is a compile error.
 - You can explicitley "cast" a type to another type for the purposes of an operation. This does not change the type of the stored value, but only what it counts as during the mathematical operation. i.e. (short) MYVAR + (short) MYVAR2 or (short) (MYVAR + MYVAR2).
  - Casting may result in bits being lost, though. So be careful. This will only throw an error if you have overflow checking turned on.

6. Strings cannot be broken up into multiple lines.
 - You can use the addition assignment operator with strings. string C = "Hello"; C += " World";
 - Strings have a .Length property.
 - Escape all charactesr with a verbatim string. @"This is a bunch of ""text"" for no reason.";
 - When concatinating text with numbers, pay attention to the order of operations and remember that the compiler will implicitely convert variable types to match what it thinks is needed.
 - - WriteLine(A + B + " is the sum of A and B"); works like expected
 - - WriteLine("The sum of A and B is " + A + B); will convert the int to string and display the full numbers concatinated together instead of adding them.

7. Console Reads
 - Console.Read returns an int, which is the ASCII value. This messes with future inputs and is weird.
 - Console.ReadLine returns the string that was entered.
 - Output with WriteLine("{0}",<input variable name>)

8. Console properties
 - Console.ForegroundColor = ConsoleColor.Blue; // Changes the text color. Also BackgroundColor for the BG.
 - Console.Clear(); // Clears the console text.

9. There is no power operator in C#... ^ is an "exclusive or" operator, and ** does not exist in C#.

10. Methods
 - <Access Specifier> <Return Type> <Method Name>(Parameter List) { <Method Body> }
 - Access Specifier == Determines the visibility of a variable or method from another class
 - Return Type == The data type of the value the method returns. Or Void for no return value.

## Start A Project ##

In VS Code:

In the Create a new project window, select All languages, and then choose C# from the dropdown list. Choose Windows from the All platforms list, and choose Console from the All project types list.

After you apply the language, platform, and project type filters, choose the Console App template, and then select Next.

## Turn a project into an executable script on Mac OS ##
1. cd to the directory containing the project file (.sln)
2. Run dotnet publish -r osx-x64 ./<file>.sln
3. cd to the publish directory that was created by the script (read the output...)
4. ./<file that matches the project name>