Imports GenCode.CommonSpace
Imports GenCode.PropertySpace
Imports System.IO

Namespace WriterSpace
    Public Class CNewFunctionWriter
        Implements IWrite2File

        Protected p_oDataTable As DataTable
        Protected p_fFileStream As StreamWriter

        Public Sub New(ByVal i_fFileStream As StreamWriter, ByVal i_oDataTable As DataTable)
            p_fFileStream = i_fFileStream
            p_oDataTable = i_oDataTable
        End Sub

        Private Sub imp_IWrite2File_Write2File() Implements IWrite2File.Write2File
            Dim v_obj As IWrite2File
            Dim v_fFileReader As New StreamReader(CUtil.getTemplatesDir() & "\RegionBegin.txt")
            Dim v_strBeginClass As String

            v_strBeginClass = v_fFileReader.ReadToEnd()
            v_strBeginClass = v_strBeginClass.Replace("<REGION_NAME>", "Init Functions")
            p_fFileStream.WriteLine(v_strBeginClass)
            v_fFileReader.Close()

            v_fFileReader = New StreamReader(CUtil.getTemplatesDir() & "\NewFunc.txt")
            Dim v_strFunc As String = v_fFileReader.ReadToEnd()
            v_strFunc = v_strFunc.Replace("<TABLE_NAME>", p_oDataTable.TableName)
            p_fFileStream.WriteLine(v_strFunc)
            v_fFileReader.Close()

            v_fFileReader = New StreamReader(CUtil.getTemplatesDir() & "\RegionEnd.txt")
            Dim v_strEndClass As String = v_fFileReader.ReadToEnd()
            p_fFileStream.WriteLine(v_strEndClass)
            v_fFileReader.Close()
        End Sub
    End Class
End Namespace