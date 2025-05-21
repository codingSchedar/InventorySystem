Public Class formInventory
    Private Sub formInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbBranches.DropDownStyle = ComboBoxStyle.DropDownList

        If cmbBranches.Items.Count = 0 Then
            cmbBranches.Items.Add("Branch A")
            cmbBranches.Items.Add("Branch B")
            cmbBranches.Items.Add("Branch C")
            cmbBranches.Items.Add("Branch D")
            cmbBranches.Items.Add("Branch E")
        End If

        ' Set the initial selection for radio buttons and combo box
        rdCurrentStock.Checked = True
        cmbBranches.SelectedIndex = 0

        ' Call the initial update of inventory results
        UpdateInventoryResults()
    End Sub

    Private Sub UpdateInventoryResults()
        dgvResult.Rows.Clear()

        Dim currentDate As DateTime = DateTime.Now
        Dim selectedBranch As String = If(cmbBranches.SelectedItem IsNot Nothing, cmbBranches.SelectedItem.ToString(), "")

        For Each row As DataGridViewRow In formMain.dgvMain.Rows
            Dim dateOrder As DateTime = DateTime.Parse(row.Cells("cDateOrder").Value.ToString())
            Dim item As String = row.Cells("cItem").Value.ToString()
            Dim amount As Integer = Integer.Parse(row.Cells("cAmount").Value.ToString())
            Dim destination As String = row.Cells("cDestination").Value.ToString()

            Dim stockStatus As String
            If currentDate.Subtract(dateOrder).Days > 7 Then
                stockStatus = "Out of Stock"
            ElseIf currentDate.Subtract(dateOrder).Days > 3 Then
                stockStatus = "Current Stock"
            Else
                stockStatus = "Incoming Stock"
            End If

            If stockStatus = "Current Stock" AndAlso rdCurrentStock.Checked AndAlso destination = selectedBranch Then
                dgvResult.Rows.Add(item, amount, stockStatus)
            ElseIf stockStatus = "Incoming Stock" AndAlso rdIncoming.Checked AndAlso destination = selectedBranch Then
                dgvResult.Rows.Add(item, amount, stockStatus)
            ElseIf stockStatus = "Out of Stock" AndAlso rdOutOfStock.Checked AndAlso destination = selectedBranch Then
                dgvResult.Rows.Add(item, amount, stockStatus)
            End If
        Next
    End Sub


    Private Sub rdCurrentStock_CheckedChanged(sender As Object, e As EventArgs) Handles rdCurrentStock.CheckedChanged
        UpdateInventoryResults()
    End Sub

    Private Sub rdIncoming_CheckedChanged(sender As Object, e As EventArgs) Handles rdIncoming.CheckedChanged
        UpdateInventoryResults()
    End Sub

    Private Sub rdOutOfStock_CheckedChanged(sender As Object, e As EventArgs) Handles rdOutOfStock.CheckedChanged
        UpdateInventoryResults()
    End Sub

    Private Sub cmbBranches_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBranches.SelectedIndexChanged
        UpdateInventoryResults()
    End Sub

End Class