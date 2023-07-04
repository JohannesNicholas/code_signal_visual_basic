' https://app.codesignal.com/challenge/FxEhqJturP6PpgKfw

Function solution(rideLengthMiles As Integer, fares As List(Of Double)) As String 
    Dim uberRideOptions = {"UberX", "UberXL", "UberPlus", "UberBlack", "UberSUV"}
    Dim rideRates = {0.3, 0.5, 0.7, 1, 1.3}

    Dim maxCost = 20

    Dim bestValueIndex = 0

    Dim rideCosts = fares.Select(Function(fare) fare * rideLengthMiles).ToList()
   
    For i = 1 To rideCosts.Count - 1
        If rideCosts(i) > maxCost Then Exit For
        If rideCosts(i) > rideCosts(bestValueIndex) Then bestValueIndex = i        
    Next

    Return uberRideOptions(bestValueIndex)
End Function
