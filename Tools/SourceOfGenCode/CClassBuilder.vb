Imports System.IO
Imports GenCode.WriterSpace
Imports GenCode.CommonSpace

Namespace BuilderSpace

    Public Class CClassBuilderFactory
        Public Shared Function CreateCVBClassBuiler(ByVal i_ds As DataSet, ByVal i_fFileStream As StreamWriter, ByVal i_Author As String) As CClassBuilder
            Return New CVBBuilder(i_ds, i_fFileStream, i_Author)
        End Function

        Public Shared Function CreateCCSClassBuiler(ByVal i_ds As DataSet _
                                        , ByVal i_fFileStream As StreamWriter _
                                        , ByVal i_Author As String) As CClassBuilder
            Return New CCSBuilder(i_ds, i_fFileStream, i_Author)
        End Function
    End Class

    Public Class CClassBuilder
        Public Overridable Function BuildClass() As IWrite2File
        End Function
    End Class

    Public Class CVBBuilder
        Inherits CClassBuilder
        Dim m_DS As DataSet
        Dim m_Author As String
        Dim m_fFileStream As StreamWriter
        Dim m_ClassWriter As CClassWriter

        Public Sub New(ByVal i_ds As DataSet, ByVal i_fFileStream As StreamWriter, ByVal i_Author As String)
            m_DS = i_ds
            m_Author = i_Author
            m_fFileStream = i_fFileStream
            m_ClassWriter = New CClassWriter()
        End Sub

        Public Overrides Function BuildClass() As IWrite2File
            Dim v_CurDirName As String
            v_CurDirName = AppDomain.CurrentDomain.SetupInformation.ApplicationBase
            ReDim m_ClassWriter.Components(2)
            m_ClassWriter.Components(0) = New CCommentWriter(m_fFileStream, v_CurDirName & "\VBTemplates\Comment.txt", m_Author, m_DS.Tables(0).TableName)
            m_ClassWriter.Components(1) = New CReadFromFileWriter(m_fFileStream, v_CurDirName & "\VBTemplates\Import.txt")
            m_ClassWriter.Components(2) = New CClassBodyWriter(m_fFileStream, m_DS.Tables(0))
            Return m_ClassWriter
        End Function
    End Class

    Public Class CCSBuilder
        Inherits CClassBuilder
        Dim m_DS As DataSet
        Dim m_Author As String
        Dim m_fFileStream As StreamWriter
        Dim m_ClassWriter As CClassWriter

        Public Sub New(ByVal i_ds As DataSet, ByVal i_fFileStream As StreamWriter, ByVal i_Author As String)
            m_DS = i_ds
            m_Author = i_Author
            m_fFileStream = i_fFileStream
            m_ClassWriter = New CClassWriter
        End Sub

        Public Overrides Function BuildClass() As IWrite2File
            Dim v_CurDirName As String
            v_CurDirName = AppDomain.CurrentDomain.SetupInformation.ApplicationBase
            ReDim m_ClassWriter.Components(2)
            m_ClassWriter.Components(0) = New CCommentWriter(m_fFileStream, v_CurDirName & "\CSTemplates\Comment.txt", m_Author, m_DS.Tables(0).TableName)
            m_ClassWriter.Components(1) = New CReadFromFileWriter(m_fFileStream, v_CurDirName & "\CSTemplates\Import.txt")
            m_ClassWriter.Components(2) = New CClassBodyWriter(m_fFileStream, m_DS.Tables(0))
            Return m_ClassWriter
        End Function
    End Class
End Namespace