using System;
using System.Collections;
using System.Globalization;
using Newtonsoft.Json;
using C_Aula11.Models;

namespace C_Aula11.Program
{
    public class  FProngram
    {
        string conteudoArquivo = File.ReadAllText("Arquivos / Vendas.json");
        List<ImportVendas> ListaVenda = JsonConvert.DeserializeObject<List<ImportVendas>>(conteudoArquivo);

        foreach (importVenda ListaImport in ListaVenda)
        {
            Console.WriteLine($"Id: {_Id}, Produto: {_Produto}");
            
        }

    }

}