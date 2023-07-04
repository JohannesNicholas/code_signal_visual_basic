' https://app.codesignal.com/challenge/iBRLaC2LMW32ggB8P

Function solution(adj As List(Of List(Of Boolean))) As Boolean 
    dim nodesWith2Edges = 0
    dim nodesWith4Edge = 0

    for i = 0 to adj.Count - 1

        if adj(i)(i) then return false ' self-loop

        dim edges = 0
        for j = 0 to adj(i).Count - 1
            if adj(i)(j) then edges += 1
        next
        if edges = 2 then nodesWith2Edges += 1
        if edges = 4 then nodesWith4Edge += 1
        if edges <> 2 andalso edges <> 4 then return false
    next

    if nodesWith2Edges <> 4 then return false
    if nodesWith4Edge <> 1 then return false

    return true
End Function
