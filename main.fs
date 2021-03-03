module Assignment

// DO NOT MODIFY LEFT PART OF `LET` OPERATOR

// Define following distance unit transformations
let inchToMillimeter v =
    v * 25.4 // write your code here

let footToInch x =
    x*12.0 // write your code here

let yardToFoot v =
    v*3.0 // write your code here

let mileToYard mile =
    mile*1760.0 // write your code here

(*
Use ONLY above functions and the forward pipe operator, `|>`,  to define the following unit transformation

Forward pipe operator passes the result of the left side to the function on the right side.
*)
let yardToMillimeter y =
    yardToFoot y |> footToInch |> inchToMillimeter // write your code here

// Define the curried function `divBy1000` that has the signature `float -> float`
let divBy1000 =
    fun x->x /1000.0// write your code here

(*
Use ONLY above functions to define the following two functions. DO NOT CHANGE SIGNATURES!
*)
let millimeterToMeter n =
    divBy1000 n // write your code here

let meterToKilometer =
    divBy1000 // write your code here

(*
Use above functions and function composition operator, `>>`, to define the following unit transformations

Forward composition operator composes two functions into one.
*)
let millimeterToKilometer =
    divBy1000 >> divBy1000 // write your code here

let inchToMeter =
    
    inchToMillimeter>>divBy1000 // write your code here

let yardToKilometer =
    yardToFoot>>footToInch>>inchToMillimeter>>divBy1000>>divBy1000

let mileToMeter =
    mileToYard>>yardToFoot>>footToInch>>inchToMillimeter>>divBy1000 // write your code here


// Define following weight unit transformations
let ounceToGram v =
    v * 28.349523125 // write your code here

let poundToOunce p =
    p * 16.0 // write your code here

let shortTonToPound t =
    t*2000.0 // write your code here


(*
Use ONLY above functions to define the following two functions. DO NOT CHANGE SIGNATURES!
*)

let gramToKilogram g =
    divBy1000 g // write your code here

(*
Use ONLY above functions and function composition operator, `>>`, to define the following unit transformations

Forward composition operator composes two functions into one.
*)

let gramToMetricTon =
    divBy1000 >> divBy1000 // write your code here

let poundToKilogram =
    poundToOunce>>ounceToGram>>divBy1000 // write your code here

let shortTonToMetricTon =
    shortTonToPound>>poundToOunce>>ounceToGram>>divBy1000>>divBy1000 // write your code here
