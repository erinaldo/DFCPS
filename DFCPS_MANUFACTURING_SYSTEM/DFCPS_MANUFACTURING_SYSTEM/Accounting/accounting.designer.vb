﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="DFCPS_MANAGEMENT_DB")>  _
Partial Public Class accountingDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InserttblBuildInventory(instance As tblBuildInventory)
    End Sub
  Partial Private Sub UpdatetblBuildInventory(instance As tblBuildInventory)
    End Sub
  Partial Private Sub DeletetblBuildInventory(instance As tblBuildInventory)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.DFCPS_MANUFACTURING_SYSTEM.My.MySettings.Default.DFCPS_MANAGEMENT_DBConnectionString1, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property tblBuildInventories() As System.Data.Linq.Table(Of tblBuildInventory)
		Get
			Return Me.GetTable(Of tblBuildInventory)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.tblBuildInventory")>  _
Partial Public Class tblBuildInventory
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _id As Integer
	
	Private _buildInvNo As String
	
	Private _dateBuild As String
	
	Private _itemcode As String
	
	Private _qty As System.Nullable(Of Integer)
	
	Private _remarks As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnidChanging(value As Integer)
    End Sub
    Partial Private Sub OnidChanged()
    End Sub
    Partial Private Sub OnbuildInvNoChanging(value As String)
    End Sub
    Partial Private Sub OnbuildInvNoChanged()
    End Sub
    Partial Private Sub OndateBuildChanging(value As String)
    End Sub
    Partial Private Sub OndateBuildChanged()
    End Sub
    Partial Private Sub OnitemcodeChanging(value As String)
    End Sub
    Partial Private Sub OnitemcodeChanged()
    End Sub
    Partial Private Sub OnqtyChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnqtyChanged()
    End Sub
    Partial Private Sub OnremarksChanging(value As String)
    End Sub
    Partial Private Sub OnremarksChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_id", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property id() As Integer
		Get
			Return Me._id
		End Get
		Set
			If ((Me._id = value)  _
						= false) Then
				Me.OnidChanging(value)
				Me.SendPropertyChanging
				Me._id = value
				Me.SendPropertyChanged("id")
				Me.OnidChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_buildInvNo", DbType:="NChar(10)")>  _
	Public Property buildInvNo() As String
		Get
			Return Me._buildInvNo
		End Get
		Set
			If (String.Equals(Me._buildInvNo, value) = false) Then
				Me.OnbuildInvNoChanging(value)
				Me.SendPropertyChanging
				Me._buildInvNo = value
				Me.SendPropertyChanged("buildInvNo")
				Me.OnbuildInvNoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_dateBuild", DbType:="NChar(10)")>  _
	Public Property dateBuild() As String
		Get
			Return Me._dateBuild
		End Get
		Set
			If (String.Equals(Me._dateBuild, value) = false) Then
				Me.OndateBuildChanging(value)
				Me.SendPropertyChanging
				Me._dateBuild = value
				Me.SendPropertyChanged("dateBuild")
				Me.OndateBuildChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_itemcode", DbType:="NChar(10)")>  _
	Public Property itemcode() As String
		Get
			Return Me._itemcode
		End Get
		Set
			If (String.Equals(Me._itemcode, value) = false) Then
				Me.OnitemcodeChanging(value)
				Me.SendPropertyChanging
				Me._itemcode = value
				Me.SendPropertyChanged("itemcode")
				Me.OnitemcodeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_qty", DbType:="Int")>  _
	Public Property qty() As System.Nullable(Of Integer)
		Get
			Return Me._qty
		End Get
		Set
			If (Me._qty.Equals(value) = false) Then
				Me.OnqtyChanging(value)
				Me.SendPropertyChanging
				Me._qty = value
				Me.SendPropertyChanged("qty")
				Me.OnqtyChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_remarks", DbType:="NChar(10)")>  _
	Public Property remarks() As String
		Get
			Return Me._remarks
		End Get
		Set
			If (String.Equals(Me._remarks, value) = false) Then
				Me.OnremarksChanging(value)
				Me.SendPropertyChanging
				Me._remarks = value
				Me.SendPropertyChanged("remarks")
				Me.OnremarksChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class