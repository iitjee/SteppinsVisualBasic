


' Date(belongs to VB) is an alias for DateTime object(belongs to .NET)

Dim d1 As Date = new Date(2012, 1, 13) 'click arrows in drop-down auto completion
Dim d2 As Date = #11/28/1974# 'Date literal method
Dim d3 As Date = Date.parse("11/28/1913") or Date.parse("11/28/13") 'using this we can write 1913 as 13 as well
Date dt1 As Date = Date.parse("November 28, 2013 11:10am")
Date strDate1 As String = Format(dt1, "MMM dd, yyyy")
Console.WriteLine(d1.ToString)

' Properties
Date.Today 'Console.WriteLine(Format(Date.Today, "MMM dd"))
d1.ToString

'Methods:
d1.AddDays(1)
d1.AddMonths(1)
