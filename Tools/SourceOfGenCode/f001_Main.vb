Option Explicit On 
Option Strict On

Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports GenCode.BuilderSpace
Imports GenCode.CommonSpace

Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Soap

Public Class f001_Main
    Inherits System.Windows.Forms.Form


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDBName As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtCreatedUser As System.Windows.Forms.TextBox
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents txtTableName As System.Windows.Forms.TextBox
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents dlgSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents m_radCSharp As System.Windows.Forms.RadioButton
    Friend WithEvents m_radVB As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDBName = New System.Windows.Forms.TextBox
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtCreatedUser = New System.Windows.Forms.TextBox
        Me.cmdOK = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.txtTableName = New System.Windows.Forms.TextBox
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmdBrowse = New System.Windows.Forms.Button
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog
        Me.txtServer = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.m_radVB = New System.Windows.Forms.RadioButton
        Me.m_radCSharp = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Database"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(20, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "User Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(20, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(20, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 19)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Tên bảng"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(20, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 19)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Người tạo"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDBName
        '
        Me.txtDBName.Location = New System.Drawing.Point(90, 36)
        Me.txtDBName.Name = "txtDBName"
        Me.txtDBName.Size = New System.Drawing.Size(234, 20)
        Me.txtDBName.TabIndex = 1
        Me.txtDBName.Text = "eSchool"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(90, 64)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(234, 20)
        Me.txtUserName.TabIndex = 2
        Me.txtUserName.Text = "eSchool"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(90, 94)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(234, 20)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.Text = "eSchool"
        '
        'txtCreatedUser
        '
        Me.txtCreatedUser.Location = New System.Drawing.Point(90, 153)
        Me.txtCreatedUser.Name = "txtCreatedUser"
        Me.txtCreatedUser.Size = New System.Drawing.Size(234, 20)
        Me.txtCreatedUser.TabIndex = 5
        Me.txtCreatedUser.Text = ""
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(280, 210)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(76, 25)
        Me.cmdOK.TabIndex = 8
        Me.cmdOK.Text = "&OK"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(280, 240)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(76, 25)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "&Exit"
        '
        'txtTableName
        '
        Me.txtTableName.Location = New System.Drawing.Point(90, 124)
        Me.txtTableName.Name = "txtTableName"
        Me.txtTableName.Size = New System.Drawing.Size(234, 20)
        Me.txtTableName.TabIndex = 4
        Me.txtTableName.Text = ""
        '
        'txtPath
        '
        Me.txtPath.Enabled = False
        Me.txtPath.Location = New System.Drawing.Point(90, 180)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(234, 20)
        Me.txtPath.TabIndex = 6
        Me.txtPath.Text = "C:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(5, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 19)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Dir to save"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(330, 179)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(27, 21)
        Me.cmdBrowse.TabIndex = 7
        Me.cmdBrowse.Text = "..."
        '
        'dlgSave
        '
        Me.dlgSave.FileName = "US_"
        Me.dlgSave.Filter = "VB .NET Files |*.vb | C# Files | *.cs | All files| *.*"
        Me.dlgSave.Title = "Create file"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(90, 10)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(234, 20)
        Me.txtServer.TabIndex = 0
        Me.txtServer.Text = "ACBNT"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(20, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 19)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Server"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.m_radVB)
        Me.GroupBox1.Controls.Add(Me.m_radCSharp)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 205)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 60)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Language"
        '
        'm_radVB
        '
        Me.m_radVB.Checked = True
        Me.m_radVB.Location = New System.Drawing.Point(140, 25)
        Me.m_radVB.Name = "m_radVB"
        Me.m_radVB.TabIndex = 1
        Me.m_radVB.TabStop = True
        Me.m_radVB.Text = "VB .Net (*.vb)"
        '
        'm_radCSharp
        '
        Me.m_radCSharp.Location = New System.Drawing.Point(35, 25)
        Me.m_radCSharp.Name = "m_radCSharp"
        Me.m_radCSharp.Size = New System.Drawing.Size(80, 24)
        Me.m_radCSharp.TabIndex = 0
        Me.m_radCSharp.Text = "C#  (*.cs)"
        '
        'f001_Main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(364, 280)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.txtCreatedUser)
        Me.Controls.Add(Me.txtTableName)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.txtDBName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "f001_Main"
        Me.Text = "GenCode"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Save me to disk"
    Private Sub Save()
        Dim v_objStream As Stream = File.OpenWrite(CUtil.getCurDir() & "\GenCode.xml")
        Dim v_objXmlFormat As SoapFormatter = New SoapFormatter
        Dim v_objInfo As New FormInfo
        v_objInfo.m_strServer = txtServer.Text
        v_objInfo.m_strTableName = txtTableName.Text
        v_objInfo.m_strUserName = txtUserName.Text
        v_objInfo.m_strDatabase = txtDBName.Text
        v_objInfo.m_strNguoiTao = txtCreatedUser.Text
        v_objInfo.m_strPassword = txtPassword.Text
        v_objInfo.m_strPath = txtPath.Text
        If m_radCSharp.Checked Then
            v_objInfo.m_eLanguage = eLanguage.CSharp
        Else
            v_objInfo.m_eLanguage = eLanguage.VBDotNet
        End If
        v_objXmlFormat.Serialize(v_objStream, v_objInfo)
        v_objStream.Close()
    End Sub

    Private Sub Restore()
        Dim v_objStream As Stream = File.OpenRead(CUtil.getCurDir() & "\GenCode.xml")
        Dim v_objXmlFormat As SoapFormatter = New SoapFormatter
        Dim v_objInfo As New FormInfo
        v_objInfo = CType(v_objXmlFormat.Deserialize(v_objStream), FormInfo)
        v_objStream.Close()
        txtServer.Text = v_objInfo.m_strServer
        txtTableName.Text = v_objInfo.m_strTableName
        txtUserName.Text = v_objInfo.m_strUserName
        txtDBName.Text = v_objInfo.m_strDatabase
        txtCreatedUser.Text = v_objInfo.m_strNguoiTao
        txtPassword.Text = v_objInfo.m_strPassword
        txtPath.Text = v_objInfo.m_strPath

        If v_objInfo.m_eLanguage = eLanguage.CSharp Then
            m_radCSharp.Checked = True
        Else
            m_radVB.Checked = True
        End If

    End Sub
#End Region


    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click

        If Me.txtTableName.Text = "" Then
            MessageBox.Show("Tên bảng, please")
            Exit Sub
        End If

        If Me.txtUserName.Text = "" Then
            MessageBox.Show("Tên người, please")
            Exit Sub
        End If

        If m_radCSharp.Checked Then
            CUtil.m_eLanguage = eLanguage.CSharp
        Else
            CUtil.m_eLanguage = eLanguage.VBDotNet
        End If

        Dim v_ds As New DataSet
        Dim v_da As SqlDataAdapter = CProvider.getAdapter()
        Dim v_cmd As New SqlCommand
        v_cmd.Connection = CProvider.getConnection(txtServer.Text, _
                        txtDBName.Text, txtUserName.Text, txtPassword.Text)
        v_cmd.CommandText = "SELECT * FROM " & txtTableName.Text
        v_cmd.CommandType = CommandType.Text
        v_da.SelectCommand = v_cmd
        Try
            v_da.Fill(v_ds)
            v_ds.Tables(0).TableName = txtTableName.Text.ToUpper()
            If m_radVB.Checked Then
                Write2File(v_ds, txtPath.Text & "\US_" & v_ds.Tables(0).TableName & ".vb")
            Else
                Write2File(v_ds, txtPath.Text & "\US_" & v_ds.Tables(0).TableName & ".cs")
            End If
            'WriteLockSP(v_ds, txtPath.Text & "\pr_" & v_ds.Tables(0).TableName & "_IsUpdatable.sql")
            Me.Save()
            MsgBox("Đã xong")
        Catch v_e As Exception
            MsgBox(v_e.Message)
        End Try
    End Sub

    Private Function GetDirName(ByVal i_strFileName As String) As String
        Dim v_str As String
        Dim v_Pos As Integer
        v_Pos = i_strFileName.LastIndexOf("\")
        v_str = i_strFileName.Substring(0, v_Pos)
        Return v_str
    End Function

    Private Sub Write2File(ByVal i_ds As DataSet, ByVal i_sFileName As String)
        Try
            Dim v_oClass As IWrite2File
            Dim v_fFileStream As New StreamWriter(i_sFileName)
            Dim v_oBuilder As CClassBuilder

            Select Case CUtil.m_eLanguage
                Case eLanguage.CSharp
                    v_oBuilder = CClassBuilderFactory.CreateCCSClassBuiler(i_ds, v_fFileStream, txtCreatedUser.Text)
                Case eLanguage.VBDotNet
                    v_oBuilder = CClassBuilderFactory.CreateCVBClassBuiler(i_ds, v_fFileStream, txtCreatedUser.Text)
            End Select

            v_oClass = v_oBuilder.BuildClass()
            v_oClass.Write2File()
            v_fFileStream.Flush()
            v_fFileStream.Close()
        Catch v_e As Exception
            MsgBox(v_e.Message)
        End Try
    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click
        If dlgSave.ShowDialog() = DialogResult.OK Then
            txtPath.Text = Me.GetDirName(dlgSave.FileName)
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub


    Private Sub f001_Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Restore()
    End Sub
End Class

Public Enum eLanguage
    CSharp = 0
    VBDotNet = 1
End Enum

<Serializable()> _
Public Class FormInfo
#Region "Thuc thi ISerializable"
    Implements ISerializable

    Public m_strServer As String
    Public m_strDatabase As String
    Public m_strUserName As String
    Public m_strPassword As String
    Public m_strPath As String
    Public m_strTableName As String
    Public m_strNguoiTao As String
    Public m_eLanguage As eLanguage

    Public Sub New()
    End Sub

    Private Sub New(ByVal si As SerializationInfo, _
        ByVal ctx As StreamingContext)
        m_strServer = si.GetString("Server")
        m_strDatabase = si.GetString("Database")
        m_strUserName = si.GetString("Username")
        m_strPassword = si.GetString("Password")
        m_strPath = si.GetString("Path")
        m_strTableName = si.GetString("Tablename")
        m_strNguoiTao = si.GetString("NguoiTao")
        Select Case CType(si.GetString("Language"), Integer)
            Case eLanguage.CSharp
                m_eLanguage = eLanguage.CSharp
            Case eLanguage.VBDotNet
                m_eLanguage = eLanguage.VBDotNet
        End Select
    End Sub

    Public Sub GetObjectData(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext) Implements System.Runtime.Serialization.ISerializable.GetObjectData
        info.AddValue("Server", m_strServer)
        info.AddValue("Database", m_strDatabase)
        info.AddValue("Username", m_strUserName)
        info.AddValue("Password", m_strPassword)
        info.AddValue("Path", m_strPath)
        info.AddValue("Tablename", m_strTableName)
        info.AddValue("NguoiTao", m_strNguoiTao)
        info.AddValue("Language", m_eLanguage)
    End Sub

#End Region
End Class