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


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Executers\codeCompiler.bat")>  _
        Public ReadOnly Property compilerCommand() As String
            Get
                Return CType(Me("compilerCommand"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Executers\codeRunner.bat")>  _
        Public ReadOnly Property runnerCommand() As String
            Get
                Return CType(Me("runnerCommand"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("MinGW\bin\")>  _
        Public ReadOnly Property compilerLoaction() As String
            Get
                Return CType(Me("compilerLoaction"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property Theme() As Boolean
            Get
                Return CType(Me("Theme"),Boolean)
            End Get
            Set
                Me("Theme") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("\0")>  _
        Public Property lastOpenedFileName() As String
            Get
                Return CType(Me("lastOpenedFileName"),String)
            End Get
            Set
                Me("lastOpenedFileName") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("#include <stdio.h>"&Global.Microsoft.VisualBasic.ChrW(10)&"int main()"&Global.Microsoft.VisualBasic.ChrW(10)&"{"&Global.Microsoft.VisualBasic.ChrW(10)&"    printf(""Hello world"");"&Global.Microsoft.VisualBasic.ChrW(10)&"    return 0;"&Global.Microsoft.VisualBasic.ChrW(10)&"}")>  _
        Public ReadOnly Property preAvalibleCCode() As String
            Get
                Return CType(Me("preAvalibleCCode"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Consolas, 15.75pt, style=Bold")>  _
        Public Property codeBoxFont() As Global.System.Drawing.Font
            Get
                Return CType(Me("codeBoxFont"),Global.System.Drawing.Font)
            End Get
            Set
                Me("codeBoxFont") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property EditorFont() As Global.System.Drawing.Font
            Get
                Return CType(Me("EditorFont"),Global.System.Drawing.Font)
            End Get
            Set
                Me("EditorFont") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("#include <iostream>"&Global.Microsoft.VisualBasic.ChrW(10)&"using namespace std;"&Global.Microsoft.VisualBasic.ChrW(10)&"int main()"&Global.Microsoft.VisualBasic.ChrW(10)&"{"&Global.Microsoft.VisualBasic.ChrW(10)&"    cout << ""Hello World"" <"& _ 
            "< endl;"&Global.Microsoft.VisualBasic.ChrW(10)&"    return 0;"&Global.Microsoft.VisualBasic.ChrW(10)&"}")>  _
        Public ReadOnly Property preAvalibleCppCode() As String
            Get
                Return CType(Me("preAvalibleCppCode"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("LimeGreen")>  _
        Public ReadOnly Property codeBoxForeColor() As Global.System.Drawing.Color
            Get
                Return CType(Me("codeBoxForeColor"),Global.System.Drawing.Color)
            End Get
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.ChikMiki.My.MySettings
            Get
                Return Global.ChikMiki.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
