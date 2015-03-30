Imports GenCode.CommonSpace
Imports System.IO
Namespace PropertySpace
    Public Class CPropertyFactory
        Public Function CreateProperty(ByVal i_fFileStream As StreamWriter, ByVal i_oDataColumn As DataColumn) As IWrite2File
            Select Case i_oDataColumn.DataType.ToString()
                Case "System.Decimal", "System.Integer", "System.Int32"
                    Return New CDecimalProperty(i_fFileStream, i_oDataColumn)
                Case "System.String"
                    Return New CStringProperty(i_fFileStream, i_oDataColumn)
                Case "System.DateTime"
                    Return New CDateProperty(i_fFileStream, i_oDataColumn)
                Case Else
                    MsgBox("Trong bang nay co kieu chua duoc dinh nghia")
            End Select
        End Function
    End Class
End Namespace