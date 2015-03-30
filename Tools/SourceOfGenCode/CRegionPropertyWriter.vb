Imports GenCode.CommonSpace
Imports GenCode.PropertySpace
Imports System.IO

Namespace WriterSpace
    Public Class CRegionPropertyWriter
        Implements IWrite2File

        Public Components() As IWrite2File
        Protected p_oDataTable As DataTable
        Protected p_fFileStream As StreamWriter

        Public Sub New(ByVal i_fFileStream As StreamWriter, ByVal i_oDataTable As DataTable)
            p_fFileStream = i_fFileStream
            p_oDataTable = i_oDataTable
            BuildColumn()
        End Sub

        Private Sub BuildColumn()
            If p_oDataTable.Columns.Count > 0 Then
                Dim v_i As Integer = 0
                Dim v_oDataColumn As DataColumn
                Dim v_PropertyFactory As New CPropertyFactory()
                ReDim Components(p_oDataTable.Columns.Count - 1)
                For Each v_oDataColumn In p_oDataTable.Columns
                    Components(v_i) = v_PropertyFactory.CreateProperty(p_fFileStream, v_oDataColumn)
                    v_i += 1
                Next
            End If
        End Sub

        Private Sub imp_IWrite2File_Write2File() Implements IWrite2File.Write2File
            Dim v_obj As IWrite2File
            Dim v_fFileReader As New StreamReader(CUtil.getTemplatesDir() & "\RegionBegin.txt")
            Dim v_strBeginClass As String

            v_strBeginClass = v_fFileReader.ReadToEnd()
            v_strBeginClass = v_strBeginClass.Replace("<REGION_NAME>", "Public Properties")
            p_fFileStream.WriteLine(v_strBeginClass)
            v_fFileReader.Close()

            If Not Components Is Nothing Then
                For Each v_obj In Components
                    v_obj.Write2File()
                Next
            End If

            v_fFileReader = New StreamReader(CUtil.getTemplatesDir() & "\RegionEnd.txt")
            Dim v_strEndClass As String = v_fFileReader.ReadToEnd()
            p_fFileStream.WriteLine(v_strEndClass)
            v_fFileReader.Close()
        End Sub
    End Class
End Namespace