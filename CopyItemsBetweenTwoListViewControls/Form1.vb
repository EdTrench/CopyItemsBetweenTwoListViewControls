Public Class frmFamilyMembers

    Private Sub frmFamilyMembers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim familyPerson1 As New FamilyPerson With {.Forename = "Sarah",
                                                    .Surname = "Trenchard",
                                                    .DOB = "26/04/1978"}

        Dim familyPerson2 As New FamilyPerson With {.Forename = "Ed",
                                                    .Surname = "Trenchard",
                                                    .DOB = "13/08/1977"}


        Dim familyPerson3 As New FamilyPerson With {.Forename = "Kay",
                                                    .Surname = "Trenchard",
                                                    .DOB = "04/05/1955"}


        Dim familyPerson4 As New FamilyPerson With {.Forename = "Caroline",
                                                    .Surname = "Turner",
                                                    .DOB = "31/10/1976"}

        Dim familyPerson5 As New FamilyPerson With {.Forename = "Alan",
                                                    .Surname = "Turner",
                                                    .DOB = "01/05/1950"}

        Dim familyPerson6 As New FamilyPerson With {.Forename = "Lynne",
                                                    .Surname = "Turner",
                                                    .DOB = "12/12/1940"}


        Dim leftSidePersons As New List(Of FamilyPerson)
        Dim rightSidePersons As New List(Of FamilyPerson)

        leftSidePersons.Add(familyPerson1)
        leftSidePersons.Add(familyPerson2)
        leftSidePersons.Add(familyPerson3)

        rightSidePersons.Add(familyPerson4)
        rightSidePersons.Add(familyPerson5)
        rightSidePersons.Add(familyPerson6)

        With Me.lvwLeft
            .View = View.Details
            .GridLines = True
            .FullRowSelect = True
            .HideSelection = False
            .Columns.Add("Surname").Width = 150
            .Columns.Add("Forename").Width = 100
            .Columns.Add("DOB").Width = 70
        End With

        For Each person In leftSidePersons
            Dim item As New ListViewItem
            With item
                .Text = person.Surname
                .SubItems.Add(person.Forename)
                .SubItems.Add(person.DOB.ToShortDateString)
            End With
            Me.lvwLeft.Items.Add(item)
        Next

        With Me.lvwRight
            .View = View.Details
            .GridLines = True
            .FullRowSelect = True
            .HideSelection = False
            .Columns.Add("Surname").Width = 150
            .Columns.Add("Forename").Width = 100
            .Columns.Add("DOB").Width = 70
        End With

        For Each person In rightSidePersons
            Dim item As New ListViewItem
            With item
                .Text = person.Surname
                .SubItems.Add(person.Forename)
                .SubItems.Add(person.DOB.ToShortDateString)
            End With
            Me.lvwRight.Items.Add(item)
        Next

    End Sub

    Private Sub btnCopy_Click(sender As Object, e As System.EventArgs) Handles btnCopy.Click

        If Not Me.lvwLeft.SelectedItems.Count = 0 Then

            Dim lvi As ListViewItem = Me.lvwLeft.SelectedItems(0)
            Dim lvi2 As ListViewItem = CType(lvi.Clone, ListViewItem)

            Me.lvwRight.Items.Insert(0, lvi2)
            Me.lvwLeft.Items.Remove(Me.lvwLeft.SelectedItems(0))

        End If
    End Sub

    Private Sub btnCopyBack_Click(sender As Object, e As System.EventArgs) Handles btnCopyBack.Click

        If Not Me.lvwRight.SelectedItems.Count = 0 Then

            Dim lvi As ListViewItem = Me.lvwRight.SelectedItems(0)
            Dim lvi2 As ListViewItem = CType(lvi.Clone, ListViewItem)

            Me.lvwLeft.Items.Insert(0, lvi2)
            Me.lvwRight.Items.Remove(Me.lvwRight.SelectedItems(0))

        End If

    End Sub

End Class
