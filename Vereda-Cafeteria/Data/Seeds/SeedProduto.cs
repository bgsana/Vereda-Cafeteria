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
                Nome = "Pão de Queijo",
                Descricao = "Pão de queijo regional assado na hora. Aquele clássico mineiro que abraça, quentinho, macio por dentro e levemente crocante por fora.",
                QtdEstoque = 20,
                Preco = 5.00m,
                ImagemUrl = "/img/produtos/pratos-salgados/pao-de-queijo.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 2,
                CategoriaId = 1,
                Nome = "Pão de Queijo Recheado",
                Descricao = "Pão de queijo regional assado na hora com recheio à escolha: requeijão, presunto e queijo, calabresa, doce de leite, Nutella ou goiabada.",
                QtdEstoque = 20,
                Preco = 7.95m,
                ImagemUrl = "/img/produtos/pratos-salgados/pao-de-queijo-recheado.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 3,
                CategoriaId = 1,
                Nome = "Palito de Parmesão",
                Descricao = "1 palito de parmesão artesanal assado na hora. Crocante por fora, fundido por dentro, aperitivo regional que some antes de chegar à mesa.",
                QtdEstoque = 20,
                Preco = 6.95m,
                ImagemUrl = "/img/produtos/pratos-salgados/palito-de-parmesao.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 4,
                CategoriaId = 1,
                Nome = "Pão com Ovo",
                Descricao = "Pão francês fresquinho com ovo frito no ponto certo. Simples e feito na hora, como o café da manhã de casa deveria ser.",
                QtdEstoque = 15,
                Preco = 6.95m,
                ImagemUrl = "/img/produtos/pratos-salgados/pao-com-ovo.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 5,
                CategoriaId = 1,
                Nome = "Empada de Barra Bonita",
                Descricao = "Empada artesanal fresquinha com recheio barra-bonitense. Sabores: frango c/ milho, frango c/ bacon, brócolis c/ requeijão, alho-poró ou palmito c/ parmesão.",
                QtdEstoque = 10,
                Preco = 15.00m,
                ImagemUrl = "/img/produtos/pratos-salgados/empada.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 6,
                CategoriaId = 1,
                Nome = "Torta Artesanal de Barra Bonita",
                Descricao = "Torta artesanal com massa caseira e recheio generoso. Sabores: frango, calabresa, mortadela, carne, costela ou pizza. Feita na hora, com sabor de quitanda.",
                QtdEstoque = 10,
                Preco = 11.95m,
                ImagemUrl = "/img/produtos/pratos-salgados/torta-artesanal.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 7,
                CategoriaId = 1,
                Nome = "Bolinho de Chuva Salgado da Vó Nice",
                Descricao = "12 bolinhos da receita original da Vó Nice, salgados e acompanhados de molho de queijo gorgonzola. Feitos na hora, com muito afeto e tradição.",
                QtdEstoque = 10,
                Preco = 15.95m,
                ImagemUrl = "/img/produtos/pratos-salgados/bolinho-chuva-salgado.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 8,
                CategoriaId = 1,
                Nome = "Queijo Quente",
                Descricao = "Pão francês com queijo derretido, saindo quentinho do forno. Clássico que nunca erra, perfeito para acompanhar qualquer café da Vereda.",
                QtdEstoque = 15,
                Preco = 9.95m,
                ImagemUrl = "/img/produtos/pratos-salgados/queijo-quente.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 9,
                CategoriaId = 1,
                Nome = "Misto Quente",
                Descricao = "Pão francês com presunto e queijo derretido na chapa. Um abraço de sabor em cada mordida, o clássico que todo mundo pede com saudade.",
                QtdEstoque = 15,
                Preco = 8.95m,
                ImagemUrl = "/img/produtos/pratos-salgados/misto-quente.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 10,
                CategoriaId = 1,
                Nome = "Pão na Chapa",
                Descricao = "Pão francês na chapa com manteiga. Aquela crocância dourada por fora e maciez por dentro que deixa qualquer café mais gostoso.",
                QtdEstoque = 15,
                Preco = 5.00m,
                ImagemUrl = "/img/produtos/pratos-salgados/pao-na-chapa.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 11,
                CategoriaId = 1,
                Nome = "Omelete",
                Descricao = "Omelete simples preparado na hora com ovos frescos. Leve, dourado e macio, o prato certo pra quem quer algo rápido e bem feito.",
                QtdEstoque = 10,
                Preco = 7.00m,
                ImagemUrl = "/img/produtos/pratos-salgados/omelete.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 12,
                CategoriaId = 1,
                Nome = "Omelete Presunto e Queijo",
                Descricao = "Omelete recheado com presunto e queijo, feito na hora. Cremoso por dentro e dourado por fora, aquele omelete que a gente pede de olhos fechados.",
                QtdEstoque = 10,
                Preco = 15.95m,
                ImagemUrl = "/img/produtos/pratos-salgados/omelete-presunto-queijo.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 13,
                CategoriaId = 1,
                Nome = "Ovos Mexidos",
                Descricao = "Ovos mexidos cremosos feitos na hora, com acréscimo de bacon e calabresa. Aquele café da manhã caprichado que começa o dia do jeito certo.",
                QtdEstoque = 10,
                Preco = 7.00m,
                ImagemUrl = "/img/produtos/pratos-salgados/ovos-mexidos.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 14,
                CategoriaId = 1,
                Nome = "Ovos Mexidos + Potinhos de Bacon e Calabresa",
                Descricao = "Ovos mexidos cremosos feitos na hora, servidos com potinhos de bacon e calabresa à parte. Café da manhã completo e caprichado, para começar bem o dia.",
                QtdEstoque = 10,
                Preco = 15.95m,
                ImagemUrl = "/img/produtos/pratos-salgados/ovos-mexidos-potinhos.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 15,
                CategoriaId = 1,
                Nome = "Minicoxinha",
                Descricao = "8 minicoxinhas artesanais feitas na hora acompanhadas de molho de alho e ervas. Crocantes por fora, recheadas e quentinhas, impossível comer só uma.",
                QtdEstoque = 10,
                Preco = 16.00m,
                ImagemUrl = "/img/produtos/pratos-salgados/minicoxinha.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 16,
                CategoriaId = 1,
                Nome = "Miniquibe",
                Descricao = "8 miniquibes artesanais com molho de páprica defumada. Crocantes, saborosos e feitos na hora, um petisco que carrega identidade em cada mordida.",
                QtdEstoque = 10,
                Preco = 16.00m,
                ImagemUrl = "/img/produtos/pratos-salgados/miniquibe.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 17,
                CategoriaId = 1,
                Nome = "Dadinho de Tapioca",
                Descricao = "8 dadinhos de tapioca dourados e crocantes, acompanhados de geleia de pimenta artesanal. Petisco regional com personalidade, vicia desde o primeiro.",
                QtdEstoque = 10,
                Preco = 19.95m,
                ImagemUrl = "/img/produtos/pratos-salgados/dadinho-tapioca.png",
                Ativo = true
            },

            #endregion

            #region Pratos Doces (CategoriaId = 2)

            new Produto
            {
                ProdutoId = 18,
                CategoriaId = 2,
                Nome = "Brownie com Calda",
                Descricao = "Brownie artesanal de Barra Bonita com calda de chocolate e chantilly. Casquinha crocante, interior cremoso e denso, puro conforto numa porção só.",
                QtdEstoque = 10,
                Preco = 16.95m,
                ImagemUrl = "/img/produtos/pratos-doces/brownie-calda.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 19,
                CategoriaId = 2,
                Nome = "Brownie com Sorvete",
                Descricao = "Brownie artesanal de Barra Bonita com sorvete artesanal da cidade. O contraste quente e frio que só a Vereda faz do jeito que você vai querer de novo.",
                QtdEstoque = 10,
                Preco = 15.95m,
                ImagemUrl = "/img/produtos/pratos-doces/brownie-sorvete.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 20,
                CategoriaId = 2,
                Nome = "Petit Gateau com Sorvete",
                Descricao = "Petit gateau com coração derretido de chocolate, acompanhado de sorvete creme artesanal de Barra Bonita. Feito na hora, espera com gostinho de recompensa.",
                QtdEstoque = 10,
                Preco = 16.00m,
                ImagemUrl = "/img/produtos/pratos-doces/petit-gateau.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 21,
                CategoriaId = 2,
                Nome = "Empada Doce Artesanal",
                Descricao = "Empada doce artesanal em três sabores: brigadeiro gourmet com granulé, brigadeiro de café com chocolate meio amargo, ou banana caramelizada com creme e canela.",
                QtdEstoque = 10,
                Preco = 15.00m,
                ImagemUrl = "/img/produtos/pratos-doces/empada-doce.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 22,
                CategoriaId = 2,
                Nome = "Bolinho de Chuva da Vó Nice",
                Descricao = "12 bolinhos da receita original da Vó Nice com chocolate cremoso caseiro. Memória de infância servida quentinha, receita de quem alimentou gerações.",
                QtdEstoque = 10,
                Preco = 16.00m,
                ImagemUrl = "/img/produtos/pratos-doces/bolinho-chuva-doce.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 23,
                CategoriaId = 2,
                Nome = "Torta Artesanal de Barra Bonita",
                Descricao = "Torta doce artesanal com massa caseira e recheio generoso, feita na hora com sabor de quitanda. Sabores: frango, calabresa, mortadela, carne, costela ou pizza.",
                QtdEstoque = 10,
                Preco = 11.95m,
                ImagemUrl = "/img/produtos/pratos-doces/torta-artesanal-doce.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 24,
                CategoriaId = 2,
                Nome = "Bolo de Caneca Chocolate",
                Descricao = "Bolo de caneca caseiro com cobertura de chocolate feito na hora. Fofo, úmido e quentinho, aquele bolo que parece ter saído direto da cozinha da vovó.",
                QtdEstoque = 10,
                Preco = 15.00m,
                ImagemUrl = "/img/produtos/pratos-doces/bolo-caneca-chocolate.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 25,
                CategoriaId = 2,
                Nome = "Bolo de Caneca Limão",
                Descricao = "Bolo de caneca caseiro com cobertura de mousse de limão feito na hora. Leve, fresquinho e com aquela acidez certinha que desperta o paladar.",
                QtdEstoque = 10,
                Preco = 15.00m,
                ImagemUrl = "/img/produtos/pratos-doces/bolo-caneca-limao.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 26,
                CategoriaId = 2,
                Nome = "Bolo de Caneca Leite Ninho",
                Descricao = "Bolo de caneca caseiro com cobertura de leite condensado feito na hora. Cremoso, adocicado e confortante, para quem quer um docinho com memória afetiva.",
                QtdEstoque = 10,
                Preco = 15.00m,
                ImagemUrl = "/img/produtos/pratos-doces/bolo-caneca-leite-ninho.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 27,
                CategoriaId = 2,
                Nome = "Bolo de Caneca Côco",
                Descricao = "Bolo de caneca caseiro com cobertura de leite condensado e côco ralado feito na hora. Um bolo que cheira a festa junina e tem gostinho de interior brasileiro.",
                QtdEstoque = 10,
                Preco = 15.00m,
                ImagemUrl = "/img/produtos/pratos-doces/bolo-caneca-coco.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 28,
                CategoriaId = 2,
                Nome = "Bolo de Caneca Fubá",
                Descricao = "Bolo de caneca caseiro de fubá com cobertura de goiabada feito na hora. Aquele sabor caipira que reconforta a alma, combinação clássica do Brasil profundo.",
                QtdEstoque = 10,
                Preco = 15.00m,
                ImagemUrl = "/img/produtos/pratos-doces/bolo-caneca-fuba.png",
                Ativo = true
            },

            #endregion

            #region Cafés (CategoriaId = 3)

            new Produto
            {
                ProdutoId = 29,
                CategoriaId = 3,
                Nome = "Espresso",
                Descricao = "120ml de café regional com água com gás. Encorpado, aromático e com crema dourada, o ponto de partida para quem leva café a sério.",
                QtdEstoque = 50,
                Preco = 6.00m,
                ImagemUrl = "/img/produtos/cafes/espresso.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 30,
                CategoriaId = 3,
                Nome = "Espresso Duplo",
                Descricao = "180ml de café regional com água com gás. Para quando um espresso não é suficiente, intenso, generoso e sem concessões.",
                QtdEstoque = 50,
                Preco = 8.00m,
                ImagemUrl = "/img/produtos/cafes/espresso-duplo.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 31,
                CategoriaId = 3,
                Nome = "Cappuccino Pequeno",
                Descricao = "100ml de café regional com leite e cacau em pó. Cremoso, aveludado e com aquele equilíbrio perfeito entre café e leite que transforma a pausa no dia.",
                QtdEstoque = 50,
                Preco = 9.00m,
                ImagemUrl = "/img/produtos/cafes/cappuccino-pequeno.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 32,
                CategoriaId = 3,
                Nome = "Cappuccino Grande",
                Descricao = "250ml de café regional com leite e cacau em pó. A versão generosa do cappuccino, para quem precisa de mais tempo, mais conforto e mais café.",
                QtdEstoque = 50,
                Preco = 12.00m,
                ImagemUrl = "/img/produtos/cafes/cappuccino-grande.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 33,
                CategoriaId = 3,
                Nome = "Mocaccino Pequeno",
                Descricao = "100ml de café regional com leite e calda de leite condensado, doce de leite ou chocolate. Doce, intenso e irresistível, para quem quer café com personalidade.",
                QtdEstoque = 50,
                Preco = 12.00m,
                ImagemUrl = "/img/produtos/cafes/mocaccino-pequeno.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 34,
                CategoriaId = 3,
                Nome = "Mocaccino Grande",
                Descricao = "250ml de café regional com leite e calda de leite condensado, doce de leite ou chocolate. A versão grande do mocaccino, para pausas que merecem um pouco mais.",
                QtdEstoque = 50,
                Preco = 15.00m,
                ImagemUrl = "/img/produtos/cafes/mocaccino-grande.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 35,
                CategoriaId = 3,
                Nome = "Cafézinho",
                Descricao = "80ml de café regional coado, simples, direto ao ponto e muito saboroso. O cafezinho do interior que a gente toma de pé, no balcão, com sorriso no rosto.",
                QtdEstoque = 50,
                Preco = 5.00m,
                ImagemUrl = "/img/produtos/cafes/cafezinho.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 36,
                CategoriaId = 3,
                Nome = "Americano",
                Descricao = "180ml de café regional coado. Suave, limpo e com toda a essência do café Vereda. Para saborear devagar, sem pressa, em boa companhia.",
                QtdEstoque = 50,
                Preco = 7.00m,
                ImagemUrl = "/img/produtos/cafes/americano.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 37,
                CategoriaId = 3,
                Nome = "Café com Leite",
                Descricao = "180ml de café regional com leite, 90ml de cada. O par clássico de sempre, feito com o café da Vereda e leite fresquinho. Conforto puro na xícara.",
                QtdEstoque = 50,
                Preco = 9.00m,
                ImagemUrl = "/img/produtos/cafes/cafe-com-leite.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 38,
                CategoriaId = 3,
                Nome = "Macchiato",
                Descricao = "275ml de café regional com apenas 5ml de leite, intenso com um toque suave. Para quem ama o café forte mas aprecia aquele fio cremoso por cima.",
                QtdEstoque = 50,
                Preco = 9.00m,
                ImagemUrl = "/img/produtos/cafes/macchiato.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 39,
                CategoriaId = 3,
                Nome = "Latte",
                Descricao = "275ml de leite com 50ml de café regional. Aveludado, suave e encorpado, para quem prefere o café como fundo e o leite como protagonista.",
                QtdEstoque = 50,
                Preco = 10.00m,
                ImagemUrl = "/img/produtos/cafes/latte.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 40,
                CategoriaId = 3,
                Nome = "Tradição na Mesa",
                Descricao = "Café coado na mesa com coador de pano, a tradição do afeto em cada gole. Leve o coador para casa e continue a história com o sabor da Vereda.",
                QtdEstoque = 20,
                Preco = 12.00m,
                ImagemUrl = "/img/produtos/cafes/tradicao-na-mesa.png",
                Ativo = true
            },

            #endregion

            #region Inspirados (CategoriaId = 4)

            new Produto
            {
                ProdutoId = 41,
                CategoriaId = 4,
                Nome = "Major Pompeu",
                Descricao = "Chocolate amargo caseiro em 250ml ou 100ml. Homenagem ao Major Pompeu, personagem do hino de Barra Bonita, intenso e marcante como a história da cidade.",
                QtdEstoque = 20,
                Preco = 16.00m,
                ImagemUrl = "/img/produtos/inspirados/major-pompeu.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 42,
                CategoriaId = 4,
                Nome = "Chocolate Simpatia",
                Descricao = "200ml de chocolate cremoso com chantilly e granulado simpatia. Doce, alegre e acolhedor, como o apelido de Barra Bonita que todo mundo conhece.",
                QtdEstoque = 20,
                Preco = 15.00m,
                ImagemUrl = "/img/produtos/inspirados/chocolate-simpatia.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 43,
                CategoriaId = 4,
                Nome = "Caseiro da Vó Nice",
                Descricao = "Chocolate caseiro em 250ml ou 100ml com gostinho de infância. A receita que a Vó Nice carrega desde 1977 em Barra Bonita, simples, quente e cheio de amor.",
                QtdEstoque = 20,
                Preco = 11.00m,
                ImagemUrl = "/img/produtos/inspirados/caseiro-vo-nice.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 44,
                CategoriaId = 4,
                Nome = "Beijo de Açúcar",
                Descricao = "200ml de chocolate cremoso com borda de Nutella e raspas de chocolate. Inspirado no hino da cidade, tão doce quanto os canaviais que emolduram Barra Bonita.",
                QtdEstoque = 20,
                Preco = 17.00m,
                ImagemUrl = "/img/produtos/inspirados/beijo-de-acucar.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 45,
                CategoriaId = 4,
                Nome = "Café Vaporzinho",
                Descricao = "140ml de café regional com mel Europa. Inspirado no vaporzinho que o tempo apagou do hino da cidade, suave, adocicado e cheio de memória barra-bonitense.",
                QtdEstoque = 20,
                Preco = 9.00m,
                ImagemUrl = "/img/produtos/inspirados/cafe-vaporzinho.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 46,
                CategoriaId = 4,
                Nome = "Café Cremoso Salles Leme",
                Descricao = "180ml de café cremoso com leite integral e açúcar mascavo. Homenagem a Salles Leme, nome que sonhou com a grandeza de Barra Bonita, intenso e encorpado.",
                QtdEstoque = 20,
                Preco = 12.00m,
                ImagemUrl = "/img/produtos/inspirados/cafe-cremoso-salles-leme.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 47,
                CategoriaId = 4,
                Nome = "Latte Cremoso 1º de Março",
                Descricao = "180ml de café regional com leite integral, caramelo e baunilha. Data histórica em forma de bebida, suave, doce e inesquecível como o aniversário da cidade.",
                QtdEstoque = 20,
                Preco = 13.95m,
                ImagemUrl = "/img/produtos/inspirados/latte-cremoso-1-marco.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 48,
                CategoriaId = 4,
                Nome = "Latte Cremoso Vereda",
                Descricao = "180ml de café regional com leite integral e Nutella. A bebida assinatura da casa, suave, cremosa e com aquele toque de identidade que só a Vereda tem.",
                QtdEstoque = 20,
                Preco = 16.95m,
                ImagemUrl = "/img/produtos/inspirados/latte-cremoso-vereda.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 49,
                CategoriaId = 4,
                Nome = "Affogato Tietê",
                Descricao = "200ml de café regional com sorvete de chocolate de Barra Bonita e calda de chocolate. Inspirado no rio que banha a cidade, intenso, frio e profundo.",
                QtdEstoque = 15,
                Preco = 12.95m,
                ImagemUrl = "/img/produtos/inspirados/affogato-tiete.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 50,
                CategoriaId = 4,
                Nome = "Affogato Campos Salles",
                Descricao = "200ml de café regional com sorvete de creme de Barra Bonita e calda de caramelo. Elegante, clássico e com personalidade, uma homenagem que se derrete na boca.",
                QtdEstoque = 15,
                Preco = 12.95m,
                ImagemUrl = "/img/produtos/inspirados/affogato-campos-salles.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 51,
                CategoriaId = 4,
                Nome = "Affogato Saffi",
                Descricao = "200ml de café regional com sorvete de nata de Barra Bonita e calda mista. Suave, cremoso e com camadas de sabor, café, sorvete e história num copo só.",
                QtdEstoque = 15,
                Preco = 12.95m,
                ImagemUrl = "/img/produtos/inspirados/affogato-saffi.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 52,
                CategoriaId = 4,
                Nome = "Chocafé Barra Bonita",
                Descricao = "140ml de café regional com trufa de brigadeiro de Barra Bonita. Café e chocolate num encontro que só podia nascer aqui, encorpado, doce e completamente local.",
                QtdEstoque = 20,
                Preco = 8.00m,
                ImagemUrl = "/img/produtos/inspirados/chocafe-barra-bonita.png",
                Ativo = true
            },

            #endregion

            #region Bebidas (CategoriaId = 5)

            new Produto
            {
                ProdutoId = 53,
                CategoriaId = 4,
                Nome = "Cafe Coado com Laranja",
                Descricao = "140ml de café regional gelado com rodelas de laranja. Refrescante, cítrico e surpreendente, a combinação que parece estranha mas conquista na primeira gota.",
                QtdEstoque = 20,
                Preco = 8.00m,
                ImagemUrl = "/img/produtos/inspirados/cafe-coado-laranja.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 54,
                CategoriaId = 4,
                Nome = "Café Coado com Limão",
                Descricao = "140ml de café regional gelado com rodelas de limão. Azedinho e refrescante, para quem gosta de café com personalidade e não tem medo de experimentar.",
                QtdEstoque = 20,
                Preco = 8.00m,
                ImagemUrl = "/img/produtos/inspirados/cafe-coado-limao.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 55,
                CategoriaId = 4,
                Nome = "Cremosinho da Vereda",
                Descricao = "140ml de café cremoso com leite e leite condensado. Doce, aveludado e cheio de sabor, o cremosinho que virou pedido certeiro de quem conhece a Vereda.",
                QtdEstoque = 20,
                Preco = 12.00m,
                ImagemUrl = "/img/produtos/inspirados/cremosinho-vereda.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 56,
                CategoriaId = 4,
                Nome = "Espresso Maçã",
                Descricao = "140ml de café regional com suco de soja de maçã gelado. Leve, frutado e cheio de personalidade, para quem quer o café de um jeito diferente e delicioso.",
                QtdEstoque = 15,
                Preco = 10.00m,
                ImagemUrl = "/img/produtos/inspirados/espresso-maca.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 57,
                CategoriaId = 4,
                Nome = "Espresso Laranja",
                Descricao = "140ml de café regional com suco natural de laranja gelado. Ácido, intenso e surpreendente, uma combinação que virou tendência e faz sentido na primeira gota.",
                QtdEstoque = 15,
                Preco = 10.00m,
                ImagemUrl = "/img/produtos/inspirados/espresso-laranja.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 58,
                CategoriaId = 4,
                Nome = "Espresso Limão",
                Descricao = "140ml de café regional com suco natural de limão gelado. Cítrico, intenso e inesperado, para os aventureiros que não têm medo de um bom contraste.",
                QtdEstoque = 15,
                Preco = 10.00m,
                ImagemUrl = "/img/produtos/inspirados/espresso-limao.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 59,
                CategoriaId = 4,
                Nome = "Espresso Sprite®",
                Descricao = "140ml de café regional com refrigerante Sprite gelado. Efervescente, refrescante e com atitude, o espresso que borbulha e desperta o paladar com estilo.",
                QtdEstoque = 15,
                Preco = 10.00m,
                ImagemUrl = "/img/produtos/inspirados/espresso-sprite.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 60,
                CategoriaId = 4,
                Nome = "Chafé Verde",
                Descricao = "140ml de café regional com chá verde gelado. Leve, aromático e diferente, quando o café encontra o chá e os dois saem melhores dessa história.",
                QtdEstoque = 15,
                Preco = 9.00m,
                ImagemUrl = "/img/produtos/inspirados/chafe-verde.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 61,
                CategoriaId = 4,
                Nome = "Geladinho Café Baunilha",
                Descricao = "250ml de café de baunilha com leite e extrato de baunilha gelado. Suave, perfumado e cremoso, aquele geladinho que mistura sofisticação com simplicidade.",
                QtdEstoque = 15,
                Preco = 14.00m,
                ImagemUrl = "/img/produtos/inspirados/geladinho-cafe-baunilha.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 62,
                CategoriaId = 4,
                Nome = "Geladinho Café Chocolate",
                Descricao = "250ml de café de chocolate com leite e doce de leite gelado. Cremoso, intenso e com aquela doçura no fundo, para os amantes de café com chocolate.",
                QtdEstoque = 15,
                Preco = 14.00m,
                ImagemUrl = "/img/produtos/inspirados/geladinho-cafe-chocolate.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 63,
                CategoriaId = 4,
                Nome = "Geladinho Café Morango",
                Descricao = "250ml de café regional com leite e morango gelado. Frutado, refrescante e com aquela cor bonita que chega na mesa antes do sabor, e o sabor confirma tudo.",
                QtdEstoque = 15,
                Preco = 14.00m,
                ImagemUrl = "/img/produtos/inspirados/geladinho-cafe-morango.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 64,
                CategoriaId = 5,
                Nome = "Milk Shake Chocolate",
                Descricao = "250ml de sorvete artesanal de chocolate de Barra Bonita com leite e calda. Cremoso e gelado, o milk shake que lembra sorvete de domingo em família.",
                QtdEstoque = 15,
                Preco = 15.00m,
                ImagemUrl = "/img/produtos/bebidas/milkshake-chocolate.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 65,
                CategoriaId = 5,
                Nome = "Milk Shake Nutella®",
                Descricao = "250ml de sorvete artesanal de chocolate com leite e Nutella. Intenso, cremoso e irresistível, o milk shake que todo mundo pede apontando para o do vizinho.",
                QtdEstoque = 15,
                Preco = 15.00m,
                ImagemUrl = "/img/produtos/bebidas/milkshake-nutella.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 66,
                CategoriaId = 5,
                Nome = "Milk Shake Kinder Bueno®",
                Descricao = "250ml de sorvete artesanal de nata com leite e Nutella. Suave, elegante e com aquele toque especial que faz parecer uma sobremesa completa num copo só.",
                QtdEstoque = 15,
                Preco = 15.00m,
                ImagemUrl = "/img/produtos/bebidas/milkshake-kinder-bueno.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 67,
                CategoriaId = 5,
                Nome = "Milk Shake Doce de Leite",
                Descricao = "250ml de sorvete artesanal de creme com leite e doce de leite. Caramelado, denso e com gostinho de fazenda, pura identidade brasileira num copo gelado.",
                QtdEstoque = 15,
                Preco = 15.00m,
                ImagemUrl = "/img/produtos/bebidas/milkshake-doce-de-leite.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 68,
                CategoriaId = 5,
                Nome = "Milk Shake Leite Condensado",
                Descricao = "250ml de sorvete artesanal de nata com leite e leite condensado. Cremoso, adocicado e generoso, o milk shake que parece grande demais mas acaba rápido demais.",
                QtdEstoque = 15,
                Preco = 15.00m,
                ImagemUrl = "/img/produtos/bebidas/milkshake-leite-condensado.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 69,
                CategoriaId = 5,
                Nome = "Milk Shake Nesquik®",
                Descricao = "250ml de sorvete artesanal de creme com leite e Nesquik. Achocolatado na versão milk shake, aquela combinação nostálgica que faz qualquer adulto virar criança.",
                QtdEstoque = 15,
                Preco = 15.00m,
                ImagemUrl = "/img/produtos/bebidas/milkshake-nesquik.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 70,
                CategoriaId = 5,
                Nome = "Frapê Café Caramelo",
                Descricao = "325ml de café de caramelo com leite, sorvete, gelo e chantilly. Gelado, encorpado e irresistível, transforma a tarde mais quente em algo suportável.",
                QtdEstoque = 15,
                Preco = 18.00m,
                ImagemUrl = "/img/produtos/bebidas/frape-cafe-caramelo.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 71,
                CategoriaId = 5,
                Nome = "Frapê Café Nutbaunilha",
                Descricao = "325ml de café de baunilha com Nutella, leite, sorvete, gelo e chantilly. Cremoso, complexo e viciante, para quem quer mais do que um simples frapê.",
                QtdEstoque = 15,
                Preco = 18.00m,
                ImagemUrl = "/img/produtos/bebidas/frape-cafe-nutbaunilha.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 72,
                CategoriaId = 5,
                Nome = "Frapê Cappuccino",
                Descricao = "325ml de cappuccino Vereda com sorvete, gelo e chantilly. O cappuccino da casa no formato gelado, cremoso, intenso e com cobertura branca que chega sorrindo.",
                QtdEstoque = 15,
                Preco = 18.00m,
                ImagemUrl = "/img/produtos/bebidas/frape-cappuccino.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 73,
                CategoriaId = 5,
                Nome = "Frapê Cappuccino Nutella®",
                Descricao = "325ml de cappuccino Vereda com Nutella, sorvete, gelo e chantilly. Intenso, doce e com camadas de sabor, o frapê que faz a tarde parecer uma celebração.",
                QtdEstoque = 15,
                Preco = 18.00m,
                ImagemUrl = "/img/produtos/bebidas/frape-cappuccino-nutella.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 74,
                CategoriaId = 5,
                Nome = "Frapê Chocolate",
                Descricao = "325ml de leite com Nescau, sorvete, gelo e chantilly. Chocolatudo, gelado e com aquele chantilly que desaparece antes de você conseguir fotografar.",
                QtdEstoque = 15,
                Preco = 18.00m,
                ImagemUrl = "/img/produtos/bebidas/frape-chocolate.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 75,
                CategoriaId = 5,
                Nome = "Frapê Morango",
                Descricao = "325ml de leite com morango, sorvete, gelo e chantilly. Frutado, cor de rosa e cheio de vida, o frapê que chega na mesa e atrai olhares antes de ser provado.",
                QtdEstoque = 15,
                Preco = 18.00m,
                ImagemUrl = "/img/produtos/bebidas/frape-morango.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 76,
                CategoriaId = 5,
                Nome = "Chá Verde",
                Descricao = "275ml de chá verde quente ou gelado. Suave, aromático e levemente herbáceo, a pausa tranquila para quem quer descansar sem abrir mão do sabor.",
                QtdEstoque = 20,
                Preco = 5.00m,
                ImagemUrl = "/img/produtos/bebidas/cha-verde.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 77,
                CategoriaId = 5,
                Nome = "Chá Capim Cidreira",
                Descricao = "275ml de chá de capim cidreira quente. Levemente cítrico, calmante e com aquele aroma de roça, o chá que cuida enquanto acolhe, como sempre foi.",
                QtdEstoque = 20,
                Preco = 5.00m,
                ImagemUrl = "/img/produtos/bebidas/cha-capim-cidreira.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 78,
                CategoriaId = 5,
                Nome = "Chá Erva Doce",
                Descricao = "275ml de chá de erva doce quente. Adocicado, anisado e muito reconfortante, o chá da vovó que resolvia tudo com uma xícara e um abraço.",
                QtdEstoque = 20,
                Preco = 5.00m,
                ImagemUrl = "/img/produtos/bebidas/cha-erva-doce.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 79,
                CategoriaId = 5,
                Nome = "Chá Hortelã",
                Descricao = "275ml de chá de hortelã quente. Fresco, mentolado e com aquela sensação de limpar por dentro, o chá que refresca mesmo quando está quentinho.",
                QtdEstoque = 20,
                Preco = 5.00m,
                ImagemUrl = "/img/produtos/bebidas/cha-hortela.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 80,
                CategoriaId = 5,
                Nome = "Chá Camomila",
                Descricao = "275ml de chá de camomila quente. Suave, floral e calmante como um abraço de dentro pra fora, o chá certo para encerrar um dia cheio com gentileza.",
                QtdEstoque = 20,
                Preco = 5.00m,
                ImagemUrl = "/img/produtos/bebidas/cha-camomila.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 81,
                CategoriaId = 5,
                Nome = "Chá Amora e Hibisco",
                Descricao = "275ml de chá de amora com hibisco quente. Vermelho, frutado e com aquele sabor floral marcante, um chá que é também uma experiência visual linda na xícara.",
                QtdEstoque = 20,
                Preco = 5.00m,
                ImagemUrl = "/img/produtos/bebidas/cha-amora-hibisco.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 82,
                CategoriaId = 5,
                Nome = "Chá Maçã e Canela",
                Descricao = "275ml de chá de maçã com canela quente. Doce, quentinho e com aquele perfume de inverno, faz parecer que está nevando mesmo em pleno interior paulista.",
                QtdEstoque = 20,
                Preco = 5.00m,
                ImagemUrl = "/img/produtos/bebidas/cha-maca-canela.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 83,
                CategoriaId = 5,
                Nome = "Chá Camomila e Maracujá",
                Descricao = "275ml de chá de camomila com maracujá quente. Calmante e tropical ao mesmo tempo, a combinação inusitada que acalma a mente sem abrir mão do sabor.",
                QtdEstoque = 20,
                Preco = 5.00m,
                ImagemUrl = "/img/produtos/bebidas/cha-camomila-maracuja.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 84,
                CategoriaId = 5,
                Nome = "Chá Mate e Guaraná",
                Descricao = "275ml de chá mate com guaraná quente. Energizante, levemente amargo e com aquele sabor do Brasil profundo, para a tarde que precisa de um empurrãozinho.",
                QtdEstoque = 20,
                Preco = 5.00m,
                ImagemUrl = "/img/produtos/bebidas/cha-mate-guarana.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 85,
                CategoriaId = 5,
                Nome = "Chá Preto, Laranja e Mel",
                Descricao = "275ml de chá preto com laranja e mel quente. Encorpado, cítrico e adocicado, a trilogia perfeita para um momento de conforto com sabor e aroma inconfundíveis.",
                QtdEstoque = 20,
                Preco = 5.00m,
                ImagemUrl = "/img/produtos/bebidas/cha-preto-laranja-mel.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 86,
                CategoriaId = 5,
                Nome = "Ice Tea Pêssego",
                Descricao = "275ml de ice tea de pêssego gelado. Leve, frutado e refrescante, o clássico das bebidas geladas que agrada a todos e combina com qualquer momento.",
                QtdEstoque = 20,
                Preco = 5.00m,
                ImagemUrl = "/img/produtos/bebidas/ice-tea-pessego.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 87,
                CategoriaId = 5,
                Nome = "Chá Preto e Frutas Vermelhas",
                Descricao = "275ml de chá preto com frutas vermelhas gelado. Encorpado, frutado e com uma acidez que anima, o chá gelado para quem quer sabor e leveza num copo só.",
                QtdEstoque = 20,
                Preco = 5.00m,
                ImagemUrl = "/img/produtos/bebidas/cha-preto-frutas-vermelhas.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 88,
                CategoriaId = 5,
                Nome = "Chá Abacaxi e Hortelã",
                Descricao = "275ml de chá de abacaxi com hortelã gelado. Tropical, fresco e muito refrescante, a combinação que parece uma caipirinha sem álcool no jardim da Vereda.",
                QtdEstoque = 20,
                Preco = 5.00m,
                ImagemUrl = "/img/produtos/bebidas/cha-abacaxi-hortela.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 89,
                CategoriaId = 5,
                Nome = "Chá Mate e Groselha Negra",
                Descricao = "275ml de chá mate com groselha negra gelado. Intenso, levemente adocicado e com aquela cor escura e elegante que impressiona antes mesmo do primeiro gole.",
                QtdEstoque = 20,
                Preco = 5.00m,
                ImagemUrl = "/img/produtos/bebidas/cha-mate-groselha.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 90,
                CategoriaId = 5,
                Nome = "Chá Verde, Gengibre e Limão",
                Descricao = "275ml de chá verde com gengibre e limão gelado. Fresco, picante e cítrico, a tríade do bem-estar servida gelada para quem sabe o que quer.",
                QtdEstoque = 20,
                Preco = 5.00m,
                ImagemUrl = "/img/produtos/bebidas/cha-verde-gengibre-limao.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 91,
                CategoriaId = 5,
                Nome = "Chá Amora e Framboesa",
                Descricao = "275ml de chá de amora com framboesa gelado. Vermelho, levemente ácido e com aquele sabor de floresta, uma bebida que parece um mimo para o paladar.",
                QtdEstoque = 20,
                Preco = 5.00m,
                ImagemUrl = "/img/produtos/bebidas/cha-amora-framboesa.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 92,
                CategoriaId = 5,
                Nome = "Chá Morango e Maracujá",
                Descricao = "275ml de chá de morango com maracujá gelado. Frutado, tropical e com aquele equilíbrio entre o doce e o ácido que deixa sempre querendo mais.",
                QtdEstoque = 20,
                Preco = 5.00m,
                ImagemUrl = "/img/produtos/bebidas/cha-morango-maracuja.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 93,
                CategoriaId = 5,
                Nome = "Chá Laranja Cor de Rosa",
                Descricao = "275ml de chá de laranja cor de rosa gelado. Cítrico, floral e com a cor mais bonita da prateleira, um chá que alegra a mesa antes mesmo de ser bebido.",
                QtdEstoque = 20,
                Preco = 5.00m,
                ImagemUrl = "/img/produtos/bebidas/cha-laranja-cor-de-rosa.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 94,
                CategoriaId = 5,
                Nome = "Suco de Laranja",
                Descricao = "250ml de suco natural de laranja feito na hora. Fresquinho, cítrico e sem enganação, o suco que lembra quintal de vó com laranjeira no fundo.",
                QtdEstoque = 20,
                Preco = 9.95m,
                ImagemUrl = "/img/produtos/bebidas/suco-laranja.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 95,
                CategoriaId = 5,
                Nome = "Suco de Limão",
                Descricao = "250ml de suco natural de limão feito na hora. Azedinho na medida certa, gelado e refrescante, aquele limão espremido que fica na memória.",
                QtdEstoque = 20,
                Preco = 9.95m,
                ImagemUrl = "/img/produtos/bebidas/suco-limao.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 96,
                CategoriaId = 5,
                Nome = "Suco de Maracujá",
                Descricao = "250ml de suco natural de maracujá feito na hora. Tropical, azedinho e com aquele aroma inconfundível, o suco que acalma e refresca ao mesmo tempo.",
                QtdEstoque = 20,
                Preco = 9.95m,
                ImagemUrl = "/img/produtos/bebidas/suco-maracuja.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 97,
                CategoriaId = 5,
                Nome = "Suco de Morango",
                Descricao = "250ml de suco natural de morango feito na hora. Doce, vermelho e cheio de frescor, o suco que chega bonito e sai gostoso, simples assim.",
                QtdEstoque = 20,
                Preco = 9.95m,
                ImagemUrl = "/img/produtos/bebidas/suco-morango.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 98,
                CategoriaId = 5,
                Nome = "Suco de Acerola",
                Descricao = "250ml de suco natural de acerola feito na hora. Ácido, vitaminado e com aquela cor vibrante, o suco que cuida enquanto refresca, de dentro pra fora.",
                QtdEstoque = 20,
                Preco = 9.95m,
                ImagemUrl = "/img/produtos/bebidas/suco-acerola.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 99,
                CategoriaId = 5,
                Nome = "Suco de Caju",
                Descricao = "250ml de suco natural de caju feito na hora. Adstringente, brasileiro e com aquele gostinho que só quem cresceu no interior conhece de verdade.",
                QtdEstoque = 20,
                Preco = 9.95m,
                ImagemUrl = "/img/produtos/bebidas/suco-caju.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 100,
                CategoriaId = 5,
                Nome = "Suco de Goiaba",
                Descricao = "250ml de suco natural de goiaba feito na hora. Doce, aromático e com aquela densidade cremosa que abraça, o suco do quintal que nunca devia ter saído de moda.",
                QtdEstoque = 20,
                Preco = 9.95m,
                ImagemUrl = "/img/produtos/bebidas/suco-goiaba.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 101,
                CategoriaId = 5,
                Nome = "Suco de Graviola",
                Descricao = "250ml de suco natural de graviola feito na hora. Suave, exótico e levemente adocicado, a fruta brasileira que surpreende quem ainda não conhece.",
                QtdEstoque = 20,
                Preco = 9.95m,
                ImagemUrl = "/img/produtos/bebidas/suco-graviola.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 102,
                CategoriaId = 5,
                Nome = "Suco de Uva Integral",
                Descricao = "250ml de suco natural de uva integral feito na hora. Encorpado, escuro e com sabor que lembra vindima, um suco que se bebe devagar e com respeito.",
                QtdEstoque = 20,
                Preco = 9.95m,
                ImagemUrl = "/img/produtos/bebidas/suco-uva.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 103,
                CategoriaId = 5,
                Nome = "Soda Italiana Maçã Verde",
                Descricao = "325ml de soda italiana sabor maçã verde. Efervescente, refrescante e com aquela acidez elegante, a bebida certa para um momento de leveza no jardim da Vereda.",
                QtdEstoque = 20,
                Preco = 10.00m,
                ImagemUrl = "/img/produtos/bebidas/soda-maca-verde.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 104,
                CategoriaId = 5,
                Nome = "Soda Italiana Limão Siciliano",
                Descricao = "325ml de soda italiana sabor limão siciliano. Cítrica, borbulhante e com aquele perfume mediterrâneo, sofisticada sem esforço, refrescante sem exagero.",
                QtdEstoque = 20,
                Preco = 10.00m,
                ImagemUrl = "/img/produtos/bebidas/soda-limao-siciliano.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 105,
                CategoriaId = 5,
                Nome = "Soda Italiana Tangerina",
                Descricao = "325ml de soda italiana sabor tangerina. Doce, cítrica e com um perfume de fruta madura, aquela bebida que faz a tarde de jardim ficar ainda mais bonita.",
                QtdEstoque = 20,
                Preco = 10.00m,
                ImagemUrl = "/img/produtos/bebidas/soda-tangerina.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 106,
                CategoriaId = 5,
                Nome = "Soda Italiana Cranberry",
                Descricao = "325ml de soda italiana sabor cranberry. Vermelha, levemente ácida e muito elegante, para quem quer uma bebida diferente que combina com qualquer conversa.",
                QtdEstoque = 20,
                Preco = 10.00m,
                ImagemUrl = "/img/produtos/bebidas/soda-cranberry.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 107,
                CategoriaId = 5,
                Nome = "Soda Italiana Pink Limonade",
                Descricao = "325ml de soda italiana sabor pink limonade. Cor de rosa, borbulhante e com um sorriso embutido, impossível não se animar quando ela chega na mesa.",
                QtdEstoque = 20,
                Preco = 10.00m,
                ImagemUrl = "/img/produtos/bebidas/soda-pink-limonade.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 108,
                CategoriaId = 5,
                Nome = "Soda Italiana Melancia",
                Descricao = "325ml de soda italiana sabor melancia. Fresca, doce e com aquela cor vibrante de verão, a soda que chega e já parece um convite para relaxar.",
                QtdEstoque = 20,
                Preco = 10.00m,
                ImagemUrl = "/img/produtos/bebidas/soda-melancia.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 109,
                CategoriaId = 5,
                Nome = "Água sem Gás",
                Descricao = "500ml de água sem gás gelada. Simples, essencial e sempre bem-vinda, porque toda boa experiência começa com o básico bem feito.",
                QtdEstoque = 30,
                Preco = 3.00m,
                ImagemUrl = "/img/produtos/bebidas/agua-sem-gas.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 110,
                CategoriaId = 5,
                Nome = "Água com Gás",
                Descricao = "500ml de água com gás gelada. Borbulhante, refrescante e com aquela limpeza de paladar que prepara para o próximo gole de algo especial.",
                QtdEstoque = 30,
                Preco = 5.00m,
                ImagemUrl = "/img/produtos/bebidas/agua-com-gas.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 111,
                CategoriaId = 5,
                Nome = "Água Tônica",
                Descricao = "500ml de água tônica gelada. Levemente amarga, borbulhante e sofisticada, para quem gosta das bebidas que surpreendem com sutileza.",
                QtdEstoque = 30,
                Preco = 6.00m,
                ImagemUrl = "/img/produtos/bebidas/agua-tonica.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 112,
                CategoriaId = 5,
                Nome = "Coca-Cola®",
                Descricao = "350ml de Coca-Cola gelada. O clássico de sempre, que não precisa de apresentação, só de um copo com gelo e uma boa companhia.",
                QtdEstoque = 30,
                Preco = 6.00m,
                ImagemUrl = "/img/produtos/bebidas/coca-cola.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 113,
                CategoriaId = 5,
                Nome = "Coca-Cola® Zero",
                Descricao = "350ml de Coca-Cola Zero gelada. Todo o sabor clássico sem o açúcar, para quem quer aproveitar a Vereda do seu jeito.",
                QtdEstoque = 30,
                Preco = 6.00m,
                ImagemUrl = "/img/produtos/bebidas/coca-cola-zero.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 114,
                CategoriaId = 5,
                Nome = "Sprite®",
                Descricao = "350ml de Sprite gelado. Cítrico, borbulhante e refrescante como uma brisa no jardim, o refrigerante que casa bem com qualquer coisa do cardápio.",
                QtdEstoque = 30,
                Preco = 6.00m,
                ImagemUrl = "/img/produtos/bebidas/sprite.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 115,
                CategoriaId = 5,
                Nome = "Guaraná Antárctica®",
                Descricao = "350ml de Guaraná Antártica gelado. O refrigerante mais brasileiro de todos, doce, levinho e que combina com qualquer hora do dia.",
                QtdEstoque = 30,
                Preco = 6.00m,
                ImagemUrl = "/img/produtos/bebidas/guarana.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 116,
                CategoriaId = 5,
                Nome = "Fanta® Laranja",
                Descricao = "350ml de Fanta Laranja gelada. Laranja, doce e com aquela efervescência animada, o refrigerante que entra no cardápio como um raio de sol.",
                QtdEstoque = 30,
                Preco = 6.00m,
                ImagemUrl = "/img/produtos/bebidas/fanta-laranja.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 117,
                CategoriaId = 5,
                Nome = "H2OH! Limão",
                Descricao = "500ml de H2OH! sabor limão gelado. Leve, refrescante e com aquela acidez cítrica que abre o apetite, para quem quer hidratar com estilo.",
                QtdEstoque = 20,
                Preco = 7.00m,
                ImagemUrl = "/img/produtos/bebidas/h2oh-limao.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 118,
                CategoriaId = 5,
                Nome = "H2OH! Limoneto",
                Descricao = "500ml de H2OH! sabor limoneto gelado. Borbulhante, cítrico e levemente adocicado, a versão diferente do clássico que conquista quem experimenta.",
                QtdEstoque = 20,
                Preco = 7.00m,
                ImagemUrl = "/img/produtos/bebidas/h2oh-limoneto.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 119,
                CategoriaId = 5,
                Nome = "Del Valle Uva",
                Descricao = "290ml de Del Valle sabor uva gelado. Doce, encorpado e com aquele sabor de uva que agrada a todos, simples e sempre bem-vindo na mesa.",
                QtdEstoque = 20,
                Preco = 7.00m,
                ImagemUrl = "/img/produtos/bebidas/del-valle-uva.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 120,
                CategoriaId = 5,
                Nome = "Del Valle Maracujá",
                Descricao = "290ml de Del Valle sabor maracujá gelado. Tropical, azedinho e aromático, aquele suco de caixinha que sempre surpreende pela qualidade.",
                QtdEstoque = 20,
                Preco = 7.00m,
                ImagemUrl = "/img/produtos/bebidas/del-valle-maracuja.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 121,
                CategoriaId = 5,
                Nome = "Del Valle Pêssego",
                Descricao = "290ml de Del Valle sabor pêssego gelado. Suave, adocicado e com aquele frescor frutado que combina perfeitamente com qualquer pausa do dia.",
                QtdEstoque = 20,
                Preco = 7.00m,
                ImagemUrl = "/img/produtos/bebidas/del-valle-pessego.png",
                Ativo = true
            },

            new Produto
            {
                ProdutoId = 122,
                CategoriaId = 5,
                Nome = "Cerveja Stella Artois",
                Descricao = "330ml de Stella Artois gelada. Leve, refrescante e com aquele amargor elegante que faz dela a escolha certa para um fim de tarde no jardim da Vereda.",
                QtdEstoque = 15,
                Preco = 10.00m,
                ImagemUrl = "/img/produtos/bebidas/cerveja-stella-artois.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 123,
                CategoriaId = 5,
                Nome = "Cerveja Heineken",
                Descricao = "330ml de Heineken gelada. Encorpada, com aroma marcante e aquele amargor equilibrado que conquistou o mundo, perfeita para um momento de descanso.",
                QtdEstoque = 15,
                Preco = 10.00m,
                ImagemUrl = "/img/produtos/bebidas/cerveja-heineken.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 124,
                CategoriaId = 5,
                Nome = "Cerveja Budweiser",
                Descricao = "330ml de Budweiser gelada. Leve, suave e muito refrescante, a cerveja americana que virou clássico e combina com qualquer coisa do cardápio.",
                QtdEstoque = 15,
                Preco = 10.00m,
                ImagemUrl = "/img/produtos/bebidas/cerveja-budweiser.png",
                Ativo = true
            },

            #endregion
        };

        builder.Entity<Produto>().HasData(produtos);
    }
}