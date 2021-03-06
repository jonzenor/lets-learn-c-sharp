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
  - BOOL cannot store 1/0, only true/false
  - Char must be set with single quotes instead of double because reasons?

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
 - Output with WriteLine("{0}",<input variable name>);
 - Use var names inside the writeline by starting with $: WriteLine($"{varName} is my variable");

8. Console properties
 - Console.ForegroundColor = ConsoleColor.Blue; // Changes the text color. Also BackgroundColor for the BG.
 - Console.Clear(); // Clears the console text.

9. There is no power operator in C#... ^ is an "exclusive or" operator, and ** does not exist in C#.

10. Methods
 - <Access Specifier> [Static] <Return Type> <Method Name>(Parameter List) { <Method Body> }
 - Access Specifier == Determines the visibility of a variable or method from another class
 - Static == Belongs to the type itself instead of to a specific object.
 - Return Type == The data type of the value the method returns. Or Void for no return value.

11. Try and catch blocks
 - try { int myInt = int.Parse(stringThatIsNotANumber); } catch (Exception ex) { cw("You failed to follow directions.) cw(ex.ToString()); }
 - If you hover over the method, it tells you the types of exceptions that you can expect. You can call that exception directly.
 - - ... catch (FormatException) { cw("This is one of the exceptions from int.Parse"); } catch (Exception ex) { cw("Generic catch all statement."); }
 - Finally is used at the end of the try/catch block, and runs if there was an error or not. Can be used to close out a file you opened or a remote connection.
 - - try { } catch () { } finally { }
 - Throw is used to throw the exception and end the program.
 - - ... catch (Exception ex) { throw; }

12. Loops
 - Do vs while, do loop always runs at least once, then exits if the condition isn't met. While checks the statement first, before running the code.
 - break; will exit out of the loop.
 - continue; will skip the rest of this iteration of the loop and start the loop again at the next iteration.

13. Objects
 - Objects can be used as data types
 - The constructor is a public method in the class that has the same name as the class, and no return type.
 - You use this. to refer to "global" properties set in the class
 - You can have multiple constructors. One without parameters and then several with different parameters. They all share the same constructor class name.
 - You can create your own exceptions with: throw new Exception("I take exception to what you did");
 - Can only create one destructor
 - Destructors start with a tilde (~) and have no public/private properties before it
 - - Cannot be called, only called when it "runs out of scope". Used to clean up statements.
 - - Don't make them unless it's needed.

14. Properties
 - Properties are similar to variables, but are more involved
 - The standard convention is to start a property with a capital letter (variables typically start with a lowercase)
 - Properties include a getter and setter
 - Set properties with the value keyword in the setter
 - Quick way: public string FirstName { get; set; }
 - - When using the quick way you do not need a member variable to store the information in

15. Arrays
 - An array is limited to a single type at a time
 - Created with dataType[] arrayName = new dataType[# of entries]
 - - int[] myArray = new int[5];
 - You can assign them at the same time with a CSV list: int[] myArray = {0,51,12,43};
 - Length is a property of the array.
 - An array can be ANY data type... including an object. Player[] players = { player1, player2 }; // This totally worked! players[0].Name accesses the player1.Name property

16. Multi-Dimensional Arrays
 - These are definitely more confusing than in PHP
 - This is more like a matrix list than an array of arrays that we are used to in PHP
 - Every element of the array must be the same size. So if element 0 has 3 rows, then element 1 must also have 3 rows.
 - The Rank property of the array shows how many dimensions it has.
 - You do not need to specify the number of elements in the array when you initilize it, only the number of dimensions.
 - .length property of the array is the total number of elements, not total number of the first dimension, use GetLength(0).

17. Multi-Dimensional ForEach
 - You can use a single foreach loop to get every element of a multi-dimensional array
 - - The variable that is storing that item, is read only. You cannot change it to change what is stored in the array
 - - It will loop through every item in order, no matter the row/column element it is in
 - Nested for loop (instead of foreach) to create references to the row/column properly, and then you can change the value since you're referencing the array itself
 - You can use TWO counter variables with a single for loop...
 - - This is not used very often at all and can look quite confusing.

18. Terenary Operator
 - Only used to assign variables, not to execute a method or anything like that.

## Start A Project ##

In VS Code:

In the Create a new project window, select All languages, and then choose C# from the dropdown list. Choose Windows from the All platforms list, and choose Console from the All project types list.

After you apply the language, platform, and project type filters, choose the Console App template, and then select Next.

## Turn a project into an executable script on Mac OS ##
1. cd to the directory containing the project file (.sln)
2. Run dotnet publish -r osx-x64 ./<file>.sln
3. cd to the publish directory that was created by the script (read the output...)
4. ./<file that matches the project name>