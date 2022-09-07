using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Persistencia;
using Torneo.App.Dominio;

namespace Torneo.App.Frontend.Pages.Jugadores
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioJugador _repoJugadores;
        public IEnumerable<Jugador> jugadores { get; set; }
        public IndexModel(IRepositorioJugador repoJugadores)
        {
            _repoJugadores = repoJugadores;
        }
        public void OnGet()
        {
            jugadores = _repoJugadores.GetAllJugadores();
        }
    }
}
