/*
'break' in other langs == use 'exit' keyword

*/



If str1 = str2 AndElse x<>y Then 'Remember AndElse will shortckt whereas just And won't.   Also you can use x Not y instead of x<>y
  ...
ElseIf x>y
  ...
Else
  ...
End If


Select Case x
  Case "FirstCase"
    ...
  Case "SecondCase"
    ...
  Case Else
    ...
    Return
End Select
  


For myCountIndex As Integer = 1 To 3
  ...
Next

For Each name As String In listOfNames
  ....
Next

While myCount<=3
  ...
End While



Do 
  ...
Loop Until myCount<=3
  ...

