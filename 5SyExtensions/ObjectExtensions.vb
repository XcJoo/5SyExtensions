Imports System.Runtime.CompilerServices

<HideModuleName()>
Public Module ObjectExtensions

  ''' <summary>
  ''' Returns True if one value of ParamArray <paramref name="range"/> matches.
  ''' </summary>
  <Extension()>
  Public Function [In](Of T)(ByVal item As T, ByVal ParamArray range() As T) As Boolean
    Return range.Cast(Of T).Contains(item)
  End Function

  ''' <summary>
  ''' Returns True if one value of List <paramref name="range"/> matches.
  ''' </summary>
  <Extension()>
  Public Function [In](Of T)(ByVal item As T, ByVal range As List(Of T)) As Boolean
    Return range.Cast(Of T).Contains(item)
  End Function

  ''' <summary>
  ''' Returns True if the String <paramref name="item"/> contains one value of ParamArray <paramref name="range"/> matches.
  ''' </summary>
  <Extension()>
  Public Function [InContains](ByVal item As String, ByVal ParamArray range() As String) As Boolean
    For Each ra In range.Cast(Of String)()
      If item.Contains(ra) Then Return True
    Next
    Return False
  End Function

  ''' <summary>
  ''' Returns True if the String <paramref name="item"/> contains one value of List <paramref name="range"/> matches.
  ''' </summary>
  <Extension()>
  Public Function [InContains](ByVal item As String, ByVal range As List(Of String)) As Boolean
    For Each ra In range.Cast(Of String)()
      If item.Contains(ra) Then Return True
    Next
    Return False
  End Function

  ''' <summary>
  ''' Returns True if a value of list <paramref name="item"/> contains one value of List <paramref name="range"/> matches.
  ''' </summary>
  <Extension()>
  Public Function [InContains](Of T)(ByVal item As List(Of T), ByVal range As List(Of T)) As Boolean
    If (From i In item Join r In range.Cast(Of T)() On i Equals r).Count > 0 Then Return True
    Return False
  End Function

  ''' <summary>
  ''' Returns <paramref name="DefaultValue"/> if <paramref name="FindKey"/> is not in <paramref name="item"/> else <typeparamref name="TValue"/> is returned.
  ''' </summary>
  <Extension()>
  Public Function TryGetValWithDefault(Of TKey, TValue)(item As IDictionary(Of TKey, TValue), FindKey As TKey, DefaultValue As TValue) As TValue
    Return If(item IsNot Nothing AndAlso item.ContainsKey(FindKey), item(FindKey), DefaultValue)
  End Function

  ''' <summary>
  ''' Inserts or Updates an <typeparamref name="TKey"/> and <typeparamref name="TValue"/> in <paramref name="item"/>.
  ''' </summary>
  <Extension()>
  Public Sub [InsertOrUpdate](Of TKey, TValue)(ByVal item As IDictionary(Of TKey, TValue), Key As TKey, Value As TValue)
    If item.ContainsKey(Key) Then
      item(Key) = Value
    Else
      item.Add(Key, Value)
    End If
  End Sub

  ''' <summary>
  ''' Returns <paramref name="DefaultValue"/> when <paramref name="Value"/> is Nothing or DbNull.Value.
  ''' </summary>
  <Extension()>
  Public Function [IfNothingNull](Of T)(Value As Object, DefaultValue As T) As T
    If Value Is Nothing OrElse Value Is DBNull.Value Then
      Return DefaultValue
    Else
      Return Value
    End If
  End Function

  ''' <summary>
  ''' Returns Nothing when <paramref name="Value"/> equals <paramref name="TestValue"/>.
  ''' </summary>
  <Extension()>
  Public Function NothingIf(Value As Object, TestValue As Object) As Object
    If Value = TestValue Then
      Return Nothing
    Else
      Return Value
    End If
  End Function

End Module
