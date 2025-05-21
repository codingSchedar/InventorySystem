Public Class formPurchase
    Private Sub formPurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDestination.DropDownStyle = ComboBoxStyle.DropDownList
        cmbItemName.DropDownStyle = ComboBoxStyle.DropDownList

        If cmbSupplier.Items.Count = 0 Then
            cmbSupplier.Items.Add("Supplier A")
            cmbSupplier.Items.Add("Supplier B")
            cmbSupplier.Items.Add("Supplier C")
            cmbSupplier.Items.Add("Supplier D")
            cmbSupplier.Items.Add("Supplier E")
        End If


        If cmbDestination.Items.Count = 0 Then
            cmbDestination.Items.Add("Branch A")
            cmbDestination.Items.Add("Branch B")
            cmbDestination.Items.Add("Branch C")
            cmbDestination.Items.Add("Branch D")
            cmbDestination.Items.Add("Branch E")
        End If


    End Sub

    Private Sub cmbSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSupplier.SelectedIndexChanged
        ' Clear existing items in cmbItemName
        cmbItemName.Items.Clear()

        ' Get the selected supplier from cmbSupplier
        Dim selectedSupplier As String = cmbSupplier.SelectedItem.ToString()

        ' Populate cmbItemName based on the selected supplier
        ' Perform necessary logic to determine the items
        If selectedSupplier = "Supplier A" Then
            cmbItemName.Items.Add("Espresso machine")
            cmbItemName.Items.Add("Coffee grinder")
            cmbItemName.Items.Add("Coffee beans")
            cmbItemName.Items.Add("Coffee mugs")
        ElseIf selectedSupplier = "Supplier B" Then
            cmbItemName.Items.Add("Commercial coffee maker")
            cmbItemName.Items.Add("Milk frother")
            cmbItemName.Items.Add("Syrups")
        ElseIf selectedSupplier = "Supplier C" Then
            cmbItemName.Items.Add("Blender")
            cmbItemName.Items.Add("Sweeteners")
        ElseIf selectedSupplier = "Supplier D" Then
            cmbItemName.Items.Add("Coffee filters")
            cmbItemName.Items.Add("Coffee cups")
        ElseIf selectedSupplier = "Supplier E" Then
            cmbItemName.Items.Add("Cash register")
            cmbItemName.Items.Add("Toppings")
        End If

        ' Select the first item in cmbItemName if available
        If cmbItemName.Items.Count > 0 Then
            cmbItemName.SelectedIndex = 0
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Check if all necessary fields are selected
        If cmbSupplier.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If cmbDestination.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a destination.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If cmbItemName.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If nudAmount.Value = 0 Then
            MessageBox.Show("Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if the same item is already present in the dgvInventory
        Dim existingRow As DataGridViewRow = dgvInventory.Rows.Cast(Of DataGridViewRow)().FirstOrDefault(Function(row) row.Cells("cItemName").Value.ToString() = cmbItemName.SelectedItem.ToString())

        If existingRow IsNot Nothing Then
            ' Update the amount for the existing item
            Dim currentAmount As Integer = Integer.Parse(existingRow.Cells("cAmount").Value.ToString())
            Dim newAmount As Integer = currentAmount + nudAmount.Value
            existingRow.Cells("cAmount").Value = newAmount.ToString()
            MessageBox.Show("Item amount updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Add a new row to dgvInventory
            dgvInventory.Rows.Add(cmbItemName.SelectedItem.ToString(), nudAmount.Value.ToString())
            MessageBox.Show("Item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub dgvInventory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellContentClick
        ' Check if the clicked cell is in the "cAction" column and the clicked element is a link (text)
        If dgvInventory.Columns(e.ColumnIndex).Name = "cAction" Then
            ' Display a confirmation dialog
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Get the current row
                Dim selectedRow As DataGridViewRow = dgvInventory.Rows(e.RowIndex)

                ' Remove the row from the DataGridView
                dgvInventory.Rows.Remove(selectedRow)

                MessageBox.Show("Item removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Check if there are no selections in cmbSupplier and cmbDestination
        If cmbSupplier.SelectedItem Is Nothing OrElse cmbDestination.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a supplier and destination.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if there are no rows in dgvInventory
        If dgvInventory.Rows.Count = 0 Then
            MessageBox.Show("Please add items to the inventory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Get the current date
        Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd")

        ' Get the selected supplier and destination
        Dim selectedSupplier As String = cmbSupplier.SelectedItem.ToString()
        Dim selectedDestination As String = cmbDestination.SelectedItem.ToString()

        ' Iterate through each row in dgvInventory
        For Each row As DataGridViewRow In dgvInventory.Rows
            ' Extract data from each row
            Dim item As String = row.Cells("cItemName").Value.ToString()
            Dim amount As String = row.Cells("cAmount").Value.ToString()

            ' Check if the row already exists in formMain.dgvMain
            Dim rowIndex As Integer = -1
            For i As Integer = 0 To formMain.dgvMain.Rows.Count - 1
                If formMain.dgvMain.Rows(i).Cells("cItem").Value.ToString() = item AndAlso
                   formMain.dgvMain.Rows(i).Cells("cSource").Value.ToString() = selectedSupplier AndAlso
                   formMain.dgvMain.Rows(i).Cells("cDestination").Value.ToString() = selectedDestination Then
                    rowIndex = i
                    Exit For
                End If
            Next

            If rowIndex <> -1 Then
                ' Row already exists, update the values
                formMain.dgvMain.Rows(rowIndex).Cells("cDateOrder").Value = currentDate
                formMain.dgvMain.Rows(rowIndex).Cells("cAmount").Value = amount
            Else
                ' Row doesn't exist, add a new row
                formMain.dgvMain.Rows.Add(item, currentDate, amount, selectedSupplier, selectedDestination)
            End If
        Next

        ' Close the current form (formPurchase)
        Me.Close()
    End Sub




End Class