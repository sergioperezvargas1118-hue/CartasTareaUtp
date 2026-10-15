// For more information see https://aka.ms/fsharp-console-apps

open System

type Pinta =
| Diamantes
| Corazones
| Picas
| Treboles

type Carta =
| As of Pinta
| J of Pinta
| Q of Pinta
| K of Pinta
| Numero of int*Pinta

let baraja = [|
    for j in [Diamantes;Corazones;Picas;Treboles] do
        As j
        for i in [2..10] do

            Numero (i,j)
        J j
        Q j
        K j
|]

let barajar2 mazo =
    let rnd = Random()
    mazo |> Array.sortBy (fun _ -> rnd.Next())


baraja
|>  barajar2
|> Array.iter( fun carta -> printfn $"{carta}")