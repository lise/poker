# language: no

Egenskap: Lese inn bordkort
    Som en operator må jeg kunne registrere hvilke kort som er paa bordet slik at jeg vet hvilke kort som er i spill

  Scenario: skriver inn deltager og 1 bordkort
    Gitt at operator skriver inn 'Ole:KH 10R, Bordkort:KS' 
    Så faar jeg tilbake 'Ole vant'
    
  Scenario: skriver inn to deltakere og 1 bordkort
    Gitt at operator skriver inn 'Ole:KH TR, Mats:KS KR, Bordkort:TH'
    Så faar jeg tilbake 'Mats vant med 1 par' 
    
  Abstrakt Scenario: skriver inn 2 deltakere og 1 bordkort
    Gitt at operator skriver inn 'Ole:<CardsOle>, Mats:<CardsMats>, BordKort:<CardsOnTable>'
    Så faar jeg tilbake '<resultat>'
    
    Eksempler:
    | CardsOle | CardsMats | CardsOnTable | resultat |
    | 8H 8H    | 1H 2R     | 3R           | Ole vant med 1 par |
    | 1H 2S    | 4R 1S     | 4H           | Mats vant med 1 par |