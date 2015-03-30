Imports GenCode.CommonSpace
Imports System.IO
Namespace PropertySpace
    Public Class CProperty
        Implements IWrite2File

        Protected p_DataType As String
        Protected p_FieldName As String
        Protected p_fFileStream As StreamWriter

        Public Sub New(ByVal i_fFileStream As StreamWriter, ByVal i_oDataColumn As DataColumn)
            p_DataType = i_oDataColumn.GetType().ToString()
            p_FieldName = i_oDataColumn.ColumnName
            p_fFileStream = i_fFileStream
        End Sub

        Private Sub imp_IWrite2File_Write2File() Implements IWrite2File.Write2File
            p_fFileStream.WriteLine(getStr2Write())
        End Sub

        Protected Overridable ReadOnly Property Name4Property()
            Get
                MsgBox("Vao day la chet roi")
                Debug.Assert(False)
            End Get
        End Property

        Protected Overridable Function getStr2Write() As String
            MsgBox("Vao day la chet roi")
            Debug.Assert(False)
        End Function

        'Public Const OL_Level3 As String = Constants.vbTab & Constants.vbTab & Constants.vbTab

        'Public Sub SetValues(ByVal i_DataType As System.Type, ByVal i_FieldName As String)
        '    ConvertType(i_DataType, i_FieldName)
        'End Sub

        'Public Function getName() As String
        '    Return p_FieldName
        'End Function

        'Public Function getName4Property() As String
        '    Return p_Name4Property
        'End Function

        'Public Function getDataType() As String
        '    Return p_DataType
        'End Function

        'Public Function getReturnCodeLine() As String
        '    Dim v_str As String
        '    Select Case p_DataType.ToString
        '        Case "String"
        '            v_str &= "Return CNull.RowNVLString(pm_objDR, """ & p_FieldName & """)"
        '        Case "DateTime"
        '            v_str &= "Return CNull.RowNVLDate(pm_objDR, """ & p_FieldName & """)"
        '        Case "Decimal", "Int32"
        '            v_str &= "Return CNull.RowNVLDecimal(pm_objDR, """ & p_FieldName & """)"
        '        Case Else
        '            MsgBox("Trong bảng này có kiểu dữ liệu chưa được định nghĩa")
        '    End Select
        '    Return v_str
        'End Function

        'Private Sub ConvertType(ByVal i_DataType As System.Type _
        '                            , ByVal i_FieldName As String)
        '    'Chuyen tu datatype voi ten tuong ung thanh sqlparameter
        '    p_FieldName = i_FieldName
        '    Select Case i_DataType.ToString
        '        Case "System.String"
        '            p_Name4Property = "str" & i_FieldName
        '            p_DataType = "String"
        '        Case "System.DateTime"
        '            p_Name4Property = "dat" & i_FieldName
        '            p_DataType = "DateTime"
        '        Case "System.Decimal", "System.Int32"
        '            p_Name4Property = "dc" & i_FieldName
        '            p_DataType = "Decimal"
        '        Case Else
        '            MsgBox("Trong bảng này có kiểu dữ liệu chưa được định nghĩa")
        '    End Select
        'End Sub
    End Class
End Namespace