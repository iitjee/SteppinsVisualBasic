'''

- x++ doesn't work, use x+=1

- Run without Debugging
- Console.WriteLine("Hello " + myNumberVariable.ToString)
- ToString() is sometimes called implicitly
Dim intValue As Integer = 55
Dim strValue As String = intValue

- No curly braces. Indentation as in Python
- All numeric datatypes hava a Parse() method
-No multiline comment in Vb!

- 23 Mod 2 (% operator ion other langs)
'''

Comparison Operators
x = y
x <> y
x<y x<=y

Comparing Objects: (use Is and IsNot)
Dim Reference1 as Object = New Object()
Dim Reference2 = Reference1
If Reference1 Is Reference2 Then            'True
    ..
End If

Comparing Object Types:(Use TypeOf and Is)
Dim MyString as String = New String("HellO!")
If TypeOf MyString Is System.String Then        'True
    ...
End If

- variables: 
can't start with a number. can start with alphabets and underscore. also case insensitive
eg: mystring = myString = MyString 

- declaring variables: 
'Dim' = Dimension = Declares and allocates memory for variable
'As' = sets the datatype
eg: Dim firstName As String

- Access Modifiers: 
Public, Protected, Friend, Protected Friend, Private, Shared, Shadows, Static, ReadOnly, WithEvents
When you access modifiers you can omit Dim keywd
eg: Dim Private firstName as String 
=== Private firstName as String

-Type Inference (Typeless programming)
Here, you can omit datatypes and let the compiler infer from the type of value stored
Dim value1 = 5
Dim value2 = value1 + 10

- Ends statement with a line feed(return character)
- Use _ as the 'line-continuation character' to continue a statement onto the next line
(starting with vb2010, some link breaks can be inferred without continuation character - see docs)

- Comments
Starts with '

- Literals
Boolean(depends on platform)
Short(Int16-2 bytes), UShort(Int16-2 bytes)
Integer(Int32-4 bytes), UInteger(UInt32-4 bytes)
Long(Int64-8bytes), ULong(Int64-8bytes)
Char(2), Date(8), String((depends on platform)),
Byte(1), Single(4), Double(8), Decimal(16)

Object(4bytes on 32b platform and 8 bytes on 64b platform)
VariantType  (special data type that can contain any kind of data except fixed-length String data)

    ' Default to Integer.
    Public Const DefaultInteger As Integer = 100

    ' Default to Double.
    Public Const DefaultDouble As Double = 54.3345612
    
    Dim myString As String = "Hello World"
    
    Dim myDate As Date = DateValue("November 29, 2016")

    ' Force constant to be type Char.
    Public Const MyCharacter As Char = "a"c

    ' DateTime constants.
    Public Const MyDate As DateTime = #1/15/2001#
    Public Const MyTime As DateTime = #1:15:59 AM#

    ' Force data type to be Long.
    Public Const MyLong As Long = 45L

    ' Force data type to be Single.
    Public Const MySingle As Single = 45.55!

- Type Coercion
Dim myDecimal as Decimal  
myDecimal = 100000000000000000000   ' This causes a compiler error.  
The error results from the representation of the literal. The Decimal data type can hold a value this large, but the literal is implicitly represented as a Long, which cannot.
You can coerce a literal to a particular data type in two ways: by appending a type character to it(=>at end), or by placing it within enclosing characters(=>at beginning and end).
To make the previous example work, you can append the D type character to the literal, which causes it to be represented as a Decimal:
Dim MyDecimal As Decimal = 100000000000000000000D

- Overflows
Don't make any overflow else you get a run time error
Try
    myValue+=1
    Console.WriteLine(myValue)
Catch ex As Exception
    Output(ex.Message)
End Try


/* Class Variables aka Fields   */
Public Class Person
    Public FirstName As String
    Public LastName As String
    Public Age As Integer
    Public DOB As Date
End Class










