Namespace CommonSpace
    Public Class CUtil
        Public Shared m_eLanguage As eLanguage

        Public Shared Function getStrOLLevel(ByVal i_Level As Integer) As String
            Dim v_i As Integer
            Dim v_str As String = ""
            For v_i = 1 To i_Level
                v_str &= Constants.vbTab
            Next
            Return v_str
        End Function

        Public Shared Function getDoubleQuote() As String
            Return """"
        End Function

        Public Shared Function getCurDir() As String
            Dim v_CurDirName As String
            v_CurDirName = AppDomain.CurrentDomain.SetupInformation.ApplicationBase
            Return v_CurDirName
        End Function

        Public Shared Function getTemplatesDir() As String
            Select Case m_eLanguage
                Case eLanguage.CSharp
                    Return getCurDir() & "CSTemplates"
                Case eLanguage.VBDotNet
                    Return getCurDir() & "VBTemplates"
            End Select
        End Function
    End Class
End Namespace