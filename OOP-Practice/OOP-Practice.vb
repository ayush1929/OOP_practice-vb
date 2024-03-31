Public Class Form1
    Private cars As New List(Of Car)() ' Define a list to store Car objects
    Private Sub btnCreateInstances_Click(sender As Object, e As EventArgs) Handles btnCreateInstances.Click
        Dim car1 As New Car("Toyota", "Camry", 2020)
        Dim car2 As New Car("Ford", "Mustang", 2018)
        Dim car3 As New Car("Honda", "Civic", 2019)

        cars.Add(car1)
        cars.Add(car2)
        cars.Add(car3)

        lstInstances.Items.Add($"{car1.Make} {car1.Model} ({car1.Year})")
        lstInstances.Items.Add($"{car2.Make} {car2.Model} ({car2.Year})")
        lstInstances.Items.Add($"{car3.Make} {car3.Model} ({car3.Year})")
    End Sub

    Private Sub btnShowDetails_Click(sender As Object, e As EventArgs) Handles btnShowDetails.Click
        If lstInstances.SelectedIndex <> -1 Then
            Dim selectedCar As Car = cars(lstInstances.SelectedIndex)
            MessageBox.Show(selectedCar.GetDetails())
        Else
            MessageBox.Show("Please select a car from the list.")
        End If
    End Sub

End Class
