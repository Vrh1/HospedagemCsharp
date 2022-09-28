using System.Text;
using HospedagemCsharp.Models;

Console.OutputEncoding = Encoding.UTF8;

//Cria o modelo e lista de hospedes.
List<Pessoa> hospesdes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospesdes.Add(p1);
hospesdes.Add(p2);

//Crua a suíte;
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

//Cria uyma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospesdes);

//Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
