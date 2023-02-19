open lib.Say

printfn "Hello from F#"
(hello "Cain")

[<EntryPoint>]
let main args =
    printfn "Arguments: %A" args

    0