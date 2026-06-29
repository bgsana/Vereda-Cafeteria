using Microsoft.EntityFrameworkCore;
using Vereda_Cafeteria.Models;

namespace Vereda_Cafeteria.Data.Seeds;

public class SeedProduto
{
    public SeedProduto(ModelBuilder builder)
    {
        List<Produto> produtos = new List<Produto>
        {
            #region Pratos Salgados (CategoriaId = 1)

            new Produto
            {
                ProdutoId = 1,
                CategoriaId = 1,
                Nome = "Bolinho de Chuva Salgado da Vó Nice",
                Descricao = "12 bolinhos da receita original da Vó Nice, salgados e acompanhados de molho de queijo gorgonzola. Feitos na hora, com muito afeto e tradição.",
                QtdEstoque = 10,
                Preco = 15.95m,
                ImagemUrl = "/img/produtos/menu/pratos-salgados/bolinho-chuva-salgado.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 2,
                CategoriaId = 1,
                Nome = "Dadinho de Tapioca",
                Descricao = "8 dadinhos de tapioca dourados e crocantes, acompanhados de geleia de pimenta artesanal. Petisco regional com personalidade, vicia desde o primeiro.",
                QtdEstoque = 10,
                Preco = 19.95m,
                ImagemUrl = "/img/produtos/menu/pratos-salgados/dadinho-tapioca.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 3,
                CategoriaId = 1,
                Nome = "Empada de Barra Bonita",
                Descricao = "Empada artesanal fresquinha com recheio barra-bonitense. Sabores: frango c/ milho, frango c/ bacon, brócolis c/ requeijão, alho-poró ou palmito c/ parmesão.",
                QtdEstoque = 10,
                Preco = 15.00m,
                ImagemUrl = "/img/produtos/menu/pratos-salgados/empada.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 4,
                CategoriaId = 1,
                Nome = "Minicoxinha",
                Descricao = "8 minicoxinhas artesanais feitas na hora acompanhadas de molho de alho e ervas. Crocantes por fora, recheadas e quentinhas, impossível comer só uma.",
                QtdEstoque = 10,
                Preco = 16.00m,
                ImagemUrl = "/img/produtos/menu/pratos-salgados/minicoxinha.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 5,
                CategoriaId = 1,
                Nome = "Miniquibe",
                Descricao = "8 miniquibes artesanais com molho de páprica defumada. Crocantes, saborosos e feitos na hora, um petisco que carrega identidade em cada mordida.",
                QtdEstoque = 10,
                Preco = 16.00m,
                ImagemUrl = "/img/produtos/menu/pratos-salgados/miniquibe.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 6,
                CategoriaId = 1,
                Nome = "Omelete",
                Descricao = "Omelete simples preparado na hora com ovos frescos. Leve, dourado e macio, o prato certo pra quem quer algo rápido e bem feito.",
                QtdEstoque = 10,
                Preco = 7.00m,
                ImagemUrl = "/img/produtos/menu/pratos-salgados/omelete.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 7,
                CategoriaId = 1,
                Nome = "Ovos Mexidos + Potinhos de Bacon e Calabresa",
                Descricao = "Ovos mexidos cremosos feitos na hora, servidos com potinhos de bacon e calabresa à parte. Café da manhã completo e caprichado, para começar bem o dia.",
                QtdEstoque = 10,
                Preco = 15.95m,
                ImagemUrl = "/img/produtos/menu/pratos-salgados/ovos-mexidos-potinhos.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 8,
                CategoriaId = 1,
                Nome = "Palito de Parmesão",
                Descricao = "1 palito de parmesão artesanal assado na hora. Crocante por fora, fundido por dentro, aperitivo regional que some antes de chegar à mesa.",
                QtdEstoque = 20,
                Preco = 6.95m,
                ImagemUrl = "/img/produtos/menu/pratos-salgados/palito-de-parmesao.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 9,
                CategoriaId = 1,
                Nome = "Pão com Ovo",
                Descricao = "Pão francês fresquinho com ovo frito no ponto certo. Simples e feito na hora, como o café da manhã de casa deveria ser.",
                QtdEstoque = 15,
                Preco = 6.95m,
                ImagemUrl = "/img/produtos/menu/pratos-salgados/pao-com-ovo.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 10,
                CategoriaId = 1,
                Nome = "Pão de Queijo Recheado",
                Descricao = "Pão de queijo regional assado na hora com recheio à escolha: requeijão, presunto e queijo, calabresa, doce de leite, Nutella ou goiabada.",
                QtdEstoque = 20,
                Preco = 7.95m,
                ImagemUrl = "/img/produtos/menu/pratos-salgados/pao-de-queijo-recheado.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 11,
                CategoriaId = 1,
                Nome = "Pão na Chapa",
                Descricao = "Pão francês na chapa com manteiga. Aquela crocância dourada por fora e maciez por dentro que deixa qualquer café mais gostoso.",
                QtdEstoque = 15,
                Preco = 5.00m,
                ImagemUrl = "/img/produtos/menu/pratos-salgados/pao-na-chapa.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 12,
                CategoriaId = 1,
                Nome = "Torta Artesanal de Barra Bonita",
                Descricao = "Torta artesanal com massa caseira e recheio generoso. Sabores: frango, calabresa, mortadela, carne, costela ou pizza. Feita na hora, com sabor de quitanda.",
                QtdEstoque = 10,
                Preco = 11.95m,
                ImagemUrl = "/img/produtos/menu/pratos-salgados/torta-artesanal.png",
                Ativo = true
            },

            #endregion

            #region Pratos Doces (CategoriaId = 2)

            new Produto
            {
                ProdutoId = 13,
                CategoriaId = 2,
                Nome = "Bolinho de Chuva da Vó Nice",
                Descricao = "12 bolinhos da receita original da Vó Nice com chocolate cremoso caseiro. Memória de infância servida quentinha, receita de quem alimentou gerações.",
                QtdEstoque = 10,
                Preco = 16.00m,
                ImagemUrl = "/img/produtos/menu/pratos-doces/bolinho-chuva-doce.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 14,
                CategoriaId = 2,
                Nome = "Bolo de Caneca Chocolate",
                Descricao = "Bolo de caneca caseiro com cobertura de chocolate feito na hora. Fofo, úmido e quentinho, aquele bolo que parece ter saído direto da cozinha da vovó.",
                QtdEstoque = 10,
                Preco = 15.00m,
                ImagemUrl = "/img/produtos/menu/pratos-doces/bolo-caneca-chocolate.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 15,
                CategoriaId = 2,
                Nome = "Brownie com Calda",
                Descricao = "Brownie artesanal de Barra Bonita com calda de chocolate e chantilly. Casquinha crocante, interior cremoso e denso, puro conforto numa porção só.",
                QtdEstoque = 10,
                Preco = 16.95m,
                ImagemUrl = "/img/produtos/menu/pratos-doces/brownie-calda.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 16,
                CategoriaId = 2,
                Nome = "Brownie com Sorvete",
                Descricao = "Brownie artesanal de Barra Bonita com sorvete artesanal da cidade. O contraste quente e frio que só a Vereda faz do jeito que você vai querer de novo.",
                QtdEstoque = 10,
                Preco = 15.95m,
                ImagemUrl = "/img/produtos/menu/pratos-doces/brownie-sorvete.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 17,
                CategoriaId = 2,
                Nome = "Petit Gateau com Sorvete",
                Descricao = "Petit gateau com coração derretido de chocolate, acompanhado de sorvete creme artesanal de Barra Bonita. Feito na hora, espera com gostinho de recompensa.",
                QtdEstoque = 10,
                Preco = 16.00m,
                ImagemUrl = "/img/produtos/menu/pratos-doces/petit-gateau.png",
                Ativo = true
            },

            #endregion

            #region Cafés (CategoriaId = 3)

            new Produto
            {
                ProdutoId = 18,
                CategoriaId = 3,
                Nome = "Cappuccino",
                Descricao = "250ml de café regional com leite e cacau em pó. Cremoso, aveludado e com aquele equilíbrio perfeito entre café e leite que transforma a pausa no dia.",
                QtdEstoque = 50,
                Preco = 12.00m,
                ImagemUrl = "/img/produtos/menu/cafes/cappuccino.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 19,
                CategoriaId = 3,
                Nome = "Espresso",
                Descricao = "120ml de café regional com água com gás. Encorpado, aromático e com crema dourada, o ponto de partida para quem leva café a sério.",
                QtdEstoque = 50,
                Preco = 6.00m,
                ImagemUrl = "/img/produtos/menu/cafes/espresso.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 20,
                CategoriaId = 3,
                Nome = "Mocaccino",
                Descricao = "250ml de café regional com leite e calda à escolha: leite condensado, doce de leite ou chocolate. Doce, intenso e com camadas de sabor que conquistam.",
                QtdEstoque = 50,
                Preco = 15.00m,
                ImagemUrl = "/img/produtos/menu/cafes/mocaccino.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 21,
                CategoriaId = 3,
                Nome = "Tradição na Mesa",
                Descricao = "Café coado na mesa com coador de pano, a tradição do afeto em cada gole. Leve o coador para casa e continue a história com o sabor da Vereda.",
                QtdEstoque = 20,
                Preco = 12.00m,
                ImagemUrl = "/img/produtos/menu/cafes/tradicao-na-mesa.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 22,
                CategoriaId = 3,
                Nome = "Latte",
                Descricao = "275ml de leite com 50ml de café regional. Aveludado, suave e encorpado, para quem prefere o café como fundo e o leite como protagonista.",
                QtdEstoque = 50,
                Preco = 10.00m,
                ImagemUrl = "/img/produtos/menu/cafes/latte.png",
                Ativo = true
            },

            #endregion

            #region Inspirados (CategoriaId = 4)

            new Produto
            {
                ProdutoId = 23,
                CategoriaId = 4,
                Nome = "Affogato Tietê",
                Descricao = "200ml de café regional com sorvete de chocolate de Barra Bonita e calda de chocolate. Inspirado no rio que banha a cidade, intenso, frio e profundo.",
                QtdEstoque = 15,
                Preco = 12.95m,
                ImagemUrl = "/img/produtos/menu/inspirados/affogato-tiete.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 24,
                CategoriaId = 4,
                Nome = "Beijo de Açúcar",
                Descricao = "200ml de chocolate cremoso com borda de Nutella e raspas de chocolate. Tão doce quanto os canaviais que emolduram Barra Bonita, inspirado no hino da cidade.",
                QtdEstoque = 20,
                Preco = 17.00m,
                ImagemUrl = "/img/produtos/menu/inspirados/beijo-de-acucar.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 25,
                CategoriaId = 4,
                Nome = "Caseiro da Vó Nice",
                Descricao = "Chocolate caseiro em 250ml ou 100ml com gostinho de infância. A receita que a Vó Nice carrega desde 1977 em Barra Bonita, simples, quente e cheio de amor.",
                QtdEstoque = 20,
                Preco = 11.00m,
                ImagemUrl = "/img/produtos/menu/inspirados/caseiro-vo-nice.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 26,
                CategoriaId = 4,
                Nome = "Café Vaporzinho",
                Descricao = "140ml de café regional com mel Europa. Inspirado no vaporzinho do hino da cidade, suave, adocicado e cheio de memória barra-bonitense.",
                QtdEstoque = 20,
                Preco = 9.00m,
                ImagemUrl = "/img/produtos/menu/inspirados/cafe-vaporzinho.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 27,
                CategoriaId = 4,
                Nome = "Major Pompeu",
                Descricao = "Chocolate amargo caseiro em 250ml ou 100ml. Homenagem ao Major Pompeu do hino de Barra Bonita, intenso e marcante como a história da cidade.",
                QtdEstoque = 20,
                Preco = 16.00m,
                ImagemUrl = "/img/produtos/menu/inspirados/major-pompeu.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 28,
                CategoriaId = 4,
                Nome = "Chocolate Simpatia",
                Descricao = "200ml de chocolate cremoso com chantilly e granulado simpatia. Doce, alegre e acolhedor, como o apelido de Barra Bonita que todo mundo conhece.",
                QtdEstoque = 20,
                Preco = 15.00m,
                ImagemUrl = "/img/produtos/menu/inspirados/chocolate-simpatia.png",
                Ativo = true
            },

            #endregion

            #region Bebidas (CategoriaId = 5)

            new Produto
            {
                ProdutoId = 29,
                CategoriaId = 5,
                Nome = "Café Coado com Limão",
                Descricao = "140ml de café regional gelado com rodelas de limão. Azedinho e refrescante, para quem gosta de café com personalidade e não tem medo de experimentar.",
                QtdEstoque = 20,
                Preco = 8.00m,
                ImagemUrl = "/img/produtos/menu/bebidas/cafe-coado-limao.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 30,
                CategoriaId = 5,
                Nome = "Chá Camomila",
                Descricao = "275ml de chá de camomila quente. Suave, floral e calmante como um abraço de dentro pra fora, o chá certo para encerrar um dia cheio com gentileza.",
                QtdEstoque = 20,
                Preco = 5.00m,
                ImagemUrl = "/img/produtos/menu/bebidas/cha-camomila.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 31,
                CategoriaId = 5,
                Nome = "Chá Mate e Guaraná",
                Descricao = "275ml de chá mate com guaraná quente. Energizante, levemente amargo e com aquele sabor do Brasil profundo, para a tarde que precisa de um empurrãozinho.",
                QtdEstoque = 20,
                Preco = 5.00m,
                ImagemUrl = "/img/produtos/menu/bebidas/cha-mate-guarana.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 32,
                CategoriaId = 5,
                Nome = "Frapê Café Caramelo",
                Descricao = "325ml de café de caramelo com leite, sorvete, gelo e chantilly. Gelado, encorpado e irresistível, transforma a tarde mais quente em algo suportável.",
                QtdEstoque = 15,
                Preco = 18.00m,
                ImagemUrl = "/img/produtos/menu/bebidas/frape-cafe-caramelo.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 33,
                CategoriaId = 5,
                Nome = "Soda Italiana Limão Siciliano",
                Descricao = "325ml de soda italiana sabor limão siciliano. Cítrica, borbulhante e com aquele perfume mediterrâneo, sofisticada sem esforço, refrescante sem exagero.",
                QtdEstoque = 20,
                Preco = 10.00m,
                ImagemUrl = "/img/produtos/menu/bebidas/soda-limao-siciliano.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 34,
                CategoriaId = 5,
                Nome = "Soda Italiana Maçã Verde",
                Descricao = "325ml de soda italiana sabor maçã verde. Efervescente, refrescante e com aquela acidez elegante, a bebida certa para um momento de leveza no jardim da Vereda.",
                QtdEstoque = 20,
                Preco = 10.00m,
                ImagemUrl = "/img/produtos/menu/bebidas/soda-maca-verde.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 35,
                CategoriaId = 5,
                Nome = "Soda Italiana Melancia",
                Descricao = "325ml de soda italiana sabor melancia. Fresca, doce e com aquela cor vibrante de verão, a soda que chega e já parece um convite para relaxar.",
                QtdEstoque = 20,
                Preco = 10.00m,
                ImagemUrl = "/img/produtos/menu/bebidas/soda-melancia.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 36,
                CategoriaId = 5,
                Nome = "Suco de Goiaba",
                Descricao = "250ml de suco natural de goiaba feito na hora. Doce, aromático e com aquela densidade cremosa que abraça, o suco do quintal que nunca devia ter saído de moda.",
                QtdEstoque = 20,
                Preco = 9.95m,
                ImagemUrl = "/img/produtos/menu/bebidas/suco-goiaba.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 37,
                CategoriaId = 5,
                Nome = "Ursinho Pimpão",
                Descricao = "Latte de morango em camadas com leite vaporizado rosê e espuma de leite modelada em ursinho. Fofo, frutado e irresistível, para adoçar qualquer momento.",
                QtdEstoque = 15,
                Preco = 19.00m,
                ImagemUrl = "/img/produtos/menu/bebidas/ursinho-pimpao.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 38,
                CategoriaId = 5,
                Nome = "Vinho Fino Branco Seco",
                Descricao = "300ml de vinho fino branco seco, uva Chardonnay. Encorpado, com notas de frutas brancas e final longo, para quem aprecia um branco de alto nível.",
                QtdEstoque = 20,
                Preco = 42.50m,
                ImagemUrl = "/img/produtos/menu/bebidas/vinho-fino-branco-seco-taca.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 39,
                CategoriaId = 5,
                Nome = "Vinho Fino Rosé Demi-Sec",
                Descricao = "300ml de vinho fino rosé demi-sec, uvas Moscato e Cabernet Sauvignon. Floral, levemente adocicado e elegante, a escolha certa para um momento de celebração.",
                QtdEstoque = 20,
                Preco = 20.00m,
                ImagemUrl = "/img/produtos/menu/bebidas/vinho-fino-rose-demi-sec-taca.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 40,
                CategoriaId = 5,
                Nome = "Vinho de Mesa Tinto Suave",
                Descricao = "300ml de vinho de mesa tinto suave, uva Bordô. Leve, adocicado e muito acessível, ideal para quem quer experimentar um bom vinho sem abrir a garrafa inteira.",
                QtdEstoque = 20,
                Preco = 15.00m,
                ImagemUrl = "/img/produtos/menu/bebidas/vinho-mesa-tinto-suave-taca.png",
                Ativo = true
            },

            #endregion
        };

        builder.Entity<Produto>().HasData(produtos);
    }
}