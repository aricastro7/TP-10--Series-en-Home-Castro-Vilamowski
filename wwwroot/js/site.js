function MostrarInfoSerie(IdS)
{
    $.ajax({
        type: 'POST',
        dataType: 'JSON', 
        url: '/Home/VerMasInfo',
        data: { idSerie: IdS }, 
        success:
            function(response){
                $("#TituloSerie").html("Informacion de la serie " + response.nombre + "<br>");
                $("#InfoSerie").html("Año de inicio: " + response.añoInicio + " Sinopsis: " + response.sinopsis);
            }
    })
}
function MostrarActores(IdS)
{
    $.ajax({
        type: 'POST',
        dataType: 'JSON', 
        url: '/Home/VerActores',
        data: { idSerie: IdS }, 
        success:
            function(response){
                const nombres = response.map(actor => actor.nombre);
                let listaactores = "";
                for(let nombre of nombres){
                    listaactores += nombre+"<br>";
                }
                $("#InfoSerie").html(listaactores);
            }
    })
}function MostrarInfoSerie(IdS)
{
    $.ajax({
        type: 'POST',
        dataType: 'JSON', 
        url: '/Home/VerTemporadas',
        data: { idSerie: IdS }, 
        success:
            function(response){
                const titulos = response.map(temporada => temporada.tituloTemporada);
                let listatitulos = "";
                for(let titulo of titulos){
                    listatitulos += titulo+"<br>";
                }
                $("#InfoSerie").html("Titulos de temporadas: <br>"+listatitulos);
            }
    })
}