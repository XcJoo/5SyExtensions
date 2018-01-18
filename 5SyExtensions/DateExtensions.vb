Imports System.Runtime.CompilerServices

<HideModuleName()>
Public Module DateExtensions

  ''' <summary>
  ''' Returns the first day of month of the given date.
  ''' </summary>
  <Extension()>
  Public Function FirstDayOfMonth(d As DateTime) As DateTime
    d = d.RemoveTime
    d = d.AddDays(d.Day * -1 + 1)
    Return d
  End Function

  ''' <summary>
  ''' Returns the last day of month of the given date.
  ''' </summary>
  <Extension()>
  Public Function LastDayOfMonth(d As DateTime) As DateTime
    d = d.RemoveTime
    d = d.AddMonths(1)
    d = d.AddDays(d.Day * -1)
    Return d
  End Function

  ''' <summary>
  ''' Returns the the date without time.
  ''' </summary>
  <Extension()>
  Public Function RemoveTime(d As DateTime) As DateTime
    Return New DateTime(d.Year, d.Month, d.Day)
  End Function

End Module
