using SimpleGameOfLife;

Game.Run();


/*
    Mål: "Bli komfortabel med C#" - mestre det dere kan fra JavaScript i C#

    Noen ting som er annerledes: 
     - arrays
     - overloads og default parametre
     - casting og enum
     - klassevariable
     - using
     - public/private
 - oppsumering av matten?

    Game of life
    "simulering av celler, liv"

     -  Any live cell with fewer than two live neighbours dies, as if by underpopulation.
     -  Any live cell with two or three live neighbours lives on to the next generation.
     -  Any live cell with more than three live neighbours dies, as if by overpopulation.
     -  Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction

    1: Modell
    2: Fylle modell med tilfeldige data
    3: Vise alle cellene (view)
    4: Loope og endre tilfeldig
    5: Endre ut fra reglene
       - telle naboer
       - bestemme om hver celle skal leve eller ikke i neste generasjon
       
    
*/