﻿using System.Globalization;
using Newtonsoft.Json;
using ExemploExplorando.Models;
using Models;

int numero = 20;
bool par = false;

par = numero.EhPar();

string mensagem = "O número " + numero + " " + "é " + (par ? "par!" : "ímpar!");
Console.WriteLine(mensagem);