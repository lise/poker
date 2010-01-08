# language: no

Egenskap: Lese inn bordkort
    Som en operatør må jeg kunne registrere hvilke kort som er på bordet slik at jeg vet hvilke kort som er i spill

  Abstrakt Scenario: skriver inn bordkort
    Gitt at operator skriver inn Bordkort <input>
    Så faar jeg tilbake Registrert kort <output> paa bordet.
    
    Eksempler:
    | input | output |
    | KH 10R | KH 10R |
    | KH | KH |
    | KH 10R 9S | KH 10R 9S |
    