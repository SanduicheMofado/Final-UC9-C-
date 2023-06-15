using System;

namespace projetofinal
{
    class Program
    {
        public static string tipo, material, cor, frete; 
        public static decimal valtipo, valmaterial, valcor, valdestino, valfrete;
        static void Linha()
        {Console.WriteLine("===========================================");}
        static void Main(string[] args)
        {
            int optipo, opmaterial, opcor, quant, tel, numero, cep, ddd, opfrete;
            string rua, cidade, uf;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("      Loja de móveis para escritório");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Linha();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("    --  Escolha o tipo de cadeira:  --"+
                            "\n[1].Normais     [2].Girátorias     [3].Poltronas"+
                            "\n [R$150,00]       [R$500,00]         [R$900,00]\n");
            optipo = Convert.ToInt32(Console.ReadLine());

            if (optipo == 1)
            { valtipo = 150.00m; }
            else if (optipo == 2)          //Atribuindo valor
            { valtipo = 500.00m; }
            else if (optipo == 3)
            { valtipo = 900.00m; }
            else if (optipo!=1 && optipo!=2 && optipo!=3)//Verificando se é diferente de 1,2 ou 3
            { Console.WriteLine("Opção inválida, tente novamente."); }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Linha();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\n    -- Escolha o material metálico: --"+
                              "\n  [1].Ferro         [2].Inox"+
                              "\n  [R$120,00]        [R$520,00]\n");
            opmaterial = Convert.ToInt32(Console.ReadLine());

            if (opmaterial == 1)
            { valmaterial = 120.00m; }
            else if (opmaterial == 2)          //Atribuindo valor
            { valmaterial = 520.00m; }
            else if (opmaterial != 1 && opmaterial != 2)//Verificando se é diferente de 1 ou 2
            { Console.WriteLine("Opção inválida, tente novamente."); }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Linha();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\n    -- Escolha a cor do tecido: --"+
                              "\n[1].Vermelho    [2].Amarelo    [3].Preto    [4].Azul  "+
                              "\n  [R$250,00]    [R$200,00]     [R$0,00]     [R$380,00]\n");
            opcor = Convert.ToInt32(Console.ReadLine());

            if (opcor == 1)
            { valcor = 250.00m; }
            else if (opcor==2)
            { valcor = 200.00m; }
            else if (opcor==3)              //atribuindo valor
            { valcor = 0.00m; }
            else if (opcor==4)
            { valcor = 380.00m; }
            else if (opcor != 1 && opcor != 2 && opcor != 3 && opcor !=4)//Verificando se é diferente de 1,2,3 ou 4
            { Console.WriteLine("Opção inválida, tente novamente."); }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Linha();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\n    -- Informe seu endereço de entrega: --");
            Console.WriteLine("Rua: ");
            rua = Console.ReadLine();
            Console.WriteLine("N°: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cidade: ");
            cidade = Console.ReadLine();
            Console.WriteLine("UF: ");
            uf = Console.ReadLine();
            Console.WriteLine("CEP: ");
            cep = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Telefone: ");
            tel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("DDD: ");
            ddd = Convert.ToInt32(Console.ReadLine());
            uf = uf.ToUpper();//convertendo uf para maíusculo

            switch (uf)//atríbui valor
              { case "SP":valdestino = 150.00m;break;
                case "MG":valdestino = 150.00m;break;
                case "RJ":valdestino = 150.00m;break;
                case "ES":valdestino = 150.00m;break;
                case "PR":valdestino = 200.00m;break;
                case "SC":valdestino = 200.00m;break;
                case "RS":valdestino = 200.00m;break;
                default:valdestino = 350.00m;break; }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Linha();
            Console.ForegroundColor = ConsoleColor.Yellow;

            if (uf=="SP")//UF = SP
            { Console.WriteLine("\n    --Escolha o tipo de frete: --" +
                          "\n[1].Transportadora XXX    [2].Correios SEDEX    [3].Correios PAC" +
                          "\n     [R$300,00]                [R$80,00]            [R$220,00]\n"); }

            else if (uf!="SP") //UF diferente de SP
            { Console.WriteLine("\n    --Escolha o tipo de frete: --" +
                          "\n[1].Transportadora XXX    [2].Correios SEDEX    [3].Correios PAC" +
                          "\n     [R$300,00]                 [R$85,00]            [R$200,00]\n"); }
            opfrete = Convert.ToInt32(Console.ReadLine());

            if (opfrete == 1)
            { valfrete = 300.00m; }
            else if (opfrete == 2 && uf == "SP")
            { valfrete = 80.00m; }
            else if (opfrete == 2 && uf != "SP")
            { valfrete = 85.00m; }
            else if (opfrete == 3 && uf == "SP")
            { valfrete = 220.00m; }
            else if (opfrete == 3 && uf != "SP")
            { valfrete = 200.00m; }
            else if (opfrete != 1 && opfrete != 2 && opfrete != 3)
            { Console.WriteLine("Opção inválida, tente novamente."); }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Linha();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\nQuantas cadeiras deseja?\n");
            quant=Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Linha();
            Console.ForegroundColor = ConsoleColor.Yellow;

            switch (optipo)
            {   case 1:tipo = "normal"; break;
                case 2:tipo = "girátoria"; break;
                case 3:tipo = "poltrona"; break;}
            switch (opmaterial)
            {   case 1:material = "ferro"; break;
                case 2:material = "inox"; break;}
            switch (opcor)
            {   case 1:cor = "vermelho"; break;
                case 2:cor = "amarelo"; break;
                case 3:cor = "preto"; break;
                case 4:cor = "azul"; break;}
            switch (opfrete)
            {   case 1:frete = "Transportadora XX"; break;
                case 2:frete = "Correios SEDEX"; break;
                case 3:frete = "Correios PAC"; break;}

            decimal valcad = (valtipo + valmaterial + valcor) * quant;//Valor das cadeiras
            decimal valtot = valcad + valdestino + valfrete;
            Console.WriteLine("\n    -- Dados da cadeira solicitada --" +
                              "\nTipo de cadeira escolhida: "+tipo+" - "+valtipo+
                              "\nTipo de material escolhido: "+material+" - "+valmaterial+
                              "\nCor do tecido escolhido: "+cor+" - "+valcor+
                              "\nQuantidade de cadeiras: "+quant+
                              "\nValor total: "+valcad);
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Linha();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\n\nValores a pagar: " +
                  "\nCadeiras: " + (valtipo + valmaterial + valcor) * quant +
                  "\nUF de destino: " + uf + " - " + valdestino +
                  "\nFrete Escolhido: " + frete + " - " + valfrete +
                  "\nValor total: " + valtot);
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Linha();
            Console.ForegroundColor = ConsoleColor.Yellow;

            decimal desc = valtot - (0.05m * valtot);//calculo do desconto
            Console.WriteLine("\n    -- Forma de pagamento: --" +
                              "\n[1].Dinheiro a vista (5% desc): " + desc +
                              "\n      -- Crédito: --" +
                              "\n[2].3X de R$" + valtot / 3);

            if (valtot > 6000.00m)
            {Console.WriteLine("\n[3].6X de R$" + valtot/6 +
                               "\n[4].10X de R$" + valtot/10);}

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Linha();
            Console.ForegroundColor = ConsoleColor.Yellow;

            int pag= Convert.ToInt32(Console.ReadLine());
            if (valtot < 6000.00m && pag != 1 && pag != 2)//verificando se as opções 3 e 4 podem ser selecionadas
            { Console.WriteLine("Opção inválida!"); }

            switch (pag)
            {   case 1:Console.WriteLine("Total: R$"+desc+"\nTipo de pagamento: Dinheiro a vista\nUF: "+uf+"\nCidade: "+cidade+"\nRua: "+rua+" N°"+numero);break;
                case 2:Console.WriteLine("Total: R$"+valtot+"\nTipo de pagamento: 3X de R$"+valtot/3+"\nUF: "+uf+"\nCidade: "+cidade+"\nRua: "+rua+" N°"+numero);break;
                case 3:Console.WriteLine("Total: R$"+valtot+"\nTipo de pagamento: 6X de R$"+valtot/6+"\nUF: "+uf+"\nCidade: "+cidade+"\nRua: "+rua+" N°"+numero);break;
                case 4:Console.WriteLine("Total: R$"+valtot+"\nTipo de pagamento: 10X de R$"+valtot/10+"\nUF: "+uf+"\nCidade: "+cidade+"\nRua: "+rua+" N°"+numero);break; }
            Console.ReadKey();}}}