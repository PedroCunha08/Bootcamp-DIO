using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

bool? ReceberEmail = true;

if(ReceberEmail.HasValue && ReceberEmail.Value)
{
    Console.WriteLine("O usuario deseja receber email");
}
else
{
    Console.WriteLine("O usuario não respondeu ou optou por não receber email");
}