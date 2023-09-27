using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using projeto_mvc.Models;

namespace projeto_mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(1, "Iury", "123.123.123-12", "iury@email.com", "Bartolomeu");
        Cliente cliente2 = new Cliente(2, "Jonas", "123.123.123-12", "jonasy@email.com", "Spike");
        Cliente cliente3 = new Cliente(3, "Joao", "123.123.123-12", "joao@email.com", "Luna");
        Cliente cliente4 = new Cliente(4, "Maria", "123.123.123-12", "maria@email.com", "Pirone");
        Cliente cliente5 = new Cliente(5, "Julia", "123.123.123-12", "julia@email.com", "Lala");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1 = new Fornecedor(1, "Petz", "12.123.123/1231-12", "petz@email.com");
        Fornecedor fornecedor2 = new Fornecedor(2, "Cobasi", "12.123.123/1231-12", "cobasi@email.com");
        Fornecedor fornecedor3 = new Fornecedor(3, "Dale Dogs", "12.123.123/1231-12", "daledogs@email.com");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);

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
