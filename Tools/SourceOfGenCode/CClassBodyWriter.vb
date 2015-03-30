Imports GenCode.CommonSpace
Imports System.IO
Namespace WriterSpace
    Public Class CClassBodyWriter
        Implements IWrite2File

        Public Components() As IWrite2File
        Protected p_oDataTable As DataTable
        Protected p_fFileStream As StreamWriter

        Public Sub New(ByVal i_fFileStream As StreamWriter, ByVal i_oDataTable As DataTable)
            p_fFileStream = i_fFileStream
            p_oDataTable = i_oDataTable
            ReDim Components(1)
            Components(0) = New CRegionPropertyWriter(p_fFileStream, p_oDataTable)
            Components(1) = New CNewFunctionWriter(p_fFileStream, p_oDataTable)
        End Sub

        Private Sub imp_IWrite2File_Write2File() Implements IWrite2File.Write2File
            Dim v_obj As IWrite2File
            Dim v_fFileReader As New StreamReader(CUtil.getTemplatesDir() & "\CLSBegin.txt")
            Dim v_strBeginClass As String

            v_strBeginClass = v_fFileReader.ReadToEnd()
            v_strBeginClass = v_strBeginClass.Replace("<TABLE_NAME>", p_oDataTable.TableName)
            p_fFileStream.WriteLine(v_strBeginClass)
            v_fFileReader.Close()

            If Not Components Is Nothing Then
                For Each v_obj In Components
                    v_obj.Write2File()
                Next
            End If

            v_fFileReader = New StreamReader(CUtil.getTemplatesDir() & "\CLSEnd.txt")
            Dim v_strEndClass As String = v_fFileReader.ReadToEnd()
            p_fFileStream.WriteLine(v_strEndClass)
            v_fFileReader.Close()
        End Sub
    End Class
End Namespace