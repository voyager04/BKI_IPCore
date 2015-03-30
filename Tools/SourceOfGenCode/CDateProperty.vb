Imports System.IO
Imports GenCode.CommonSpace
Namespace PropertySpace
    Public Class CDateProperty
        Inherits CProperty
        Public Sub New(ByVal i_fFileStream As StreamWriter, ByVal i_oDataColumn As DataColumn)
            MyBase.New(i_fFileStream, i_oDataColumn)
        End Sub
        Protected Overrides Function getStr2Write() As String
            Dim v_fFileStream As New StreamReader(CUtil.getTemplatesDir() & "\DateProp.txt")
            Dim v_str As String
            v_str = v_fFileStream.ReadToEnd()
            v_str = v_str.Replace("<PROPERTY_NAME>", p_FieldName)
            p_fFileStream.WriteLine(v_str)
            v_fFileStream.Close()
        End Function
        Protected Overrides ReadOnly Property Name4Property()
            Get
                Return "dat" & p_FieldName
            End Get
        End Property
    End Class
End Namespace