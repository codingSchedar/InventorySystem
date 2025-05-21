Public Class formMain
    Private Sub PurchaseItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseItemsToolStripMenuItem.Click
        formPurchase.ShowDialog()
    End Sub

    Private Sub BranchManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BranchManagementToolStripMenuItem.Click
        formInventory.ShowDialog()
    End Sub

    Private Sub ItemManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemManagementToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvMain.Rows.Add(New String() {"Espresso Machine", Date.Now.AddDays(-7).ToString("yyyy-MM-dd"), 10, "Supplier A", "Branch B"})
        dgvMain.Rows.Add(New String() {"Coffee grinder", Date.Now.AddDays(-8).ToString("yyyy-MM-dd"), 10, "Supplier A", "Branch B"})
        dgvMain.Rows.Add(New String() {"Commercial coffee maker", Date.Now.AddDays(-7).ToString("yyyy-MM-dd"), 10, "Supplier B", "Branch A"})
        dgvMain.Rows.Add(New String() {"Milk frother", Date.Now.AddDays(-17).ToString("yyyy-MM-dd"), 10, "Supplier B", "Branch C"})
        dgvMain.Rows.Add(New String() {"Blender", Date.Now.AddDays(-7).ToString("yyyy-MM-dd"), 10, "Supplier E", "Branch D"})
        dgvMain.Rows.Add(New String() {"Cash register", Date.Now.AddDays(-27).ToString("yyyy-MM-dd"), 10, "Supplier F", "Branch A"})
        dgvMain.Rows.Add(New String() {"Coffee filters", Date.Now.AddDays(-12).ToString("yyyy-MM-dd"), 10, "Supplier D", "Branch B"})
        dgvMain.Rows.Add(New String() {"Coffee cups", Date.Now.AddDays(-6).ToString("yyyy-MM-dd"), 10, "Supplier D", "Branch B"})
        dgvMain.Rows.Add(New String() {"Coffee mugs", Date.Now.AddDays(-4).ToString("yyyy-MM-dd"), 10, "Supplier A", "Branch C"})
        dgvMain.Rows.Add(New String() {"Coffee beans", Date.Now.AddDays(-3).ToString("yyyy-MM-dd"), 10, "Supplier A", "Branch A"})
        dgvMain.Rows.Add(New String() {"Syrups", Date.Now.AddDays(-10).ToString("yyyy-MM-dd"), 10, "Supplier B", "Branch C"})
        dgvMain.Rows.Add(New String() {"Toppings", Date.Now.AddDays(-19).ToString("yyyy-MM-dd"), 10, "Supplier F", "Branch D"})
        dgvMain.Rows.Add(New String() {"Sweeteners", Date.Now.AddDays(-9).ToString("yyyy-MM-dd"), 10, "Supplier B", "Branch E"})

    End Sub

    Private Sub dgvMain_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellContentClick
        ' Check if the clicked cell is in the "cAction" column and the clicked element is a link (text)
        If dgvMain.Columns(e.ColumnIndex).Name = "cAction" Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = dgvMain.Rows(e.RowIndex)

            ' Extract the values from the selected row
            Dim itemName As String = selectedRow.Cells("cItem").Value.ToString()
            Dim amount As String = selectedRow.Cells("cAmount").Value.ToString()
            Dim supplier As String = selectedRow.Cells("cSource").Value.ToString()
            Dim destination As String = selectedRow.Cells("cDestination").Value.ToString()

            ' Create an instance of formPurchase
            Dim formPurchase As New formPurchase()

            formPurchase.cmbSupplier.Items.Add("Supplier A")
            formPurchase.cmbSupplier.Items.Add("Supplier B")
            formPurchase.cmbSupplier.Items.Add("Supplier C")
            formPurchase.cmbSupplier.Items.Add("Supplier D")
            formPurchase.cmbSupplier.Items.Add("Supplier E")

            formPurchase.cmbDestination.Items.Add("Branch A")
            formPurchase.cmbDestination.Items.Add("Branch B")
            formPurchase.cmbDestination.Items.Add("Branch C")
            formPurchase.cmbDestination.Items.Add("Branch D")
            formPurchase.cmbDestination.Items.Add("Branch E")

            ' Set the values of cmbSupplier and cmbDestination in formPurchase
            Dim supplierIndex As Integer = formPurchase.cmbSupplier.FindString(supplier)
            If supplierIndex <> -1 Then
                formPurchase.cmbSupplier.SelectedIndex = supplierIndex
            End If

            Dim destinationIndex As Integer = formPurchase.cmbDestination.FindString(destination)
            If destinationIndex <> -1 Then
                formPurchase.cmbDestination.SelectedIndex = destinationIndex
            End If

            ' Add the item to dgvInventory in formPurchase
            formPurchase.dgvInventory.Rows.Add(itemName, amount)

            ' Show formPurchase
            formPurchase.Show()
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        ' Check if any row is selected
        If dgvMain.SelectedRows.Count > 0 Then
            ' Display a confirmation dialog
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Get the selected row
                Dim selectedRow As DataGridViewRow = dgvMain.SelectedRows(0)

                ' Remove the row from the DataGridView
                dgvMain.Rows.Remove(selectedRow)

                ' Clear the selection
                dgvMain.ClearSelection()

                MessageBox.Show("Item removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Please select a row to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class