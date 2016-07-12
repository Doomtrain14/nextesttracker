Public Class frm_env

    Private Sub cmd_save_env_Click(sender As Object, e As EventArgs) Handles cmd_save_env.Click
        Form1.env_var_text = txt_env_variables.Text
        Me.Close()
    End Sub

    Private Sub txt_env_variables_TextChanged(sender As Object, e As EventArgs) Handles txt_env_variables.TextChanged

    End Sub

    Private Sub frm_env_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_env_variables.Text = Form1.env_var_text
    End Sub
End Class