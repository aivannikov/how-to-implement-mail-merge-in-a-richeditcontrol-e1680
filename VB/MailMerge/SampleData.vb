Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Collections

Namespace MailMerge
	Friend Class SampleData
		Inherits ArrayList
		Public Sub New()
			Add(New AddresseeRecord("Andrew", "XYZ Inc.", "Tullamore Way, 21", 36))
			Add(New AddresseeRecord("Benny", "ABC Ltd.", "Casablanca Rd., 46", 21))
			Add(New AddresseeRecord("Jose", "CASA S.A.", "Paseo di Ronda, 88", 45))


		End Sub
	End Class

	Public Class AddresseeRecord
		Private fAge As Integer
		Private fName As String
		Private fCompany As String
		Private fAddress As String

		Public Property Age() As Integer
			Get
				Return fAge
			End Get
			Set(ByVal value As Integer)
				fAge = value
			End Set
		End Property
		Public Property Name() As String
			Get
				Return fName
			End Get
			Set(ByVal value As String)
				fName = value
			End Set
		End Property
		Public Property Company() As String
			Get
				Return fCompany
			End Get
			Set(ByVal value As String)
				fCompany = value
			End Set
		End Property
		Public Property Address() As String
			Get
				Return fAddress
			End Get
			Set(ByVal value As String)
				fAddress = value
			End Set
		End Property

		Public Sub New(ByVal fName As String, ByVal fCompany As String, ByVal fAddress As String, ByVal fAge As Integer)
			Me.fName = fName
			Me.fAge = fAge
			Me.fCompany = fCompany
			Me.fAddress = fAddress
		End Sub
	End Class
End Namespace
