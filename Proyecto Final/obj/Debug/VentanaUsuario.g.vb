﻿#ExternalChecksum("..\..\VentanaUsuario.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","CF708D8B93800CB69A1FB72E18C6D327")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell


'''<summary>
'''VentanaUsuario
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class VentanaUsuario
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\VentanaUsuario.xaml",1)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents frmVentanaUsuario As VentanaUsuario
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\VentanaUsuario.xaml",20)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents mitMenuArchivo As System.Windows.Controls.MenuItem
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\VentanaUsuario.xaml",21)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents mitNewPlatillo As System.Windows.Controls.MenuItem
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\VentanaUsuario.xaml",24)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents mitCerrar As System.Windows.Controls.MenuItem
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\VentanaUsuario.xaml",25)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents mitSalir As System.Windows.Controls.MenuItem
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\VentanaUsuario.xaml",27)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents mitMenuEditar As System.Windows.Controls.MenuItem
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\VentanaUsuario.xaml",35)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents mitMenuAyuda As System.Windows.Controls.MenuItem
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\VentanaUsuario.xaml",39)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents lblTU As System.Windows.Controls.Label
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\VentanaUsuario.xaml",40)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents lblNombre As System.Windows.Controls.Label
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\VentanaUsuario.xaml",41)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents lblRestaurante As System.Windows.Controls.Label
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\VentanaUsuario.xaml",42)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents cbxCategorias As System.Windows.Controls.ComboBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\VentanaUsuario.xaml",43)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents txtBuscar As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\VentanaUsuario.xaml",44)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents imgFotoUsuario As System.Windows.Controls.Image
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\VentanaUsuario.xaml",45)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents dtgGrilla As System.Windows.Controls.DataGrid
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\VentanaUsuario.xaml",46)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents lblTipoUsuario As System.Windows.Controls.Label
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\VentanaUsuario.xaml",47)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents lblNombreUsuario As System.Windows.Controls.Label
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\VentanaUsuario.xaml",48)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents lblRestauranteUsuario As System.Windows.Controls.Label
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/Proyecto Final;component/ventanausuario.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\VentanaUsuario.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            Me.frmVentanaUsuario = CType(target,VentanaUsuario)
            Return
        End If
        If (connectionId = 2) Then
            Me.mitMenuArchivo = CType(target,System.Windows.Controls.MenuItem)
            Return
        End If
        If (connectionId = 3) Then
            Me.mitNewPlatillo = CType(target,System.Windows.Controls.MenuItem)
            Return
        End If
        If (connectionId = 4) Then
            Me.mitCerrar = CType(target,System.Windows.Controls.MenuItem)
            Return
        End If
        If (connectionId = 5) Then
            Me.mitSalir = CType(target,System.Windows.Controls.MenuItem)
            Return
        End If
        If (connectionId = 6) Then
            Me.mitMenuEditar = CType(target,System.Windows.Controls.MenuItem)
            Return
        End If
        If (connectionId = 7) Then
            Me.mitMenuAyuda = CType(target,System.Windows.Controls.MenuItem)
            Return
        End If
        If (connectionId = 8) Then
            Me.lblTU = CType(target,System.Windows.Controls.Label)
            Return
        End If
        If (connectionId = 9) Then
            Me.lblNombre = CType(target,System.Windows.Controls.Label)
            Return
        End If
        If (connectionId = 10) Then
            Me.lblRestaurante = CType(target,System.Windows.Controls.Label)
            Return
        End If
        If (connectionId = 11) Then
            Me.cbxCategorias = CType(target,System.Windows.Controls.ComboBox)
            Return
        End If
        If (connectionId = 12) Then
            Me.txtBuscar = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 13) Then
            Me.imgFotoUsuario = CType(target,System.Windows.Controls.Image)
            Return
        End If
        If (connectionId = 14) Then
            Me.dtgGrilla = CType(target,System.Windows.Controls.DataGrid)
            Return
        End If
        If (connectionId = 15) Then
            Me.lblTipoUsuario = CType(target,System.Windows.Controls.Label)
            Return
        End If
        If (connectionId = 16) Then
            Me.lblNombreUsuario = CType(target,System.Windows.Controls.Label)
            Return
        End If
        If (connectionId = 17) Then
            Me.lblRestauranteUsuario = CType(target,System.Windows.Controls.Label)
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class
