Imports System.Runtime.CompilerServices

<HideModuleName()>
Public Module NumericExtensions

#Region " InRange(value, min, max) "

  ''' <summary>
  ''' Returns True, if <paramref name="Value"/> is equal or between <paramref name="Min"/> and <paramref name="Max"/>.
  ''' </summary>
  <Extension()>
  Public Function InRange(ByVal Value As Int16, ByVal Min As Int16, ByVal Max As Int16) As Boolean
    Return (Value >= Min AndAlso Value <= Max)
  End Function

  ''' <summary>
  ''' Returns True, if <paramref name="Value"/> is equal or between <paramref name="Min"/> and <paramref name="Max"/>.
  ''' </summary>
  <Extension()>
  Public Function InRange(ByVal Value As Int32, ByVal Min As Int32, ByVal Max As Int32) As Boolean
    Return (Value >= Min AndAlso Value <= Max)
  End Function

  ''' <summary>
  ''' Returns True, if <paramref name="Value"/> is equal or between <paramref name="Min"/> and <paramref name="Max"/>.
  ''' </summary>
  <Extension()>
  Public Function InRange(ByVal Value As Int64, ByVal Min As Int64, ByVal Max As Int64) As Boolean
    Return (Value >= Min AndAlso Value <= Max)
  End Function

  ''' <summary>
  ''' Returns True, if <paramref name="Value"/> is equal or between <paramref name="Min"/> and <paramref name="Max"/>.
  ''' </summary>
  <Extension()>
  Public Function InRange(ByVal Value As Double, ByVal Min As Double, ByVal Max As Double) As Boolean
    Return (Value >= Min AndAlso Value <= Max)
  End Function

  ''' <summary>
  ''' Returns True, if <paramref name="Value"/> is equal or between <paramref name="Min"/> and <paramref name="Max"/>.
  ''' </summary>
  <Extension()>
  Public Function InRange(ByVal Value As Decimal, ByVal Min As Decimal, ByVal Max As Decimal) As Boolean
    Return (Value >= Min AndAlso Value <= Max)
  End Function

  ''' <summary>
  ''' Returns True, if <paramref name="Value"/> is equal or between <paramref name="Min"/> and <paramref name="Max"/>.
  ''' </summary>
  <Extension()>
  Public Function InRange(ByVal Value As Single, ByVal Min As Single, ByVal Max As Single) As Boolean
    Return (Value >= Min AndAlso Value <= Max)
  End Function

  ''' <summary>
  ''' Returns True, if <paramref name="Value"/> is equal or between <paramref name="Min"/> and <paramref name="Max"/>.
  ''' </summary>
  <Extension()>
  Public Function InRange(ByVal Value As Byte, ByVal Min As Byte, ByVal Max As Byte) As Boolean
    Return (Value >= Min AndAlso Value <= Max)
  End Function

#End Region

End Module
