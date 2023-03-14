using API.Dtos;
using Microsoft.AspNetCore.Mvc;
using OriontekMVC.Models;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace OriontekMVC.Controllers
{
    public class ClientesContactoController : Controller
    {
        // GET: ClientesContactoController
        public async Task<ActionResult> Index()
        {
            RequestAPI<ClienteContactoDto> requestAPI = new RequestAPI<ClienteContactoDto>(HttpMethod.Get, "https://localhost:44341/api/ClienteContacto", null);
            return View(await requestAPI.RequestAPIListAsync());
        }

        // GET: ClientesContactoController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            RequestAPI<ClienteContactoDto> requestAPI = new RequestAPI<ClienteContactoDto>(HttpMethod.Get, "https://localhost:44341/api/ClienteContacto/"+ id, null);
            return View(await requestAPI.RequestAPISingleAsync());
        }

        // GET: ClientesContactoController/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: ClientesContactoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ClienteContactoDto collection)
        {
            try
            {
                RequestAPI<ClienteContactoDto> requestAPI = new RequestAPI<ClienteContactoDto>(HttpMethod.Post, "https://localhost:44341/api/ClienteContacto/", collection);
                await requestAPI.RequestAPIAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientesContactoController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            RequestAPI<ClienteContactoDto> requestAPI = new RequestAPI<ClienteContactoDto>(HttpMethod.Get, "https://localhost:44341/api/ClienteContacto/" + id, null);
            return View(await requestAPI.RequestAPISingleAsync());
        }

        // POST: ClientesContactoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, ClienteContactoDto collection)
        {
            try
            {
                RequestAPI<ClienteContactoDto> requestAPI = new RequestAPI<ClienteContactoDto>(HttpMethod.Put, "https://localhost:44341/api/ClienteContacto/" + id, collection);
                await requestAPI.RequestAPIAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientesContactoController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            RequestAPI<ClienteContactoDto> requestAPI = new RequestAPI<ClienteContactoDto>(HttpMethod.Get, "https://localhost:44341/api/ClienteContacto/" + id, null);
            return View(await requestAPI.RequestAPISingleAsync());
        }

        // POST: ClientesContactoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, ClienteContactoDto collection)
        {
            try
            {
                RequestAPI<ClienteContactoDto> requestAPI = new RequestAPI<ClienteContactoDto>(HttpMethod.Delete, "https://localhost:44341/api/ClienteContacto/" + id, null);
                await requestAPI.RequestAPIAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
