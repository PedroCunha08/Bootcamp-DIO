using C_Aula11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

DateTime dataAtual = DateTime.Now;

List<Vendas> ListaVendas = new List<Vendas>();

Vendas v1 = new Vendas(1, "Material Escritorio",  25.00M, dataAtual);
Vendas v2 = new Vendas(2, "Licença Software",   1200.00M, dataAtual);
Vendas v3 = new Vendas(3, "Material de Limpeza", 500.00M, dataAtual);
Vendas v4 = new Vendas(4, "Oficina Mecanica",    350.00M, dataAtual);
Vendas v5 = new Vendas(5, "Tinta Impressoras",   200.00M, dataAtual);

ListaVendas.Add(v1);
ListaVendas.Add(v2);
ListaVendas.Add(v3);
ListaVendas.Add(v4);
ListaVendas.Add(v5);

//Vendas v1 = new Vendas(1, "Material Escritorio", 25.00M);
string serializado = JsonConvert.SerializeObject(ListaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

//Agora vamos verificar como é o resultado desta conversão em trela

Console.WriteLine(serializado);
