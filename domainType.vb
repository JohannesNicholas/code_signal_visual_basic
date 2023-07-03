' https://app.codesignal.com/challenge/ENTkv7rJ3TxdNPoeo

Function solution(domains As List(Of String)) As List(Of String) 
    Dim output As New List(Of String)
    Dim topLevelDomains As New Dictionary(Of String, String) From {
        {"org", "organization"},
        {"com", "commercial"},
        {"net", "network"},
        {"info", "information"}
    }

    For Each domain As String In domains
        Dim parts as String() = domain.Split(".")
        Dim topLevelDomain As String = parts(parts.Length - 1)
        Dim topLevelDomainName As String = topLevelDomains(topLevelDomain)
        output.Add(topLevelDomainName)
    Next

    Return output
End Function
