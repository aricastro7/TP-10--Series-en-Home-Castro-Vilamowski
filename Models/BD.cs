using System.Data.SqlClient;
using Dapper;
public static class BD{
    private static string _connectionString=@"Server=localhost; Database=BDSeries; Trusted_Connection=True;";
    public static List<Actor> ListaActores(int idSerie){
        List<Actor> _ListadoActores = new List<Actor>();
        string SQL = "SELECT * FROM Actores WHERE IdSerie = @pidSerie";
        using(SqlConnection db = new SqlConnection(_connectionString))
        _ListadoActores =db.Query<Actor>(SQL, new {pidSerie = idSerie}).ToList();
     return _ListadoActores;   
    }
    public static List<Serie> ListaSeries(){
        List<Serie> _ListadoSeries = new List<Serie>();
        string SQL = "SELECT * FROM Series";
        using(SqlConnection db = new SqlConnection(_connectionString))
        _ListadoSeries =db.Query<Serie>(SQL).ToList();
     return _ListadoSeries;   
    }
    public static List<Temporada> ListaTemporadas(int idSerie){
        List<Temporada> _ListadoTemporadas = new List<Temporada>();
        string SQL = "SELECT * FROM Temporadas WHERE IdSerie = @pidSerie";
        using(SqlConnection db = new SqlConnection(_connectionString))
        _ListadoTemporadas =db.Query<Temporada>(SQL, new {pidSerie = idSerie}).ToList();
     return _ListadoTemporadas;   
    }
    public static Serie TraerUnaSerie(int idSerie){
        Serie _UnaSerie = new Serie();
        string SQL = "SELECT * FROM Series WHERE IdSerie = @pidSerie";
        using(SqlConnection db = new SqlConnection(_connectionString))
        _UnaSerie =db.QueryFirstOrDefault<Serie>(SQL, new {pidSerie = idSerie});
     return _UnaSerie;   
    }

}