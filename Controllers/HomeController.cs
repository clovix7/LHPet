using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {    
        //instancias dos tiplo cliente
        Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira", "857.032.950-41", "arthur@senai.br", "Madruga");
        Cliente cliente2 = new Cliente(02, "José Melão", "957.032.950-41", "melao@senai.br", "Rex");
        Cliente cliente3 = new Cliente(03, "João Repolho", "757.032.950-41", "repolho@senai.br", "Caramelo");
        Cliente cliente4 = new Cliente(04, "Francisco Abóbora", "657.032.950-41", "abobora@senai.br", "Pingo");
        Cliente cliente5 = new Cliente(05, "Marias das Couves", "557.032.950-41", "couves@senai.br", "Pirulito");

        //lista de clientes e atribui os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        //instancia tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "Ração Pet", "97.999.111/001-99", "racao@pet.br");
        Fornecedor fornecedor2 = new Fornecedor(02, "Nex Pet", "99.999.111/001-99", "net@peti.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "Boa Tosa", "98.999.111/001-99", "boatosa@tosa.br");
        Fornecedor fornecedor4 = new Fornecedor(04, "Shampoo Pet", "95.999.111/001-99", "info@shampoo.br");
        Fornecedor fornecedor5 = new Fornecedor(05, "Colera Nova", "94.999.111/001-99", "colera@nova.br");

        //lista de fornecedor e atribui os fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
