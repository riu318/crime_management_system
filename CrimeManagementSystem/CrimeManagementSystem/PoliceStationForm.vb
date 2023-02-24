Imports System.Data.SqlClient

Public Class PoliceStationForm
    Dim pkVar As String

    Private Sub buttonNew_Click(sender As System.Object, e As System.EventArgs) Handles buttonNew.Click
        TextBox1StationCode.Text = ""
        TextBox2StationName.Text = ""
        TextBox3Address.Text = ""
        TextBox4phno.Text = ""
        TextBox1StationCode.Focus()
    End Sub
    Private Sub buttonSave_Click(sender As System.Object, e As System.EventArgs) Handles buttonSave.Click
        SaveRecord()
    End Sub

    Private Sub SaveRecord()
        Dim q1var, q2var

        If TextBox1StationCode.Text = "" Then
            MsgBox("Please enter the necessary details")
            Exit Sub
        End If

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        Dim Cmd0 As New SqlCommand("select StationCode from StationTable where StationCode='" & UCase(TextBox1StationCode.Text) & "'", conn)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.HasRows Then
            MsgBox("This record is allready present in the database")
            If conn.State = ConnectionState.Open Then conn.Close()
            Exit Sub
        End If

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        q1var = "insert into StationTable("
        q2Var = " values("
        q1Var = q1Var & "StationCode" & ","
        q2var = q2var & "'" & UCase(TextBox1StationCode.Text) & "',"
        q1var = q1var & "StationName" & ","
        q2var = q2var & "'" & TextBox2StationName.Text & "',"
        q1var = q1var & "Address" & ","
        q2var = q2var & "'" & TextBox3Address.Text & "',"
        q1var = q1var & "PhoneNo" & ")"
        q2var = q2var & "'" & TextBox4phno.Text & "')"

        MsgBox(q1Var & q2Var)
        Dim cmd1 As New SqlCommand(q1Var & q2Var, conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        disRecords()

        TextBox1StationCode.Text = ""
        TextBox2StationName.Text = ""
        TextBox3Address.Text = ""
        TextBox4phno.Text = ""

    End Sub
    Private Sub disRecords()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("Select StationCode,StationName,Address,PhoneNo From StationTable order by StationCode", conn)
        adp.Fill(DS1)
        DataGridView1.DataSource = DS1.Tables(0)
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        pkVar = DataGridView1.CurrentRow.Cells(0).Value
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim Cmd0 As New SqlCommand("select * from StationTable where StationCode='" & pkVar & "'", conn)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.Read Then

            TextBox1StationCode.Text = D1(0).ToString
            TextBox2StationName.Text = D1(1).ToString
            TextBox3Address.Text = D1(2).ToString
            TextBox4phno.Text = D1(3).ToString


        Else
            TextBox1StationCode.Text = ""
            TextBox2StationName.Text = ""


        End If
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Private Sub ButtonDelete_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDelete.Click
        If vbNo = MsgBox("Are you sure you want delete this record", MsgBoxStyle.YesNo, "Delete") Then Exit Sub
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("Delete from StationTable where StationCode='" & pkVar & "'", conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        disRecords()
        TextBox1StationCode.Text = ""
        TextBox2StationName.Text = ""
        TextBox3Address.Text = ""
        TextBox4phno.Text = ""
    End Sub

    Private Sub buttonCancel_Click(sender As System.Object, e As System.EventArgs) Handles buttonCancel.Click
        Me.Close()
    End Sub

    Private Sub PoliceStationForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ButtonUpdate.Enabled = True
        buttonCancel.Enabled = True
        ButtonDelete.Enabled = True
        buttonNew.Enabled = True
        buttonSave.Enabled = True
    End Sub

    Private Sub ButtonUpdate_Click(sender As System.Object, e As System.EventArgs) Handles ButtonUpdate.Click
        If vbNo = MsgBox("Are you sure you want to update this record ?", MsgBoxStyle.YesNo, "delete") Then Exit Sub
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("Delete from StationTable where StationCode='" & pkVar & "'", conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        SaveRecord()
        ButtonView.Enabled = True
        ButtonUpdate.Enabled = True
        buttonCancel.Enabled = True
        buttonNew.Enabled = True

    End Sub

    Private Sub ButtonView_Click(sender As System.Object, e As System.EventArgs) Handles ButtonView.Click
        disRecords()
    End Sub
End Class