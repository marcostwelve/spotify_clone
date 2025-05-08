
namespace Modelos.Models
{
    public class Media
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string UrlImagem { get; set; } = string.Empty;
        public string UrlMidia { get; set; } = string.Empty;
        public int Visualizacoes { get; set; }
        public string Categoria { get; set; } = string.Empty;
        public DateTime DataPublicacao { get; set; } = DateTime.Now;
    }
}
