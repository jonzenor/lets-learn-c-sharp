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


## Start A Project ##

In VS Code:

In the Create a new project window, select All languages, and then choose C# from the dropdown list. Choose Windows from the All platforms list, and choose Console from the All project types list.

After you apply the language, platform, and project type filters, choose the Console App template, and then select Next.
